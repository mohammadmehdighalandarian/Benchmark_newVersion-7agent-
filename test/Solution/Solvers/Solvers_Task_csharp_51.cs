// Auto-generated Solvers for Task: csharp_51
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_51.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> ReverseDelete(string s, string c)
    {
        var set = new HashSet<char>(c);
        
        var filtered = new string(s.Where(ch => !set.Contains(ch)).ToArray());
        
        bool isPalindrome = true;
        int i = 0, j = filtered.Length - 1;
        
        while (i < j)
        {
            if (filtered[i] != filtered[j])
            {
                isPalindrome = false;
                break;
            }
            i++;
            j--;
        }
        
        return new List<object> { filtered, isPalindrome };
    }
}
}

namespace Benchmarks.csharp_51.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
/// <summary>
/// Deletes all characters in s that are equal to any character in c
/// then checks if the result string is a palindrome.
/// Returns a list containing the result string and the palindrome check result.
/// </summary>
public static List<object> ReverseDelete(string s, string c)
{
HashSet<char> charsToRemove = new HashSet<char>(c);


    // Filter out characters found in c
    string resultStr = new string(s.Where(ch => !charsToRemove.Contains(ch)).ToArray());
    
    // Check for palindrome
    bool isPalindrome = true;
    for (int i = 0; i < resultStr.Length / 2; i++)
    {
        if (resultStr[i] != resultStr[resultStr.Length - 1 - i])
        {
            isPalindrome = false;
            break;
        }
    }
    
    return new List<object> { resultStr, isPalindrome };
}



}
}

namespace Benchmarks.csharp_51.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> ReverseDelete(string s, string c)
    {
        var result = new string(s.Where(ch => !c.Contains(ch)).ToArray());
        bool isPalindrome = result == new string(result.Reverse().ToArray());
        return new List<object> { result, isPalindrome };
    }
}
}

namespace Benchmarks.csharp_51.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<object> ReverseDelete (string s, string c) 
    {
        var toRemove = new HashSet<char>(c);
        string result = "";
        foreach (char ch in s)
        {
            if (!toRemove.Contains(ch))
            {
                result += ch;
            }
        }
        
        bool isPalindrome = true;
        int len = result.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (result[i] != result[len - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        
        return new List<object> { result, isPalindrome };
    }
}
}

namespace Benchmarks.csharp_51.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> ReverseDelete(string s, string c)
    {
        string filtered = new string(s.Where(ch => !c.Contains(ch)).ToArray());
        bool isPalindrome = filtered.SequenceEqual(filtered.Reverse());
        return new List<object> { filtered, isPalindrome };
    }
}
}

namespace Benchmarks.csharp_51.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> ReverseDelete(string s, string c)
    {
        HashSet<char> charsToDelete = new HashSet<char>(c);
        string result = new string(s.Where(ch => !charsToDelete.Contains(ch)).ToArray());
        
        bool isPalindrome = IsPalindrome(result);
        
        return new List<object> { result, isPalindrome };
    }
    
    private static bool IsPalindrome(string str)
    {
        if (string.IsNullOrEmpty(str))
            return true;
            
        int left = 0;
        int right = str.Length - 1;
        
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_51.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<object> ReverseDelete(string s, string c) 
    {
        var resultString = new string(s.Where(ch => !c.Contains(ch)).ToArray());
        var isPalindrome = resultString.SequenceEqual(resultString.Reverse());
        return new List<object> { resultString, isPalindrome };
    }
}
}
