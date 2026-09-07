// Auto-generated Solvers for Task: csharp_39
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_39.GPT
{
using System;
using System.Text.RegularExpressions;

public class Solver
{
    public static int IsBored(string S)
    {
        if (string.IsNullOrEmpty(S)) return 0;

        var sentences = Regex.Split(S, "[.!?]");
        int count = 0;

        foreach (var sentence in sentences)
        {
            var trimmed = sentence.Trim();
            if (trimmed.Length == 0) continue;

            var words = trimmed.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 0 && words[0] == "I")
            {
                count++;
            }
        }

        return count;
    }
}
}

namespace Benchmarks.csharp_39.Gemini
{
using System;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// You're an expert C# programmer
    /// 
    /// You'll be given a string of words, and your task is to count the number
    /// of boredoms. A boredom is a sentence that starts with the word "I".
    /// Sentences are delimited by '.', '?' or '!'.
    /// 
    /// For example:
    /// >>> IsBored("Hello world")
    /// 0
    /// >>> IsBored("The sky is blue. The sun is shining. I love this weather")
    /// 1
    /// 
    /// </summary>
    public static int IsBored(string S)
    {
        if (string.IsNullOrEmpty(S))
        {
            return 0;
        }

        // Define the sentence delimiters
        char[] delimiters = new char[] { '.', '?', '!' };

        // Split the input string into sentences based on delimiters
        string[] sentences = S.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        int boredomCount = 0;

        foreach (string sentence in sentences)
        {
            // Trim leading and trailing whitespace from the sentence
            string trimmedSentence = sentence.Trim();

            // A boredom is a sentence that starts with the word "I"
            // We split by space to isolate the first word
            string[] words = trimmedSentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0 && words[0] == "I")
            {
                boredomCount++;
            }
        }

        return boredomCount;
    }
}
}

namespace Benchmarks.csharp_39.Claude
{
using System;
using System.Text.RegularExpressions;

public class Solver
{
    public static int IsBored(string S)
    {
        var sentences = Regex.Split(S.Trim(), @"[.?!]");
        int count = 0;
        foreach (var s in sentences)
            if (Regex.IsMatch(s.Trim(), @"^I\b"))
                count++;
        return count;
    }
}
}

namespace Benchmarks.csharp_39.Grok
{
using System;

public class Solver
{
    public static int IsBored (string S) 
    {
        if (string.IsNullOrWhiteSpace(S)) return 0;
        string[] parts = S.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        foreach (string part in parts)
        {
            string sentence = part.Trim();
            if (sentence == "I" || sentence.StartsWith("I "))
            {
                count++;
            }
        }
        return count;
    }
}
}

namespace Benchmarks.csharp_39.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static int IsBored(string S)
    {
        if (string.IsNullOrEmpty(S))
            return 0;

        var sentences = S.Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        return sentences.Count(sentence => sentence.TrimStart().StartsWith("I"));
    }
}
}

namespace Benchmarks.csharp_39.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int IsBored(string S)
    {
        if (string.IsNullOrWhiteSpace(S))
            return 0;
            
        string[] sentences = Regex.Split(S, @"(?<=[.!?])\s+");
        int count = 0;
        
        foreach (string sentence in sentences)
        {
            string trimmed = sentence.TrimStart();
            if (trimmed.StartsWith("I ", StringComparison.OrdinalIgnoreCase) ||
                trimmed.Equals("I", StringComparison.OrdinalIgnoreCase) ||
                (trimmed.Length >= 2 && trimmed[0] == 'I' && (trimmed[1] == ' ' || trimmed[1] == '\'')))
            {
                count++;
            }
        }
        
        return count;
    }
}
}

namespace Benchmarks.csharp_39.Llama
{
using System;
using System.Linq;

public class Solver
{
    public static int IsBored(string S)
    {
        int boredCount = 0;
        char[] delimiters = { '.', '?', '!' };
        string[] sentences = S.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        foreach (string sentence in sentences)
        {
            string trimmedSentence = sentence.Trim();
            if (trimmedSentence.StartsWith("I ", StringComparison.OrdinalIgnoreCase) || trimmedSentence.Equals("I", StringComparison.OrdinalIgnoreCase))
            {
                boredCount++;
            }
        }

        return boredCount;
    }
}
}
