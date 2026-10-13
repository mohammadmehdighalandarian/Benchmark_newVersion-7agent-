// Auto-generated Solvers for Task: csharp_12
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_12.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static bool TriplesSumToZero(List<int> l)
    {
        int n = l.Count;
        if (n < 3) return false;

        l.Sort();

        for (int i = 0; i < n - 2; i++)
        {
            int left = i + 1;
            int right = n - 1;

            while (left < right)
            {
                int sum = l[i] + l[left] + l[right];

                if (sum == 0)
                    return true;
                if (sum < 0)
                    left++;
                else
                    right--;
            }
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_12.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// TriplesSumToZero takes a list of integers as an input.
    /// It returns True if there are three distinct elements in the list that
    /// sum to zero, and False otherwise.
    /// </summary>
    public static bool TriplesSumToZero(List<int> l)
    {
        if (l == null || l.Count < 3)
        {
            return false;
        }

        // Sorting the list allows us to use the two-pointer approach
        // which reduces the complexity from O(n^3) to O(n^2).
        l.Sort();

        for (int i = 0; i < l.Count - 2; i++)
        {
            int left = i + 1;
            int right = l.Count - 1;

            while (left < right)
            {
                int currentSum = l[i] + l[left] + l[right];

                if (currentSum == 0)
                {
                    return true;
                }
                else if (currentSum < 0)
                {
                    // Sum is too small, move the left pointer forward
                    left++;
                }
                else
                {
                    // Sum is too large, move the right pointer backward
                    right--;
                }
            }
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_12.Claude
{
using System.Collections.Generic;

public class Solver
{
    public static bool TriplesSumToZero(List<int> l)
    {
        for (int i = 0; i < l.Count - 2; i++)
            for (int j = i + 1; j < l.Count - 1; j++)
                for (int k = j + 1; k < l.Count; k++)
                    if (l[i] + l[j] + l[k] == 0) return true;
        return false;
    }
}
}

namespace Benchmarks.csharp_12.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static bool TriplesSumToZero(List<int> l)
    {
        if (l.Count < 3) return false;
        
        int[] arr = l.ToArray();
        Array.Sort(arr);
        
        for (int i = 0; i < arr.Length - 2; i++)
        {
            int left = i + 1;
            int right = arr.Length - 1;
            
            while (left < right)
            {
                int sum = arr[i] + arr[left] + arr[right];
                
                if (sum == 0) return true;
                else if (sum < 0) left++;
                else right--;
            }
        }
        
        return false;
    }
}
}

namespace Benchmarks.csharp_12.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool TriplesSumToZero(List<int> l)
    {
        if (l.Count < 3) return false;

        for (int i = 0; i < l.Count - 2; i++)
        {
            for (int j = i + 1; j < l.Count - 1; j++)
            {
                for (int k = j + 1; k < l.Count; k++)
                {
                    if (l[i] + l[j] + l[k] == 0)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_12.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool TriplesSumToZero(List<int> l)
    {
        if (l == null || l.Count < 3)
            return false;
        
        l.Sort();
        int n = l.Count;
        
        for (int i = 0; i < n - 2; i++)
        {
            if (i > 0 && l[i] == l[i - 1])
                continue;
                
            int left = i + 1;
            int right = n - 1;
            
            while (left < right)
            {
                int sum = l[i] + l[left] + l[right];
                
                if (sum == 0)
                    return true;
                else if (sum < 0)
                    left++;
                else
                    right--;
            }
        }
        
        return false;
    }
}
}

namespace Benchmarks.csharp_12.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static bool TriplesSumToZero(List<int> l) 
    {
        if (l.Count < 3) return false;
        l.Sort();
        for (int i = 0; i < l.Count - 2; i++) 
        {
            if (i > 0 && l[i] == l[i - 1]) continue;
            int left = i + 1, right = l.Count - 1;
            while (left < right) 
            {
                int sum = l[i] + l[left] + l[right];
                if (sum < 0) left++;
                else if (sum > 0) right--;
                else return true;
            }
        }
        return false;
    }
}
}
