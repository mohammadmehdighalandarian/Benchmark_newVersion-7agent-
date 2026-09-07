// Auto-generated Solvers for Task: csharp_44
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_44.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> WordsString(string s)
    {
        if (string.IsNullOrEmpty(s))
            return new List<string>();

        string cleaned = s.Replace(",", " ");
        string[] parts = cleaned.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return parts.ToList();
    }
}
}

namespace Benchmarks.csharp_44.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Splits a string of words separated by commas or spaces into a list of words.
    /// </summary>
    public static List<string> WordsString(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return new List<string>();
        }

        // Split the string using both comma and space as delimiters.
        // StringSplitOptions.RemoveEmptyEntries handles cases like ", " to avoid empty strings in the result.
        string[] parts = s.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        return parts.ToList();
    }
}
}

namespace Benchmarks.csharp_44.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static List<string> WordsString(string s)
    {
        return Regex.Split(s, @"[\s,]+").Where(w => w.Length > 0).ToList();
    }
}
}

namespace Benchmarks.csharp_44.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<string> WordsString(string s)
    {
        char[] delimiters = { ' ', ',' };
        string[] words = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        return new List<string>(words);
    }
}
}

namespace Benchmarks.csharp_44.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> WordsString(string s)
    {
        return s.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}
}

namespace Benchmarks.csharp_44.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> WordsString(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return new List<string>();
        
        // Split by commas or spaces, ignoring empty entries
        string[] separators = { ",", " " };
        return s.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.Trim())
                .Where(word => !string.IsNullOrEmpty(word))
                .ToList();
    }
}
}

namespace Benchmarks.csharp_44.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<string> WordsString(string s) 
    {
        return s.Replace(",", " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}
}
