// Auto-generated Solvers for Task: csharp_72
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_72.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int DoubleTheDifference(List<object> lst)
    {
        if (lst == null || lst.Count == 0)
            return 0;

        int sum = 0;

        foreach (var item in lst)
        {
            if (item is int x)
            {
                if (x > 0 && x % 2 != 0)
                {
                    sum += x * x;
                }
            }
        }

        return sum;
    }
}
}

namespace Benchmarks.csharp_72.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Given a list of numbers, return the sum of squares of the numbers
    /// in the list that are odd. Ignore numbers that are negative or not integers.
    /// </summary>
    public static int DoubleTheDifference(List<object> lst)
    {
        if (lst == null || lst.Count == 0)
        {
            return 0;
        }

        int sum = 0;

        foreach (var item in lst)
        {
            // Check if the item is a numeric type that can represent an integer
            // and ensure it is actually an integer value (not 1.5, etc.)
            if (IsIntegerType(item))
            {
                int val = Convert.ToInt32(item);

                // Ignore negative numbers
                if (val >= 0)
                {
                    // Check if the number is odd
                    if (val % 2 != 0)
                    {
                        sum += val * val;
                    }
                }
            }
        }

        return sum;
    }

    private static bool IsIntegerType(object value)
    {
        if (value == null) return false;

        // Check if it's a standard integral type
        if (value is int || value is long || value is short || value is sbyte ||
            value is uint || value is ulong || value is ushort || value is byte)
        {
            return true;
        }

        // Check if it's a floating point type but contains an integer value
        if (value is double d)
        {
            return d >= 0 && d == Math.Floor(d) && !double.IsInfinity(d) && !double.IsNaN(d);
        }
        if (value is float f)
        {
            return f >= 0 && f == (float)Math.Floor(f) && !float.IsInfinity(f) && !float.IsNaN(f);
        }
        if (value is decimal dec)
        {
            return dec >= 0 && dec == Math.Floor(dec);
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_72.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int DoubleTheDifference(List<object> lst)
    {
        int sum = 0;
        foreach (var item in lst)
        {
            if (item is int i && i > 0 && i % 2 != 0) sum += i * i;
            else if (item is double d && d == Math.Floor(d) && d > 0 && (long)d % 2 != 0) sum += (int)(d * d);
        }
        return sum;
    }
}
}

namespace Benchmarks.csharp_72.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static int DoubleTheDifference(List<object> lst)
    {
        if (lst == null || lst.Count == 0)
            return 0;

        int sum = 0;
        foreach (var x in lst)
        {
            if (x is int i && i >= 0 && i % 2 != 0)
            {
                sum += i * i;
            }
        }
        return sum;
    }
}
}

namespace Benchmarks.csharp_72.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int DoubleTheDifference(List<object> lst)
    {
        return lst
            .Where(o => o is int i && i > 0 && i % 2 != 0)
            .Select(i => (int)i * (int)i)
            .Sum();
    }
}
}

namespace Benchmarks.csharp_72.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int DoubleTheDifference(List<object> lst)
    {
        if (lst == null || lst.Count == 0)
            return 0;
        
        int sum = 0;
        
        foreach (object item in lst)
        {
            if (item is int num && num > 0 && num % 2 != 0)
            {
                sum += num * num;
            }
        }
        
        return sum;
    }
}
}

namespace Benchmarks.csharp_72.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static int DoubleTheDifference(List<object> lst) 
    {
        return lst.Where(x => x is int && (int)x >= 0 && (int)x % 2 != 0).Select(x => (int)x * (int)x).Sum();
    }
}
}
