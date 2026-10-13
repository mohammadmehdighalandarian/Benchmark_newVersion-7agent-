// Auto-generated Solvers for Task: csharp_15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_15.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object Median(List<int> l)
    {
        var sorted = l.OrderBy(x => x).ToList();
        int n = sorted.Count;

        if (n % 2 == 1)
            return sorted[n / 2];

        return (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
    }
}
}

namespace Benchmarks.csharp_15.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Return Median of elements in the list l.
    /// </summary>
    public static object Median(List<int> l)
    {
        if (l == null || l.Count == 0)
        {
            return null;
        }

        // Sort the list to find the middle elements
        var sorted = l.OrderBy(x => x).ToList();
        int count = sorted.Count;

        if (count % 2 != 0)
        {
            // For odd number of elements, return the middle one
            return sorted[count / 2];
        }
        else
        {
            // For even number of elements, return the average of the two middle elements
            // Note: Returning as double to handle cases like (6 + 10) / 2.0 = 8.0
            double leftMid = sorted[count / 2 - 1];
            double rightMid = sorted[count / 2];
            return (leftMid + rightMid) / 2.0;
        }
    }
}
}

namespace Benchmarks.csharp_15.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object Median(List<int> l)
    {
        var sorted = l.OrderBy(x => x).ToList();
        int n = sorted.Count;
        if (n % 2 == 1) return sorted[n / 2];
        return (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
    }
}
}

namespace Benchmarks.csharp_15.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static object Median(List<int> l)
    {
        l.Sort();
        int n = l.Count;
        if (n % 2 == 1)
        {
            return l[n / 2];
        }
        else
        {
            int a = l[n / 2];
            int b = l[n / 2 + 1];
            return a / 2.0 + b / 2.0;
        }
    }
}
}

namespace Benchmarks.csharp_15.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object Median(List<int> l)
    {
        var sortedList = l.OrderBy(x => x).ToList();
        int count = sortedList.Count;
        int midIndex = count / 2;

        if (count % 2 == 1)
        {
            return sortedList[midIndex];
        }
        else
        {
            return (sortedList[midIndex - 1] + sortedList[midIndex]) / 2.0;
        }
    }
}
}

namespace Benchmarks.csharp_15.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object Median(List<int> l)
    {
        if (l == null || l.Count == 0)
            throw new ArgumentException("List cannot be null or empty");
        
        var sorted = l.OrderBy(x => x).ToList();
        int count = sorted.Count;
        
        if (count % 2 == 1)
        {
            return sorted[count / 2];
        }
        else
        {
            return (sorted[count / 2 - 1] + sorted[count / 2]) / 2.0;
        }
    }
}
}

namespace Benchmarks.csharp_15.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static object Median(List<int> l) 
    {
        var sortedList = l.OrderBy(x => x).ToList();
        int count = sortedList.Count;
        if (count % 2 == 0) 
        {
            return (sortedList[count / 2 - 1] + sortedList[count / 2]) / 2.0;
        } 
        else 
        {
            return sortedList[count / 2];
        }
    }
}
}
