// Auto-generated Solvers for Task: csharp_3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_3.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static object Longest(List<string> strings)
    {
        if (strings == null || strings.Count == 0)
            return null;

        string longest = strings[0];

        foreach (string s in strings)
        {
            if (s.Length > longest.Length)
                longest = s;
        }

        return longest;
    }
}
}

namespace Benchmarks.csharp_3.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Out of list of strings, return the Longest one. Return the first one in case of multiple
    /// strings of the same length. Return null (None) in case the input list is empty.
    /// </summary>
    public static object Longest(List<string> strings)
    {
        if (strings == null || strings.Count == 0)
        {
            return null;
        }

        string longestSoFar = strings[0];

        foreach (string s in strings)
        {
            if (s.Length > longestSoFar.Length)
            {
                longestSoFar = s;
            }
        }

        return longestSoFar;
    }
}
}

namespace Benchmarks.csharp_3.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object Longest(List<string> strings)
    {
        if (strings == null || strings.Count == 0) return null;
        return strings.OrderByDescending(s => s.Length).First();
    }
}
}

namespace Benchmarks.csharp_3.Grok
{
using System.Collections.Generic;

public class Solver
{
    public static object Longest(List<string> strings)
    {
        if (strings == null || strings.Count == 0)
        {
            return null;
        }

        string longest = strings[0];
        int maxLen = longest.Length;

        for (int i = 1; i < strings.Count; i++)
        {
            if (strings[i].Length > maxLen)
            {
                longest = strings[i];
                maxLen = strings[i].Length;
            }
        }

        return longest;
    }
}
}

namespace Benchmarks.csharp_3.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string Longest(List<string> strings)
    {
        if (strings == null || strings.Count == 0)
        {
            return null;
        }

        string longest = strings.OrderByDescending(s => s.Length).First();
        return longest;
    }
}
}

namespace Benchmarks.csharp_3.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object Longest(List<string> strings)
    {
        if (strings == null || strings.Count == 0)
        {
            return null;
        }
        
        return strings.OrderByDescending(s => s.Length).First();
    }
}
}

namespace Benchmarks.csharp_3.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static object Longest(List<string> strings) 
    {
        if (strings.Count == 0) return null;
        return strings.OrderByDescending(s => s.Length).First();
    }
}
}
