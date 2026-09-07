// Auto-generated Solvers for Task: csharp_54
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_54.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Maximum(List<int> arr, int k)
    {
        if (k == 0) return new List<int>();

        return arr
            .OrderByDescending(x => x)
            .Take(k)
            .OrderBy(x => x)
            .ToList();
    }
}
}

namespace Benchmarks.csharp_54.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary>
    /// Given an array arr of integers and a positive integer k, return a sorted list 
    /// of length k with the Maximum k numbers in arr.
    /// </summary>
    public static List<int> Maximum(List<int> arr, int k)
    {
        if (arr == null || k <= 0)
        {
            return new List<int>();
        }

        // To get the k maximum numbers in a sorted list:
        // 1. Sort the entire array in ascending order.
        // 2. Skip the first (N - k) elements to keep only the largest k elements.
        // This naturally results in a sorted list of the k maximum values.
        return arr.OrderBy(x => x)
                  .Skip(Math.Max(0, arr.Count - k))
                  .ToList();
    }
}
}

namespace Benchmarks.csharp_54.Claude
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Maximum(List<int> arr, int k)
    {
        return arr.OrderBy(x => x).TakeLast(k).ToList();
    }
}
}

namespace Benchmarks.csharp_54.Grok
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Maximum(List<int> arr, int k)
    {
        return arr.OrderBy(x => x).Skip(arr.Count - k).ToList();
    }
}
}

namespace Benchmarks.csharp_54.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Maximum(List<int> arr, int k)
    {
        return arr.OrderByDescending(x => x).Take(k).OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_54.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Maximum(List<int> arr, int k)
    {
        if (k <= 0) return new List<int>();
        
        return arr.OrderByDescending(x => x).Take(k).OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_54.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> Maximum(List<int> arr, int k) 
    {
        return arr.OrderByDescending(x => x).Take(k).OrderBy(x => x).ToList();
    }
}
}
