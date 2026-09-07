// Auto-generated Solvers for Task: csharp_59
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_59.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool IsNested(string string0)
    {
        int n = string0.Length;
        int[] suffixClose = new int[n + 1];

        for (int i = n - 1; i >= 0; i--)
        {
            suffixClose[i] = suffixClose[i + 1] + (string0[i] == ']' ? 1 : 0);
        }

        int prefixOpen = 0;

        for (int i = 0; i < n; i++)
        {
            if (string0[i] == '[')
            {
                if (prefixOpen >= 1 && suffixClose[i + 1] >= 2)
                    return true;

                prefixOpen++;
            }
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_59.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Determines if there is a valid subsequence of brackets where at least one bracket is nested.
    /// This is equivalent to checking if the string contains "[[]]" as a subsequence.
    /// </summary>
    public static bool IsNested(string string0)
    {
        if (string.IsNullOrEmpty(string0))
        {
            return false;
        }

        // The smallest valid nested bracket sequence is "[[]]".
        // If a valid subsequence has any nesting, it must contain "[[]]" as a subsequence.
        string target = "[[]]";
        int targetIndex = 0;

        foreach (char c in string0)
        {
            if (c == target[targetIndex])
            {
                targetIndex++;
                
                // If we've found all four characters in order, the condition is met.
                if (targetIndex == 4)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_59.Claude
{
using System;

public class Solver
{
    public static bool IsNested(string string0)
    {
        int depth = 0, maxDepth = 0;
        foreach (char c in string0)
        {
            if (c == '[') { depth++; if (depth > maxDepth) maxDepth = depth; }
            else { depth = Math.Max(0, depth - 1); }
        }
        return maxDepth >= 2;
    }
}
}

namespace Benchmarks.csharp_59.Grok
{
public class Solver
{
    public static bool IsNested(string string0)
    {
        int countOpen = 0;
        int posSecond = -1;
        for (int i = 0; i < string0.Length; i++)
        {
            if (string0[i] == '[')
            {
                countOpen++;
                if (countOpen == 2)
                {
                    posSecond = i;
                    break;
                }
            }
        }
        if (posSecond == -1)
        {
            return false;
        }
        int countCloseAfter = 0;
        for (int i = posSecond + 1; i < string0.Length; i++)
        {
            if (string0[i] == ']')
            {
                countCloseAfter++;
            }
        }
        return countCloseAfter >= 2;
    }
}
}

namespace Benchmarks.csharp_59.Mistral
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static bool IsNested(string s)
    {
        int depth = 0;
        bool hasNested = false;

        foreach (char c in s)
        {
            if (c == '[')
            {
                depth++;
                if (depth >= 2)
                {
                    hasNested = true;
                }
            }
            else if (c == ']')
            {
                if (depth > 0)
                {
                    depth--;
                }
            }
        }

        return hasNested;
    }
}
}

namespace Benchmarks.csharp_59.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool IsNested(string string0)
    {
        int depth = 0;
        bool hasNested = false;
        
        foreach (char c in string0)
        {
            if (c == '[')
            {
                depth++;
            }
            else if (c == ']')
            {
                if (depth > 0)
                {
                    depth--;
                    if (depth > 0)
                    {
                        hasNested = true;
                    }
                }
            }
        }
        
        return hasNested;
    }
}
}

namespace Benchmarks.csharp_59.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static bool IsNested(string string0) 
    {
        int count = 0;
        foreach (char c in string0) 
        {
            if (c == '[') 
            {
                count++;
            } 
            else if (c == ']') 
            {
                count--;
                if (count < 0) return false;
                if (count > 0) return true;
            }
        }
        return false;
    }
}
}
