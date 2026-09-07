// Auto-generated Solvers for Task: csharp_10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_10.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Unique(List<int> l)
    {
        return l.Distinct().OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_10.Gemini
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Return sorted Unique elements in a list
    /// >>> Unique([5, 3, 5, 2, 3, 3, 9, 0, 123])
    /// [0, 2, 3, 5, 9, 123]
    /// </summary>
    public static List<int> Unique(List<int> l)
    {
        return l.Distinct().OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_10.Claude
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Unique(List<int> l) => l.Distinct().OrderBy(x => x).ToList();
}
}

namespace Benchmarks.csharp_10.Grok
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Unique(List<int> l)
    {
        return l.Distinct().OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_10.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Unique(List<int> l)
    {
        return l.Distinct().OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_10.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Unique(List<int> l)
    {
        if (l == null)
            return new List<int>();
        
        return l.Distinct().OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_10.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> Unique(List<int> l) 
    {
        return l.Distinct().OrderBy(x => x).ToList();
    }
}
}
