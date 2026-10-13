// =====================================================================
//  GenerationPhase.cs  -  PHASE 2 (generation)
// ---------------------------------------------------------------------
//  Generation used to happen entirely outside the repository: there was
//  no API client, no request construction and no response persistence
//  anywhere in the codebase, so the stage could not be re-run at all.
//
//  This implements it. For each task and each configured model it builds
//  the prompt from PromptTemplates, sends it with EXPLICIT decoding
//  parameters, and persists the RAW response body before anything is
//  parsed out of it.
//
//  Three things this is careful about, because each was a stated
//  reproducibility limitation:
//
//  1. PINNED IDENTIFIERS. The model id is whatever the config file says,
//     and no identifier is hardcoded anywhere in this repository. Ids
//     that look like moving aliases are rejected before any request is
//     sent, because an alias resolves to different weights over time and
//     silently invalidates a repeat run.
//
//  2. THE RESOLVED MODEL. Providers return a `model` field in the
//     response body carrying the snapshot that actually served the
//     request. That field is extracted into the manifest, so the study
//     records what answered rather than what was asked for. This is the
//     field whose absence left three of seven models unpinnable.
//
//  3. EXPLICIT DECODING. temperature is written into the request body
//     rather than relied on as a documented default.
// =====================================================================

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvaluatedCodeGeneration
{
    /// <summary>One configured model endpoint.</summary>
    public sealed class ModelConfig
    {
        /// <summary>Column label used throughout the pipeline (GPT, Gemini, ...).</summary>
        [JsonPropertyName("label")]        public string Label { get; set; } = "";

        /// <summary>Request/response shape: "openai" or "anthropic".</summary>
        [JsonPropertyName("api_style")]    public string ApiStyle { get; set; } = "openai";

        [JsonPropertyName("endpoint")]     public string Endpoint { get; set; } = "";

        /// <summary>
        /// The PINNED model identifier. Must name an immutable snapshot;
        /// see ValidatePinned.
        /// </summary>
        [JsonPropertyName("model_id")]     public string ModelId { get; set; } = "";

        /// <summary>Environment variable holding the API key.</summary>
        [JsonPropertyName("api_key_env")]  public string ApiKeyEnv { get; set; } = "";

        [JsonPropertyName("max_tokens")]   public int MaxTokens { get; set; } = 4096;

        /// <summary>Extra headers, e.g. an API version header.</summary>
        [JsonPropertyName("headers")]
        public Dictionary<string, string> Headers { get; set; } = new();
    }

    public sealed class GenerationConfig
    {
        /// <summary>Decoding temperature. The study claims 0; it is sent explicitly.</summary>
        [JsonPropertyName("temperature")] public double Temperature { get; set; } = 0.0;

        [JsonPropertyName("models")]      public List<ModelConfig> Models { get; set; } = new();

        public static GenerationConfig Load(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException(
                    "Generation config not found. Run 'generate-template <path>' to write a " +
                    "starting point, then fill in pinned model identifiers.", path);

            var cfg = JsonSerializer.Deserialize<GenerationConfig>(File.ReadAllText(path))
                      ?? throw new InvalidDataException("Generation config is empty.");
            if (cfg.Models.Count == 0)
                throw new InvalidDataException("Generation config lists no models.");
            return cfg;
        }

        /// <summary>
        /// A config template. Model identifiers are deliberately left blank:
        /// they must be the exact snapshots the study used, and guessing them
        /// here would be inventing provenance.
        /// </summary>
        public static void WriteTemplate(string path)
        {
            var template = new GenerationConfig
            {
                Temperature = 0.0,
                Models = new List<ModelConfig>
                {
                    new ModelConfig { Label = "GPT",      ApiStyle = "openai",    Endpoint = "", ModelId = "", ApiKeyEnv = "OPENAI_API_KEY" },
                    new ModelConfig { Label = "Gemini",   ApiStyle = "openai",    Endpoint = "", ModelId = "", ApiKeyEnv = "GEMINI_API_KEY" },
                    new ModelConfig { Label = "Claude",   ApiStyle = "anthropic", Endpoint = "", ModelId = "", ApiKeyEnv = "ANTHROPIC_API_KEY" },
                    new ModelConfig { Label = "Grok",     ApiStyle = "openai",    Endpoint = "", ModelId = "", ApiKeyEnv = "XAI_API_KEY" },
                    new ModelConfig { Label = "Mistral",  ApiStyle = "openai",    Endpoint = "", ModelId = "", ApiKeyEnv = "MISTRAL_API_KEY" },
                    new ModelConfig { Label = "DeepSeek", ApiStyle = "openai",    Endpoint = "", ModelId = "", ApiKeyEnv = "DEEPSEEK_API_KEY" },
                    new ModelConfig { Label = "Llama",    ApiStyle = "openai",    Endpoint = "", ModelId = "", ApiKeyEnv = "LLAMA_API_KEY" },
                },
            };

            File.WriteAllText(path,
                JsonSerializer.Serialize(template, new JsonSerializerOptions { WriteIndented = true }),
                new UTF8Encoding(false));

            Console.WriteLine($"  [Generate] wrote config template -> {path}");
            Console.WriteLine("  [Generate] fill in endpoint and PINNED model_id for each model before running.");
        }
    }

    public static class GenerationPhase
    {
        private static readonly HttpClient Http = new HttpClient { Timeout = TimeSpan.FromMinutes(5) };

        // -----------------------------------------------------------------
        //  Alias rejection.
        //
        //  An alias ("gpt-4o", "claude-sonnet-4-5", "-latest") resolves to
        //  whatever the provider currently points it at. Pinned snapshots
        //  carry a date or an explicit version suffix. This refuses the
        //  former rather than letting a run silently become unrepeatable.
        // -----------------------------------------------------------------
        private static readonly Regex PinnedShape =
            new Regex(@"(\d{8}|\d{4}-\d{2}-\d{2}|@\d|:\d|-v\d)", RegexOptions.IgnoreCase);

        public static void ValidatePinned(GenerationConfig cfg)
        {
            var problems = new List<string>();
            foreach (var m in cfg.Models)
            {
                if (string.IsNullOrWhiteSpace(m.ModelId))
                    problems.Add($"{m.Label}: model_id is empty.");
                else if (m.ModelId.Contains("latest", StringComparison.OrdinalIgnoreCase))
                    problems.Add($"{m.Label}: '{m.ModelId}' is a moving alias.");
                else if (!PinnedShape.IsMatch(m.ModelId))
                    problems.Add($"{m.Label}: '{m.ModelId}' has no version or date suffix, " +
                                 "so it is probably an alias rather than a pinned snapshot.");

                if (string.IsNullOrWhiteSpace(m.Endpoint))
                    problems.Add($"{m.Label}: endpoint is empty.");
            }

            if (problems.Count > 0)
                throw new InvalidOperationException(
                    "Generation config is not reproducible:\n  - " + string.Join("\n  - ", problems));
        }

        // -----------------------------------------------------------------
        //  Run
        // -----------------------------------------------------------------

        /// <summary>
        /// Queries every configured model for every task, persisting the raw
        /// response and the extracted code per (task, model).
        /// </summary>
        public static async Task RunAsync(
            IReadOnlyList<TaskRecord> tasks,
            GenerationConfig cfg,
            string outDir)
        {
            ValidatePinned(cfg);

            string rawDir = Path.Combine(outDir, "raw");
            string codeDir = Path.Combine(outDir, "code");
            Directory.CreateDirectory(rawDir);
            Directory.CreateDirectory(codeDir);

            string manifestPath = Path.Combine(outDir, "generation_manifest.tsv");
            bool newManifest = !File.Exists(manifestPath);
            using var manifest = new StreamWriter(manifestPath, append: true);
            if (newManifest)
                manifest.WriteLine(string.Join("\t",
                    "timestamp", "task_id", "model_label", "requested_model_id",
                    "resolved_model", "temperature", "http_status", "response_chars",
                    "extracted_chars", "error"));

            foreach (var task in tasks)
            {
                string safeId = DatasetPreparation.SafeTaskId(task.task_id);
                string prompt = PromptTemplates.Solution(task);

                foreach (var model in cfg.Models)
                {
                    string rawPath = Path.Combine(rawDir, $"{safeId}__{model.Label}.json");
                    if (File.Exists(rawPath))
                    {
                        Console.WriteLine($"  [Skip] {safeId}/{model.Label} (already generated)");
                        continue;
                    }

                    string status = "", resolved = "", error = "", body = "", code = "";
                    try
                    {
                        (status, body) = await SendAsync(model, cfg.Temperature, prompt);

                        // Persist the RAW body before parsing anything out of it.
                        File.WriteAllText(rawPath, body, new UTF8Encoding(false));

                        resolved = ExtractResolvedModel(body);
                        code = ExtractCode(ExtractText(body, model.ApiStyle));

                        if (string.IsNullOrWhiteSpace(code))
                            error = "no code block recovered from the response";
                        else
                            File.WriteAllText(Path.Combine(codeDir, $"{safeId}__{model.Label}.cs"),
                                              code, new UTF8Encoding(false));
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message.Replace('\t', ' ').Replace('\n', ' ');
                    }

                    manifest.WriteLine(string.Join("\t",
                        DateTime.UtcNow.ToString("o"), task.task_id, model.Label, model.ModelId,
                        resolved, cfg.Temperature.ToString(System.Globalization.CultureInfo.InvariantCulture),
                        status, body.Length, code.Length, error));
                    manifest.Flush();

                    Console.WriteLine($"  [{safeId}] {model.Label}: {status} " +
                                      (string.IsNullOrEmpty(resolved) ? "" : $"resolved={resolved} ") +
                                      (string.IsNullOrEmpty(error) ? "" : $"ERROR {error}"));
                }
            }

            Console.WriteLine($"  [Generate] raw responses -> {rawDir}");
            Console.WriteLine($"  [Generate] manifest       -> {manifestPath}");
        }

        private static async Task<(string status, string body)> SendAsync(
            ModelConfig model, double temperature, string prompt)
        {
            string? key = Environment.GetEnvironmentVariable(model.ApiKeyEnv);
            if (string.IsNullOrWhiteSpace(key))
                throw new InvalidOperationException($"environment variable {model.ApiKeyEnv} is not set");

            object payload = model.ApiStyle.Equals("anthropic", StringComparison.OrdinalIgnoreCase)
                ? new
                {
                    model = model.ModelId,
                    max_tokens = model.MaxTokens,
                    temperature,                       // explicit, not defaulted
                    messages = new[] { new { role = "user", content = prompt } },
                }
                : (object)new
                {
                    model = model.ModelId,
                    max_tokens = model.MaxTokens,
                    temperature,                       // explicit, not defaulted
                    messages = new[] { new { role = "user", content = prompt } },
                };

            using var request = new HttpRequestMessage(HttpMethod.Post, model.Endpoint)
            {
                Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json"),
            };

            if (model.ApiStyle.Equals("anthropic", StringComparison.OrdinalIgnoreCase))
                request.Headers.TryAddWithoutValidation("x-api-key", key);
            else
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key);

            foreach (var (name, value) in model.Headers)
                request.Headers.TryAddWithoutValidation(name, value);

            using var response = await Http.SendAsync(request);
            string body = await response.Content.ReadAsStringAsync();
            return (((int)response.StatusCode).ToString(), body);
        }

        /// <summary>
        /// The provider's own `model` field: the snapshot that actually
        /// served the request, which is what makes a run repeatable.
        /// </summary>
        public static string ExtractResolvedModel(string body)
        {
            try
            {
                using var doc = JsonDocument.Parse(body);
                return doc.RootElement.TryGetProperty("model", out var m) ? m.GetString() ?? "" : "";
            }
            catch { return ""; }
        }

        private static string ExtractText(string body, string apiStyle)
        {
            try
            {
                using var doc = JsonDocument.Parse(body);
                var root = doc.RootElement;

                if (apiStyle.Equals("anthropic", StringComparison.OrdinalIgnoreCase))
                {
                    if (root.TryGetProperty("content", out var content) && content.GetArrayLength() > 0)
                        return string.Concat(content.EnumerateArray()
                            .Where(b => b.TryGetProperty("text", out _))
                            .Select(b => b.GetProperty("text").GetString()));
                    return "";
                }

                if (root.TryGetProperty("choices", out var choices) && choices.GetArrayLength() > 0)
                    return choices[0].GetProperty("message").GetProperty("content").GetString() ?? "";
                return "";
            }
            catch { return ""; }
        }

        // -----------------------------------------------------------------
        //  Code extraction: handles fenced blocks, prose around them, and
        //  responses that are bare code with no fence at all.
        // -----------------------------------------------------------------
        public static string ExtractCode(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";

            var fenced = Regex.Match(text, @"```(?:csharp|cs|c#)?\s*\r?\n(.*?)```",
                                     RegexOptions.Singleline | RegexOptions.IgnoreCase);
            if (fenced.Success) return fenced.Groups[1].Value.Trim();

            // No fence: keep it only if it actually looks like C#.
            if (Regex.IsMatch(text, @"\b(class|using|namespace|public|static)\b"))
                return text.Trim();

            return "";
        }
    }
}
