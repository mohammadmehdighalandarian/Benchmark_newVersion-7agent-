// Auto-generated Solvers for Task: csharp_45
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_45.GPT
{
using System;

public class Solver
{
    public static int ChooseNum(int x, int y)
    {
        int l = Math.Min(x, y);
        int r = Math.Max(x, y);

        int candidate = (r % 2 == 0) ? r : r - 1;

        if (candidate >= l)
            return candidate;

        return -1;
    }
}
}

namespace Benchmarks.csharp_45.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// This function takes two positive numbers x and y and returns the
    /// biggest even integer number that is in the range [x, y] inclusive. If 
    /// there's no such number, then the function should return -1.
    /// </summary>
    public static int ChooseNum(int x, int y)
    {
        if (x > y)
        {
            return -1;
        }

        if (y % 2 == 0)
        {
            return y;
        }

        if (y - 1 >= x)
        {
            return y - 1;
        }

        return -1;
    }
}
}

namespace Benchmarks.csharp_45.Claude
{
using System;

public class Solver
{
    public static int ChooseNum(int x, int y)
    {
        if (y < x) return -1;
        return y % 2 == 0 ? y : (y - 1 >= x ? y - 1 : -1);
    }
}
}

namespace Benchmarks.csharp_45.Grok
{
public class Solver
{
    public static int ChooseNum(int x, int y)
    {
        if (x > y) return -1;
        int maxEven = y - (y % 2);
        if (maxEven >= x) return maxEven;
        return -1;
    }
}
}

namespace Benchmarks.csharp_45.Mistral
{
using System;

public class Solver
{
    public static int ChooseNum(int x, int y)
    {
        int start = Math.Min(x, y);
        int end = Math.Max(x, y);

        for (int i = end; i >= start; i--)
        {
            if (i % 2 == 0)
            {
                return i;
            }
        }

        return -1;
    }
}
}

namespace Benchmarks.csharp_45.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int ChooseNum(int x, int y)
    {
        if (x > y)
        {
            return -1;
        }
        
        int biggestEven = y % 2 == 0 ? y : y - 1;
        
        if (biggestEven >= x)
        {
            return biggestEven;
        }
        
        return -1;
    }
}
}

namespace Benchmarks.csharp_45.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static int ChooseNum(int x, int y) 
    {
        if (x > y) return -1;
        int max = Math.Max(x, y);
        int min = Math.Min(x, y);
        int biggestEven = max - (max % 2);
        return biggestEven >= min ? biggestEven : -1;
    }
}
}
