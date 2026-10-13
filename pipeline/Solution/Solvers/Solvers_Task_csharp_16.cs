// Auto-generated Solvers for Task: csharp_16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_16.GPT
{
using System;

public class Solver
{
    public static bool IsPalindrome(string text)
    {
        if (text == null)
            return false;

        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_16.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Checks if given string is a palindrome
    /// </summary>
    public static bool IsPalindrome(string text)
    {
        if (text == null)
        {
            return false;
        }

        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_16.Claude
{
using System;

public class Solver
{
    public static bool IsPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text)) return true;
        var rev = new string(text.ToCharArray().Reverse().ToArray());
        return text == rev;
    }
}
}

namespace Benchmarks.csharp_16.Grok
{
public class Solver
{
    public static bool IsPalindrome(string text)
    {
        int left = 0;
        int right = text.Length - 1;
        while (left < right)
        {
            if (text[left] != text[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_16.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static bool IsPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
            return true;

        return text.SequenceEqual(text.Reverse());
    }
}
}

namespace Benchmarks.csharp_16.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static bool IsPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
            return true;
        
        int left = 0;
        int right = text.Length - 1;
        
        while (left < right)
        {
            if (text[left] != text[right])
                return false;
            left++;
            right--;
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_16.Llama
{
using System;
using System.Linq;

public class Solver
{
    public static bool IsPalindrome(string text)
    {
        var cleanedText = text.ToLower();
        var left = 0;
        var right = cleanedText.Length - 1;
        while (left < right)
        {
            if (cleanedText[left] != cleanedText[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
}
