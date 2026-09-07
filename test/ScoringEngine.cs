using System;
using System.Collections.Generic;
using System.Linq;

namespace EvaluatedCodeGeneration
{
    // =====================================================================
    //  ScoringEngine
    // ---------------------------------------------------------------------
    //  Centralised, *single source of truth* for the Composite Quality Score.
    //
    //  WHY THIS FILE EXISTS (revision notes for reviewers):
    //  The previous pipeline computed the composite score inside
    //  CodeEvaluator.Evaluate(), but at the call site `spec.TestCases` was
    //  empty and the BenchmarkDotNet timings were attached *afterwards* in
    //  Program.cs. As a result Norm_Correctness and Norm_Performance were
    //  silently 0 for every row, so the published "Composite Quality Score"
    //  was effectively a 3-of-5 component average (capped at 60). This class
    //  recomputes the score from the values that are actually populated:
    //    - real Success Rate (Phase 1 reflection tests)
    //    - real median execution time + allocations (Phase 3 BenchmarkDotNet)
    //    - real Roslyn static metrics (Phase 2)
    //
    //  It also adds the COMPASS-inspired factors requested in revision:
    //    1. Correctness, Efficiency and Quality are kept as THREE
    //       independent axes (COMPASS pillars) and reported separately.
    //    2. A weighting *vector* replaces the hard-coded equal-weight 1/5,
    //       addressing Reviewer 1's "is aggregation sound / weights equal?"
    //       concern. Equal weighting is still the default, but the weights
    //       are now explicit, documented and trivially re-runnable for the
    //       robustness sensitivity analysis.
    //    3. Multi-run support (k>1) so Pass@1 determinism can be checked
    //       empirically (Reviewer 1) rather than assumed from temperature=0.
    // =====================================================================

    /// <summary>
    /// Normalisation thresholds and component weights. Centralising these
    /// makes the equal-weight choice explicit and lets us run the
    /// "exclude-correctness" robustness check (RQ3) by flipping one flag.
    /// </summary>
    public sealed class ScoringConfig
    {
        // ---- Normalisation thresholds (documented design choices) ----
        public double MaxAcceptableComplexity { get; init; } = 15.0;  // McCabe guidance
        public double MaxAcceptableNesting    { get; init; } = 5.0;
        public double MaxAcceptableNaming     { get; init; } = 10.0;
        public double PerformanceBaselineNs   { get; init; } = 10000.0;

        // ---- Component weights (must be > 0; normalised internally) ----
        // Equal weighting by default, but now EXPLICIT and tunable.
        public double W_Correctness { get; init; } = 1.0;
        public double W_Complexity  { get; init; } = 1.0;
        public double W_Nesting     { get; init; } = 1.0;
        public double W_Style       { get; init; } = 1.0;
        public double W_Performance { get; init; } = 1.0;

        /// <summary>
        /// When true, correctness is removed from the composite so the
        /// Quality axis is purely structural+performance. This is the
        /// robustness check promised in the paper's Construct Validity
        /// section (the r=0.075 was partly self-referential because
        /// Norm_Correctness was one of the five components).
        /// </summary>
        public bool ExcludeCorrectnessFromQuality { get; init; } = false;

        public static ScoringConfig Default => new ScoringConfig();

        /// <summary>Four-component quality score (no correctness) for RQ3 robustness.</summary>
        public static ScoringConfig QualityOnly => new ScoringConfig
        {
            ExcludeCorrectnessFromQuality = true
        };
    }

    /// <summary>
    /// One fully-populated measurement for a single (task, model) pair.
    /// All fields are filled BEFORE scoring, unlike the old flow.
    /// </summary>
    public sealed class ScoreInputs
    {
        public string TaskId { get; set; } = "";
        public string Model  { get; set; } = "";

        public bool Compiled { get; set; }

        // Correctness
        public double SuccessRatePct { get; set; }      // 0..100

        // Static quality (Roslyn)
        public int CyclomaticComplexity { get; set; }
        public int MaxNestingDepth { get; set; }
        public int NamingViolations { get; set; }
        public bool HasDocumentation { get; set; }
        public bool HasNullChecks { get; set; }

        // Efficiency (BenchmarkDotNet, median across N=100/1000/10000)
        public double MedianExecutionTimeNs { get; set; }
        public double AllocatedBytes { get; set; }
    }

    public sealed class ScoreResult
    {
        public string TaskId { get; set; } = "";
        public string Model  { get; set; } = "";

        // Three independent COMPASS axes (0..100), reported separately.
        public double CorrectnessScore { get; set; }
        public double EfficiencyScore  { get; set; }
        public double QualityScore     { get; set; }   // structural+style(+perf)

        // Normalised sub-components retained for transparency / appendix.
        public double Norm_Correctness { get; set; }
        public double Norm_Complexity  { get; set; }
        public double Norm_Nesting     { get; set; }
        public double Norm_Style       { get; set; }
        public double Norm_Performance { get; set; }

        // Single aggregate (weights documented), 0..100.
        public double CompositeScore { get; set; }

        // True when the solution did not compile / extract — these are
        // FLAGGED rather than silently scored 0 (Bug 3 fix).
        public bool Excluded { get; set; }
        public string? ExclusionReason { get; set; }
    }

    public static class ScoringEngine
    {
        private static double Clamp01(double x) => Math.Clamp(x, 0.0, 1.0);

