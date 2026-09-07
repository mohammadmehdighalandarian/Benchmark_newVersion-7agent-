// Auto-generated Solvers for Task: csharp_65
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_65.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static string WordsInSentence(string sentence)
    {
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();

        foreach (var word in words)
        {
            int len = word.Length;
            if (IsPrime(len))
            {
                result.Add(word);
            }
        }

        return string.Join(" ", result);
    }

    private static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_65.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Returns a string containing words from the original sentence whose lengths are prime numbers.
    /// </summary>
    public static string WordsInSentence(string sentence)
    {
        if (string.IsNullOrEmpty(sentence))
        {
            return string.Empty;
        }

        // Split by space, keeping the original order.
        string[] words = sentence.Split(' ');
        
        // Filter words where the length of the word is a prime number.
        var primeLengthWords = words.Where(word => IsPrime(word.Length));
        
        // Join the result back with a single space.
        return string.Join(" ", primeLengthWords);
    }

    /// <summary>
    /// Helper method to determine if a number is prime.
    /// </summary>
    private static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        
        int boundary = (int)Math.Floor(Math.Sqrt(n));
        
        for (int i = 3; i <= boundary; i += 2)
        {
            if (n % i == 0) return false;
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_65.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string WordsInSentence(string sentence)
    {
        bool IsPrime(int n) {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
        return string.Join(" ", sentence.Split(' ').Where(w => IsPrime(w.Length)));
    }
}
}

namespace Benchmarks.csharp_65.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static string WordsInSentence(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();
        foreach (string word in words)
        {
            int len = word.Length;
            if (IsPrime(len))
            {
                result.Add(word);
            }
        }
        return string.Join(" ", result);
    }

    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_65.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string WordsInSentence(string sentence)
    {
        string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> primeLengthWords = new List<string>();

        foreach (string word in words)
        {
            if (IsPrime(word.Length))
            {
                primeLengthWords.Add(word);
            }
        }

        return string.Join(" ", primeLengthWords);
    }

    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_65.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static string WordsInSentence(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
            return string.Empty;
        
        string[] words = sentence.Split(' ');
        List<string> resultWords = new List<string>();
        
        foreach (string word in words)
        {
            int length = word.Length;
            if (IsPrime(length))
            {
                resultWords.Add(word);
            }
        }
        
        return string.Join(" ", resultWords);
    }
    
    private static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;
        
        int boundary = (int)Math.Sqrt(number);
        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_65.Llama
{
using System;
using System.Linq;

public class Solver 
{
    public static string WordsInSentence(string sentence) 
    {
        return string.Join(" ", sentence.Split(' ').Where(word => IsPrime(word.Length)));
    }

    private static bool IsPrime(int number) 
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
}
