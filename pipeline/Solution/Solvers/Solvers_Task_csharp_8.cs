// Auto-generated Solvers for Task: csharp_8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_8.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GetPositive(List<int> l)
    {
        return l.Where(x => x > 0).ToList();
    }
}
}

namespace Benchmarks.csharp_8.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Return only positive numbers in the list.
    /// >>> GetPositive([-1, 2, -4, 5, 6])
    /// [2, 5, 6]
    /// >>> GetPositive([5, 3, -5, 2, -3, 3, 9, 0, 123, 1, -10])
    /// [5, 3, 2, 3, 9, 123, 1]
    /// </summary>
    public static List<int> GetPositive(List<int> l)
    {
        return l.Where(x => x > 0).ToList();
    }
}
}

namespace Benchmarks.csharp_8.Claude
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GetPositive(List<int> l) => l.Where(x => x > 0).ToList();
}
}

namespace Benchmarks.csharp_8.Grok
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GetPositive(List<int> l)
    {
        return l.Where(x => x > 0).ToList();
    }
}
}

namespace Benchmarks.csharp_8.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GetPositive(List<int> l)
    {
        return l.Where(num => num > 0).ToList();
    }
}
}

namespace Benchmarks.csharp_8.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> GetPositive(List<int> l)
    {
        return l.Where(x => x > 0).ToList();
    }
}
}

namespace Benchmarks.csharp_8.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> GetPositive(List<int> l) 
    {
        return l.Where(x => x > 0).ToList();
    }
}
}
