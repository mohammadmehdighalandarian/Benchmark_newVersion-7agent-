// Auto-generated Solvers for Task: csharp_53
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_53.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> SelectWords(string s, int n)
    {
        var result = new List<string>();
        if (string.IsNullOrWhiteSpace(s)) return result;

        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            int consonants = 0;

            foreach (char c in word)
            {
                char ch = char.ToLower(c);
                if (!vowels.Contains(ch))
                    consonants++;
            }

            if (consonants == n)
                result.Add(word);
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_53.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Returns a list of all words from string s that contain exactly 
    /// n consonants, in the order they appear.
    /// </summary>
    public static List<string> SelectWords(string s, int n)
    {
        // Return an empty list if the input string is null or empty
        if (string.IsNullOrEmpty(s))
        {
            return new List<string>();
        }

        const string vowels = "aeiouAEIOU";
        // Split the string by spaces to isolate words
        string[] words = s.Split(' ');
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            // Skip empty strings resulting from multiple spaces
            if (string.IsNullOrEmpty(word))
            {
                continue;
            }

            int consonantCount = 0;
            foreach (char c in word)
            {
                // A character is a consonant if it is a letter and not a vowel
                if (char.IsLetter(c) && !vowels.Contains(c))
                {
                    consonantCount++;
                }
            }

            // If the count matches n, add the word to the result list
            if (consonantCount == n)
            {
                result.Add(word);
            }
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_53.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> SelectWords(string s, int n)
    {
        if (string.IsNullOrEmpty(s)) return new List<string>();
        string vowels = "aeiouAEIOU";
        return s.Split(' ')
            .Where(w => w.Count(c => char.IsLetter(c) && !vowels.Contains(c)) == n)
            .ToList();
    }
}
}

namespace Benchmarks.csharp_53.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<string> SelectWords(string s, int n)
    {
        var words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var result = new List<string>();
        foreach (var word in words)
        {
            int consonantCount = 0;
            foreach (char c in word)
            {
                if (char.IsLetter(c) && !"aeiouAEIOU".Contains(c))
                {
                    consonantCount++;
                }
            }
            if (consonantCount == n)
            {
                result.Add(word);
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_53.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> SelectWords(string s, int n)
    {
        if (string.IsNullOrEmpty(s))
            return new List<string>();

        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return words
            .Where(word => word.Count(c => !vowels.Contains(c)) == n)
            .ToList();
    }
}
}

namespace Benchmarks.csharp_53.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> SelectWords(string s, int n)
    {
        if (string.IsNullOrEmpty(s))
        {
            return new List<string>();
        }
        
        string[] words = s.Split(' ');
        List<string> result = new List<string>();
        
        foreach (string word in words)
        {
            int consonantCount = 0;
            foreach (char c in word.ToLower())
            {
                if (IsConsonant(c))
                {
                    consonantCount++;
                }
            }
            
            if (consonantCount == n)
            {
                result.Add(word);
            }
        }
        
        return result;
    }
    
    private static bool IsConsonant(char c)
    {
        return c >= 'a' && c <= 'z' && !IsVowel(c);
    }
    
    private static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
}

namespace Benchmarks.csharp_53.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> SelectWords(string s, int n)
    {
        return s.Split(' ')
               .Where(word => CountConsonants(word) == n)
               .ToList();
    }

    private static int CountConsonants(string word)
    {
        return word.ToLower()
                   .Count(c => char.IsLetter(c) && !"aeiou".Contains(c));
    }
}
}
