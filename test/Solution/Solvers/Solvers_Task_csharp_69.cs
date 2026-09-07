// Auto-generated Solvers for Task: csharp_69
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_69.GPT
{
using System;

public class Solver
{
    public static int GetMaxTriples(int n)
    {
        int q = n / 3;
        int r = n % 3;

        long cnt0 = q + (r == 2 ? 1 : 0);
        long cnt1 = n - cnt0;

        long c0 = (cnt0 >= 3) ? cnt0 * (cnt0 - 1) * (cnt0 - 2) / 6 : 0;
        long c1 = (cnt1 >= 3) ? cnt1 * (cnt1 - 1) * (cnt1 - 2) / 6 : 0;

        return (int)(c0 + c1);
    }
}
}

namespace Benchmarks.csharp_69.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// You are given a positive integer n. You have to create an integer array a of length n.
    /// For each i (1 ≤ i ≤ n), the value of a[i] = i * i - i + 1.
    /// Return the number of triples (a[i], a[j], a[k]) of a where i < j < k, 
    /// and a[i] + a[j] + a[k] is a multiple of 3.
    /// </summary>
    public static int GetMaxTriples(int n)
    {
        // Instead of building the full array, we only care about the remainders modulo 3.
        // a[i] = i^2 - i + 1
        // We need (a[i] + a[j] + a[k]) % 3 == 0
        
        long count0 = 0;
        long count1 = 0;
        long count2 = 0;

        for (int i = 1; i <= n; i++)
        {
            // Use long to prevent overflow during calculation, though i is small.
            long val = (long)i * i - i + 1;
            long remainder = val % 3;

            if (remainder == 0) count0++;
            else if (remainder == 1) count1++;
            else count2++;
        }

        // To make the sum a multiple of 3, the remainders must be:
        // 1. All three are the same (0+0+0, 1+1+1, 2+2+2)
        // 2. All three are different (0+1+2)

        long triples = 0;

        // Case 1: All same
        triples += (count0 * (count0 - 1) * (count0 - 2)) / 6;
        triples += (count1 * (count1 - 1) * (count1 - 2)) / 6;
        triples += (count2 * (count2 - 1) * (count2 - 2)) / 6;

        // Case 2: All different
        triples += count0 * count1 * count2;

        return (int)triples;
    }
}
}

namespace Benchmarks.csharp_69.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int GetMaxTriples(int n)
    {
        var a = Enumerable.Range(1, n).Select(i => i * i - i + 1).ToArray();
        int count = 0;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                for (int k = j + 1; k < n; k++)
                    if ((a[i] + a[j] + a[k]) % 3 == 0) count++;
        return count;
    }
}
}

namespace Benchmarks.csharp_69.Grok
{
public class Solver
{
    public static int GetMaxTriples(int n)
    {
        int q = n / 3;
        int r = n % 3;
        int count0 = q + (r == 2 ? 1 : 0);
        int count1 = n - count0;
        long res = 0;
        if (count0 >= 3)
        {
            res += (long)count0 * (count0 - 1) * (count0 - 2) / 6;
        }
        if (count1 >= 3)
        {
            res += (long)count1 * (count1 - 1) * (count1 - 2) / 6;
        }
        return (int)res;
    }
}
}

namespace Benchmarks.csharp_69.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int GetMaxTriples(int n)
    {
        int[] a = new int[n];
        for (int i = 1; i <= n; i++)
        {
            a[i - 1] = i * i - i + 1;
        }

        int[] modCounts = new int[3];
        foreach (int num in a)
        {
            modCounts[num % 3]++;
        }

        int result = 0;
        result += modCounts[0] * (modCounts[0] - 1) * (modCounts[0] - 2) / 6;
        result += modCounts[1] * (modCounts[1] - 1) * (modCounts[1] - 2) / 6;
        result += modCounts[2] * (modCounts[2] - 1) * (modCounts[2] - 2) / 6;
        result += modCounts[0] * modCounts[1] * modCounts[2];

        return result;
    }
}
}

namespace Benchmarks.csharp_69.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int GetMaxTriples(int n)
    {
        if (n < 3) return 0;
        
        // Count numbers with remainder 0, 1, 2 when divided by 3
        int[] remainderCount = new int[3];
        
        for (int i = 1; i <= n; i++)
        {
            long value = (long)i * i - i + 1;
            int remainder = (int)(value % 3);
            remainderCount[remainder]++;
        }
        
        int result = 0;
        
        // All three numbers have remainder 0
        if (remainderCount[0] >= 3)
        {
            result += remainderCount[0] * (remainderCount[0] - 1) * (remainderCount[0] - 2) / 6;
        }
        
        // All three numbers have remainder 1
        if (remainderCount[1] >= 3)
        {
            result += remainderCount[1] * (remainderCount[1] - 1) * (remainderCount[1] - 2) / 6;
        }
        
        // All three numbers have remainder 2
        if (remainderCount[2] >= 3)
        {
            result += remainderCount[2] * (remainderCount[2] - 1) * (remainderCount[2] - 2) / 6;
        }
        
        // One from each remainder (0, 1, 2)
        result += remainderCount[0] * remainderCount[1] * remainderCount[2];
        
        return result;
    }
}
}

namespace Benchmarks.csharp_69.Llama
{
using System;

public class Solver 
{
    public static int GetMaxTriples(int n) 
    {
        int count1 = 0, count2 = 0, count0 = 0;
        for (int i = 1; i <= n; i++) 
        {
            int remainder = (i * i - i + 1) % 3;
            if (remainder == 1) count1++;
            else if (remainder == 2) count2++;
            else count0++;
        }
        return count1 * count2 * count0 + (count0 * (count0 - 1) * (count0 - 2)) / 6 + (count1 * (count1 - 1) * (count1 - 2)) / 6 + (count2 * (count2 - 1) * (count2 - 2)) / 6;
    }
}
}