        /// <summary>
        /// Compute all axes + composite for one measurement.
        /// Non-compiling / un-extractable solutions are marked Excluded
        /// (not zero-scored) so they do not contaminate model means.
        /// </summary>
        public static ScoreResult Compute(ScoreInputs s, ScoringConfig cfg)
        {
            var r = new ScoreResult { TaskId = s.TaskId, Model = s.Model };

            if (!s.Compiled)
            {
                r.Excluded = true;
                r.ExclusionReason = "did-not-compile";
                // Correctness is still meaningful if tests ran; keep it,
                // but leave quality/efficiency null-equivalent (0) AND flag.
                r.CorrectnessScore = s.SuccessRatePct;
                return r;
            }

            // 1. Correctness (already a percentage)
            r.Norm_Correctness = Clamp01(s.SuccessRatePct / 100.0);
            r.CorrectnessScore = s.SuccessRatePct;

            // 2. Complexity (inverse-normalised; simpler => higher)
            r.Norm_Complexity = Clamp01(1.0 - (s.CyclomaticComplexity / cfg.MaxAcceptableComplexity));

            // 3. Nesting (inverse-normalised)
            r.Norm_Nesting = Clamp01(1.0 - (s.MaxNestingDepth / cfg.MaxAcceptableNesting));

            // 4. Style / naming (inverse-normalised)
            r.Norm_Style = Clamp01(1.0 - (s.NamingViolations / cfg.MaxAcceptableNaming));

            // 5. Performance — decay curve against baseline.
            //    NOTE: efficiency is now derived from the REAL BenchmarkDotNet
            //    median (Phase 3), not the dead Stopwatch path.
            bool hasBenchmarkData = s.MedianExecutionTimeNs > 0;
            if (hasBenchmarkData)
                r.Norm_Performance = Clamp01(
                    cfg.PerformanceBaselineNs /
                    (cfg.PerformanceBaselineNs + s.MedianExecutionTimeNs));
            else
                r.Norm_Performance = 0.0;

            // Efficiency axis reported on 0..100 for COMPASS-style separation.
            // When no benchmark data exists, EfficiencyScore is 0 (not unknown).
            r.EfficiencyScore = r.Norm_Performance * 100.0;

            // ---- Quality axis (structural + style, optionally + perf) ----
            // The "Quality" pillar in COMPASS is independent of correctness.
            // We report it WITHOUT correctness so the three axes are clean,
            // matching the COMPASS correctness/efficiency/quality split.
            double qNum = cfg.W_Complexity * r.Norm_Complexity
                        + cfg.W_Nesting    * r.Norm_Nesting
                        + cfg.W_Style      * r.Norm_Style;
            double qDen = cfg.W_Complexity + cfg.W_Nesting + cfg.W_Style;
            r.QualityScore = (qDen > 0 ? qNum / qDen : 0) * 100.0;

            // ---- Composite (explicit weighted mean of the 5 sub-scores) ----
            // When no benchmark data is available, exclude performance from the
            // composite denominator so missing data does not penalise the score.
            double w_c = cfg.ExcludeCorrectnessFromQuality ? 0.0 : cfg.W_Correctness;
            double perfWeight = hasBenchmarkData ? cfg.W_Performance : 0.0;
            double num = w_c               * r.Norm_Correctness
                       + cfg.W_Complexity  * r.Norm_Complexity
                       + cfg.W_Nesting     * r.Norm_Nesting
                       + cfg.W_Style       * r.Norm_Style
                       + perfWeight        * r.Norm_Performance;
            double den = w_c + cfg.W_Complexity + cfg.W_Nesting
                       + cfg.W_Style + perfWeight;

            r.CompositeScore = (den > 0 ? num / den : 0) * 100.0;
            return r;
        }

        // =================================================================
        //  Multi-run aggregation (addresses Reviewer 1: Pass@1 determinism)
        // -----------------------------------------------------------------
        //  Run the generation k times; aggregate per (task,model) with mean,
        //  median and SD so reproducibility can be reported empirically.
        // =================================================================
        public sealed class Aggregated
        {
            public string TaskId = "";
            public string Model = "";
            public int Runs;
            public double CorrectnessMean, CorrectnessMedian, CorrectnessSd;
            public double EfficiencyMean,  EfficiencyMedian,  EfficiencySd;
            public double QualityMean,     QualityMedian,     QualitySd;
            public double CompositeMean,   CompositeMedian,   CompositeSd;
            public int ExcludedRuns;
        }

        public static Aggregated Aggregate(string taskId, string model, IReadOnlyList<ScoreResult> runs)
        {
            var ok = runs.Where(r => !r.Excluded).ToList();
            var agg = new Aggregated
            {
                TaskId = taskId, Model = model,
                Runs = runs.Count,
                ExcludedRuns = runs.Count - ok.Count
            };
            if (ok.Count == 0) return agg;

            (double mean, double median, double sd) Stats(IEnumerable<double> xs)
            {
                var a = xs.ToArray();
                double mean = a.Average();
                var sorted = a.OrderBy(v => v).ToArray();
                int n = sorted.Length;
                double median = n % 2 == 1
                    ? sorted[n / 2]
                    : (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
                double sd = n > 1
                    ? Math.Sqrt(a.Sum(v => (v - mean) * (v - mean)) / (n - 1))
                    : 0.0;
                return (mean, median, sd);
            }

            (agg.CorrectnessMean, agg.CorrectnessMedian, agg.CorrectnessSd) = Stats(ok.Select(r => r.CorrectnessScore));
            (agg.EfficiencyMean,  agg.EfficiencyMedian,  agg.EfficiencySd)  = Stats(ok.Select(r => r.EfficiencyScore));
            (agg.QualityMean,     agg.QualityMedian,     agg.QualitySd)     = Stats(ok.Select(r => r.QualityScore));
            (agg.CompositeMean,   agg.CompositeMedian,   agg.CompositeSd)   = Stats(ok.Select(r => r.CompositeScore));
            return agg;
        }
    }
}
