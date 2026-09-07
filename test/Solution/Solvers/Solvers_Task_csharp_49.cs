// Auto-generated Solvers for Task: csharp_49
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_49.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool MoveOneBall(List<int> arr)
    {
        int n = arr.Count;
        if (n == 0) return true;

        int breaks = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > arr[(i + 1) % n])
                breaks++;
        }

        return breaks <= 1;
    }
}
}

namespace Benchmarks.csharp_49.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Determines if it is possible to get an array sorted in non-decreasing order 
    /// by performing right shift operations.
    /// </summary>
    public static bool MoveOneBall(List<int> arr)
    {
        // If the array is empty or has only one element, it is considered sorted.
        if (arr == null || arr.Count <= 1)
        {
            return true;
        }

        int n = arr.Count;
        int decreaseCount = 0;

        // A cyclically sorted array with unique elements can have at most one 
        // point where the current element is greater than the next element 
        // (including the wrap-around from the last element to the first).
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > arr[(i + 1) % n])
            {
                decreaseCount++;
            }
        }

        // If there is more than one decrease point, it cannot be sorted by shifts.
        return decreaseCount <= 1;
    }
}
}

namespace Benchmarks.csharp_49.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool MoveOneBall(List<int> arr)
    {
        if (arr.Count == 0) return true;
        int drops = 0;
        for (int i = 0; i < arr.Count; i++)
            if (arr[i] > arr[(i + 1) % arr.Count]) drops++;
        return drops <= 1;
    }
}
}

namespace Benchmarks.csharp_49.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static bool MoveOneBall(List<int> arr)
    {
        List<int> sorted = new List<int>(arr);
        sorted.Sort();
        string original = string.Join(",", arr);
        string target = string.Join(",", sorted);
        return (original + "," + original).Contains(target);
    }
}
}

namespace Benchmarks.csharp_49.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool MoveOneBall(List<int> arr)
    {
        if (arr.Count == 0)
            return true;

        int n = arr.Count;
        int pivot = -1;

        // Find the pivot where the order breaks
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                pivot = i + 1;
                break;
            }
        }

        // If no pivot found, the array is already sorted
        if (pivot == -1)
            return true;

        // Check if the array can be sorted by right shifts
        // The array should be sorted after the pivot and the last element should be <= first element
        for (int i = pivot; i < n - 1; i++)
        {
            if (arr[i] > arr[i + 1])
                return false;
        }

        return arr.Last() <= arr.First();
    }
}
}

namespace Benchmarks.csharp_49.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool MoveOneBall(List<int> arr)
    {
        if (arr == null || arr.Count == 0)
            return true;
        
        int n = arr.Count;
        int dropCount = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > arr[(i + 1) % n])
                dropCount++;
        }
        
        return dropCount <= 1;
    }
}
}

namespace Benchmarks.csharp_49.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool MoveOneBall(List<int> arr)
    {
        if (arr.Count == 0) return true;
        var sortedArr = arr.OrderBy(x => x).ToList();
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr.SequenceEqual(sortedArr)) return true;
            arr.Insert(0, arr[arr.Count - 1]);
            arr.RemoveAt(arr.Count - 1);
        }
        return false;
    }
}
}
