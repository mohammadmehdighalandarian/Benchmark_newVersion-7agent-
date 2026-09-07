// Auto-generated Solvers for Task: csharp_63
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_63.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> LargestSmallestIntegers(List<int> lst)
    {
        int? largestNegative = null;
        int? smallestPositive = null;

        foreach (var x in lst)
        {
            if (x < 0)
            {
                if (largestNegative == null || x > largestNegative)
                    largestNegative = x;
            }
            else if (x > 0)
            {
                if (smallestPositive == null || x < smallestPositive)
                    smallestPositive = x;
            }
        }

        return new List<object>
        {
            largestNegative.HasValue ? (object)largestNegative.Value : null,
            smallestPositive.HasValue ? (object)smallestPositive.Value : null
        };
    }
}
}

namespace Benchmarks.csharp_63.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Returns a list containing the largest of negative integers and the smallest of positive integers.
    /// If there is no negative or positive integers, returns null for that position.
    /// </summary>
    public static List<object> LargestSmallestIntegers(List<int> lst)
    {
        // Find the largest negative integer (x < 0)
        // Using Cast<int?>() allows Max() to return null instead of throwing an exception on an empty sequence
        int? largestNegative = lst.Where(x => x < 0).Cast<int?>().Max();

        // Find the smallest positive integer (x > 0)
        int? smallestPositive = lst.Where(x => x > 0).Cast<int?>().Min();

        // Return as a list of objects to accommodate both integers and null values
        return new List<object> { largestNegative, smallestPositive };
    }
}
}

namespace Benchmarks.csharp_63.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> LargestSmallestIntegers(List<int> lst)
    {
        var negatives = lst.Where(x => x < 0).ToList();
        var positives = lst.Where(x => x > 0).ToList();
        object a = negatives.Any() ? (object)negatives.Max() : null;
        object b = positives.Any() ? (object)positives.Min() : null;
        return new List<object> { a, b };
    }
}
}

namespace Benchmarks.csharp_63.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> LargestSmallestIntegers(List<int> lst)
    {
        var negatives = lst.Where(x => x < 0);
        object a = negatives.Any() ? (object)negatives.Max() : null;

        var positives = lst.Where(x => x > 0);
        object b = positives.Any() ? (object)positives.Min() : null;

        return new List<object> { a, b };
    }
}
}

namespace Benchmarks.csharp_63.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> LargestSmallestIntegers(List<int> lst)
    {
        int? largestNegative = lst.Where(x => x < 0).DefaultIfEmpty().Max();
        int? smallestPositive = lst.Where(x => x > 0).DefaultIfEmpty().Min();

        return new List<object> { largestNegative, smallestPositive };
    }
}
}

namespace Benchmarks.csharp_63.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<object> LargestSmallestIntegers(List<int> lst)
    {
        object a = null;
        object b = null;
        
        var negatives = lst.Where(x => x < 0).ToList();
        var positives = lst.Where(x => x > 0).ToList();
        
        if (negatives.Any())
        {
            a = negatives.Max();
        }
        
        if (positives.Any())
        {
            b = positives.Min();
        }
        
        return new List<object> { a, b };
    }
}
}

namespace Benchmarks.csharp_63.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<object> LargestSmallestIntegers(List<int> lst) 
    {
        var negatives = lst.Where(x => x < 0).ToList();
        var positives = lst.Where(x => x > 0).ToList();

        object largestNegative = negatives.Any() ? (object)negatives.Max() : null;
        object smallestPositive = positives.Any() ? (object)positives.Min() : null;

        return new List<object> { largestNegative, smallestPositive };
    }
}
}
