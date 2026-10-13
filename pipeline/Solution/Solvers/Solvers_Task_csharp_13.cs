// Auto-generated Solvers for Task: csharp_13
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_13.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static bool PairsSumToZero(List<int> l)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int x in l)
        {
            if (seen.Contains(-x))
                return true;

            seen.Add(x);
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_13.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// PairsSumToZero takes a list of integers as an input.
    /// It returns True if there are two distinct elements in the list that
    /// sum to zero, and False otherwise.
    /// </summary>
    public static bool PairsSumToZero(List<int> l)
    {
        if (l == null || l.Count < 2)
        {
            return false;
        }

        HashSet<int> seen = new HashSet<int>();
        
        foreach (int num in l)
        {
            // If the negation of the current number exists in our seen set,
            // we have found two distinct indices i and j such that l[i] + l[j] == 0.
            if (seen.Contains(-num))
            {
                return true;
            }
            seen.Add(num);
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_13.Claude
{
using System.Collections.Generic;

public class Solver
{
    public static bool PairsSumToZero(List<int> l)
    {
        var seen = new HashSet<int>();
        foreach (var n in l)
        {
            if (seen.Contains(-n)) return true;
            seen.Add(n);
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_13.Grok
{
using System.Collections.Generic;

public class Solver
{
    public static bool PairsSumToZero(List<int> l)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in l)
        {
            long complement = -(long)num;
            if (complement >= int.MinValue && complement <= int.MaxValue && seen.Contains((int)complement))
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_13.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool PairsSumToZero(List<int> l)
    {
        var seen = new HashSet<int>();
        foreach (var num in l)
        {
            if (seen.Contains(-num))
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_13.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool PairsSumToZero(List<int> l)
    {
        HashSet<int> seen = new HashSet<int>();
        
        foreach (int num in l)
        {
            if (seen.Contains(-num))
            {
                return true;
            }
            seen.Add(num);
        }
        
        return false;
    }
}
}

namespace Benchmarks.csharp_13.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static bool PairsSumToZero(List<int> l) 
    {
        var numSet = new HashSet<int>();
        foreach (var num in l) 
        {
            if (numSet.Contains(-num)) 
            {
                return true;
            }
            numSet.Add(num);
        }
        return false;
    }
}
}
