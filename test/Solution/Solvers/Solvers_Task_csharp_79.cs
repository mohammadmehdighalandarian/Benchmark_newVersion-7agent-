// Auto-generated Solvers for Task: csharp_79
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_79.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GenerateIntegers(int a, int b)
    {
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);

        List<int> result = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                result.Add(i);
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_79.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Given two positive integers a and b, return the even digits between a
    /// and b, in ascending order.
    /// </summary>
    public static List<int> GenerateIntegers(int a, int b)
    {
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);
        List<int> result = new List<int>();

        for (int i = start; i <= end; i++)
        {
            // Only consider single-digit even numbers (0, 2, 4, 6, 8)
            if (i >= 0 && i <= 9 && i % 2 == 0)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_79.Claude
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GenerateIntegers(int a, int b)
    {
        int lo = System.Math.Min(a, b), hi = System.Math.Max(a, b);
        return Enumerable.Range(lo, hi - lo + 1).Where(x => x <= 9 && x % 2 == 0).ToList();
    }
}
}

namespace Benchmarks.csharp_79.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<int> GenerateIntegers(int a, int b)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        List<int> result = new List<int>();
        for (int i = 0; i < 10; i += 2)
        {
            if (i >= min && i <= max)
            {
                result.Add(i);
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_79.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GenerateIntegers(int a, int b)
    {
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);
        return Enumerable.Range(start, end - start + 1)
                         .Where(x => x >= 1 && x <= 9 && x % 2 == 0)
                         .OrderBy(x => x)
                         .ToList();
    }
}
}

namespace Benchmarks.csharp_79.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GenerateIntegers(int a, int b)
    {
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);
        
        List<int> result = new List<int>();
        
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                result.Add(i);
            }
        }
        
        return result;
    }
}
}

namespace Benchmarks.csharp_79.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> GenerateIntegers(int a, int b) 
    {
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);
        return Enumerable.Range(start, end - start + 1).Where(x => x % 2 == 0).ToList();
    }
}
}
