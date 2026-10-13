// Auto-generated Solvers for Task: csharp_67
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_67.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> OrderByPoints(List<int> nums)
    {
        if (nums == null || nums.Count == 0)
            return new List<int>();

        int DigitSum(int x)
        {
            x = Math.Abs(x);
            int sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }

        return nums
            .Select((value, index) => new { value, index, sum = DigitSum(value) })
            .OrderBy(x => x.sum)
            .ThenBy(x => x.index)
            .Select(x => x.value)
            .ToList();
    }
}
}

namespace Benchmarks.csharp_67.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Sorts the given list of integers in ascending order according to the sum of their digits.
    /// If the number is negative, the first digit is treated as negative.
    /// If there are several items with the same sum, their relative order from the original list is preserved.
    /// </summary>
    public static List<int> OrderByPoints(List<int> nums)
    {
        if (nums == null || nums.Count == 0)
        {
            return new List<int>();
        }

        // Enumerable.OrderBy is a stable sort in .NET, satisfying the requirement 
        // to maintain original order for items with similar digit sums.
        return nums.OrderBy(GetWeight).ToList();
    }

    /// <summary>
    /// Calculates the weight (sum of digits) of an integer based on the specific rules:
    /// For positive numbers, sum all digits.
    /// For negative numbers, the first digit is negative and others are positive.
    /// </summary>
    private static int GetWeight(int n)
    {
        string s = n.ToString();
        int sum = 0;

        if (n < 0)
        {
            // For negative numbers, skip the '-' sign at index 0.
            // The first digit (index 1) is subtracted, subsequent digits are added.
            for (int i = 1; i < s.Length; i++)
            {
                int digit = s[i] - '0';
                if (i == 1)
                {
                    sum -= digit;
                }
                else
                {
                    sum += digit;
                }
            }
        }
        else
        {
            // For non-negative numbers, simply sum all digits.
            for (int i = 0; i < s.Length; i++)
            {
                sum += (s[i] - '0');
            }
        }

        return sum;
    }
}
}

namespace Benchmarks.csharp_67.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> OrderByPoints(List<int> nums)
    {
        return nums.Select((n, i) => (n, i))
            .OrderBy(x => {
                var s = x.n.ToString();
                int sign = 1;
                if (s.StartsWith("-")) { sign = -1; s = s.Substring(1); }
                return sign * s[0] - '0' + s.Skip(1).Sum(c => c - '0');
            })
            .ThenBy(x => x.i)
            .Select(x => x.n)
            .ToList();
    }
}
}

namespace Benchmarks.csharp_67.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> OrderByPoints(List<int> nums)
    {
        if (nums == null || nums.Count == 0) return new List<int>();

        var indexed = nums.Select((num, index) => new { Num = num, Index = index, Sum = GetDigitSum(num) });
        var sorted = indexed.OrderBy(x => x.Sum).ThenBy(x => x.Index).Select(x => x.Num).ToList();
        return sorted;
    }

    private static int GetDigitSum(int n)
    {
        if (n == 0) return 0;
        int sign = Math.Sign(n);
        int sum = 0;
        n = Math.Abs(n);
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sign * sum;
    }
}
}

namespace Benchmarks.csharp_67.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> OrderByPoints(List<int> nums)
    {
        return nums
            .Select((num, index) => new { Number = num, Index = index, Sum = Math.Abs(num).ToString().Sum(c => c - '0') })
            .OrderBy(x => x.Sum)
            .ThenBy(x => x.Index)
            .Select(x => x.Number)
            .ToList();
    }
}
}

namespace Benchmarks.csharp_67.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> OrderByPoints(List<int> nums)
    {
        if (nums == null || nums.Count == 0)
            return new List<int>();
        
        var indexedNums = nums.Select((num, index) => new { Value = num, Index = index }).ToList();
        
        var sorted = indexedNums
            .OrderBy(x => DigitSum(x.Value))
            .ThenBy(x => x.Index)
            .Select(x => x.Value)
            .ToList();
        
        return sorted;
    }
    
    private static int DigitSum(int n)
    {
        n = Math.Abs(n);
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
}
}

namespace Benchmarks.csharp_67.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> OrderByPoints(List<int> nums) 
    {
        return nums.Select((num, index) => new { num, index })
                   .OrderBy(x => x.num.ToString().Select(c => Math.Abs(c - '0')).Sum())
                   .ThenBy(x => x.index)
                   .Select(x => x.num)
                   .ToList();
    }
}
}
