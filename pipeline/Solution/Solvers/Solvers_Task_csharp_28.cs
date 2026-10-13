// Auto-generated Solvers for Task: csharp_28
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_28.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Search(List<int> lst)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in lst)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        int result = -1;

        foreach (var kv in freq)
        {
            int value = kv.Key;
            int count = kv.Value;

            if (value > 0 && count >= value)
            {
                result = Math.Max(result, value);
            }
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_28.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Returns the greatest integer that is greater than zero, 
    /// and has a frequency greater than or equal to the value of the integer itself.
    /// If no such value exists, returns -1.
    /// </summary>
    public static int Search(List<int> lst)
    {
        var eligible = lst.GroupBy(x => x)
                          .Where(g => g.Count() >= g.Key)
                          .Select(g => g.Key);

        return eligible.Any() ? eligible.Max() : -1;
    }
}
}

namespace Benchmarks.csharp_28.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Search(List<int> lst)
    {
        var freq = lst.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        return freq.Where(kv => kv.Value >= kv.Key).Select(kv => kv.Key).DefaultIfEmpty(-1).Max();
    }
}
}

namespace Benchmarks.csharp_28.Grok
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Search(List<int> lst)
    {
        var freq = lst.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        var qualifying = freq.Where(p => p.Value >= p.Key).Select(p => p.Key);
        return qualifying.Any() ? qualifying.Max() : -1;
    }
}
}

namespace Benchmarks.csharp_28.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Search(List<int> lst)
    {
        var frequencyMap = lst.GroupBy(x => x)
                              .ToDictionary(g => g.Key, g => g.Count());

        int result = -1;
        foreach (var kvp in frequencyMap)
        {
            if (kvp.Key > 0 && kvp.Value >= kvp.Key)
            {
                if (kvp.Key > result)
                {
                    result = kvp.Key;
                }
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_28.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Search(List<int> lst)
    {
        var frequency = new Dictionary<int, int>();
        
        foreach (int num in lst)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        
        int result = -1;
        
        foreach (var kvp in frequency)
        {
            if (kvp.Key > 0 && kvp.Value >= kvp.Key)
            {
                if (kvp.Key > result)
                    result = kvp.Key;
            }
        }
        
        return result;
    }
}
}

namespace Benchmarks.csharp_28.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static int Search(List<int> lst) 
    {
        var freq = lst.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        int max = -1;
        foreach (var pair in freq)
        {
            if (pair.Key <= pair.Value && pair.Key > max)
                max = pair.Key;
        }
        return max;
    }
}
}
