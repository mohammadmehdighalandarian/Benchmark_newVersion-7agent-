// Auto-generated Solvers for Task: csharp_55
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_55.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static int AddElements(List<int> arr, int k)
    {
        int sum = 0;

        for (int i = 0; i < k; i++)
        {
            int val = arr[i];
            if (Math.Abs(val) <= 99)
                sum += val;
        }

        return sum;
    }
}
}

namespace Benchmarks.csharp_55.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Given a non-empty array of integers arr and an integer k, return
    /// the sum of the elements with at most two digits from the first k elements of arr.
    /// </summary>
    public static int AddElements(List<int> arr, int k)
    {
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            // A number has at most two digits if it is in the range [-99, 99]
            if (arr[i] > -100 && arr[i] < 100)
            {
                sum += arr[i];
            }
        }
        return sum;
    }
}
}

namespace Benchmarks.csharp_55.Claude
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int AddElements(List<int> arr, int k)
    {
        return arr.Take(k).Where(x => System.Math.Abs(x) <= 99).Sum();
    }
}
}

namespace Benchmarks.csharp_55.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int AddElements(List<int> arr, int k)
    {
        return arr.Take(k).Where(x => Math.Abs(x) <= 99).Sum();
    }
}
}

namespace Benchmarks.csharp_55.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int AddElements(List<int> arr, int k)
    {
        return arr.Take(k).Where(x => x >= -99 && x <= 99).Sum();
    }
}
}

namespace Benchmarks.csharp_55.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int AddElements(List<int> arr, int k)
    {
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            int num = arr[i];
            if (Math.Abs(num) < 100 && Math.Abs(num) > -100)
            {
                sum += num;
            }
        }
        return sum;
    }
}
}

namespace Benchmarks.csharp_55.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static int AddElements(List<int> arr, int k) 
    {
        return arr.Take(k).Where(x => Math.Abs(x) < 100).Sum();
    }
}
}
