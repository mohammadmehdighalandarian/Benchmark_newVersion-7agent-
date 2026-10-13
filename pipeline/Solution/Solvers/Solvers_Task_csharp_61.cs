// Auto-generated Solvers for Task: csharp_61
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_61.GPT
{
using System;

public class Solver
{
    public static bool CheckIfLastCharIsALetter(string txt)
    {
        if (string.IsNullOrEmpty(txt))
            return false;

        char last = txt[txt.Length - 1];

        if (!char.IsLetter(last))
            return false;

        if (txt.Length == 1)
            return true;

        return txt[txt.Length - 2] == ' ';
    }
}
}

namespace Benchmarks.csharp_61.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    /// <summary> 
    /// Returns True if the last character of a given string is an alphabetical character 
    /// and is not a part of a word (separated by a space), and False otherwise.
    /// </summary>
    public static bool CheckIfLastCharIsALetter(string txt)
    {
        if (string.IsNullOrEmpty(txt))
        {
            return false;
        }

        int n = txt.Length;
        char lastChar = txt[n - 1];

        // Check if the last character is an alphabetical character
        if (!char.IsLetter(lastChar))
        {
            return false;
        }

        // A character is "not part of a word" if it is standalone.
        // This means either the string length is 1, or the character before it is a space.
        if (n == 1 || txt[n - 2] == ' ')
        {
            return true;
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_61.Claude
{
using System;

public class Solver
{
    public static bool CheckIfLastCharIsALetter(string txt)
    {
        if (string.IsNullOrEmpty(txt)) return false;
        char last = txt[txt.Length - 1];
        if (!char.IsLetter(last)) return false;
        if (txt.Length == 1) return true;
        return txt[txt.Length - 2] == ' ';
    }
}
}

namespace Benchmarks.csharp_61.Grok
{
using System;

public class Solver
{
    public static bool CheckIfLastCharIsALetter(string txt)
    {
        if (string.IsNullOrEmpty(txt)) return false;
        char last = txt[txt.Length - 1];
        if (!char.IsLetter(last)) return false;
        if (txt.Length == 1) return true;
        char before = txt[txt.Length - 2];
        return before == ' ';
    }
}
}

namespace Benchmarks.csharp_61.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static bool CheckIfLastCharIsALetter(string txt)
    {
        if (string.IsNullOrEmpty(txt))
            return false;

        char lastChar = txt.TrimEnd()[^1];
        return char.IsLetter(lastChar) && txt.EndsWith($" {lastChar}") && !txt.EndsWith($"  {lastChar}");
    }
}
}

namespace Benchmarks.csharp_61.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static bool CheckIfLastCharIsALetter(string txt)
    {
        if (string.IsNullOrEmpty(txt))
            return false;
        
        char lastChar = txt[txt.Length - 1];
        
        if (!char.IsLetter(lastChar))
            return false;
        
        string[] words = txt.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        if (words.Length == 0)
            return false;
        
        string lastWord = words[words.Length - 1];
        
        return lastWord.Length == 1 && char.IsLetter(lastWord[0]);
    }
}
}

namespace Benchmarks.csharp_61.Llama
{
using System;
using System.Linq;

public class Solver 
{
    public static bool CheckIfLastCharIsALetter(string txt) 
    {
        txt = txt.TrimEnd();
        if (string.IsNullOrEmpty(txt)) 
        {
            return false;
        }
        char lastChar = txt[txt.Length - 1];
        return char.IsLetter(lastChar) && txt.Split(' ').Last().Length == 1;
    }
}
}
