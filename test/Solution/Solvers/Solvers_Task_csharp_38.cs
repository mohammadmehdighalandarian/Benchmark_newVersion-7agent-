// Auto-generated Solvers for Task: csharp_38
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_38.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object NextSmallest(List<int> lst)
    {
        if (lst == null || lst.Count == 0)
            return "None";

        var distinct = lst.Distinct().OrderBy(x => x).ToList();

        if (distinct.Count < 2)
            return "None";

        return distinct[1];
    }
}
}

namespace Benchmarks.csharp_38.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Returns the 2nd smallest element of the list.
    /// Returns null (None) if there is no such element.
    /// </summary>
    public static object NextSmallest(List<int> lst)
    {
        if (lst == null || lst.Count < 2)
        {
            return null;
        }

        // Get unique elements and sort them in ascending order
        var sortedDistinct = lst.Distinct().OrderBy(x => x).Take(2).ToList();

        // If there are fewer than 2 unique elements, the 2nd smallest doesn't exist
        if (sortedDistinct.Count < 2)
        {
            return null;
        }

        // Return the second element in the sorted unique list
        return sortedDistinct[1];
    }
}
}

namespace Benchmarks.csharp_38.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object NextSmallest(List<int> lst)
    {
        var distinct = lst.Distinct().OrderBy(x => x).ToList();
        return distinct.Count >= 2 ? (object)distinct[1] : null;
    }
}
}

namespace Benchmarks.csharp_38.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static object NextSmallest(List<int> lst)
    {
        if (lst == null || lst.Count == 0)
            return null;

        int minVal = lst[0];
        for (int i = 1; i < lst.Count; i++)
        {
            if (lst[i] < minVal)
                minVal = lst[i];
        }

        int? second = null;
        for (int i = 0; i < lst.Count; i++)
        {
            if (lst[i] > minVal && (second == null || lst[i] < second))
                second = lst[i];
        }

        return second;
    }
}
}

namespace Benchmarks.csharp_38.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object NextSmallest(List<int> lst)
    {
        if (lst == null || lst.Count < 2)
        {
            return null;
        }

        var uniqueSorted = lst.Distinct().OrderBy(x => x).ToList();
        return uniqueSorted.Count >= 2 ? uniqueSorted[1] : null;
    }
}
}

namespace Benchmarks.csharp_38.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object NextSmallest(List<int> lst)
    {
        if (lst == null || lst.Count < 2)
        {
            return null;
        }
        
        var distinctSorted = lst.Distinct().OrderBy(x => x).ToList();
        
        if (distinctSorted.Count < 2)
        {
            return null;
        }
        
        return distinctSorted[1];
    }
}
}

namespace Benchmarks.csharp_38.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static object NextSmallest(List<int> lst)
    {
        var distinctElements = lst.Distinct().OrderBy(x => x).ToList();
        return distinctElements.Count >= 2 ? (object)distinctElements[1] : null;
    }
}
}
