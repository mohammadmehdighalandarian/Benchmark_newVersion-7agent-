// Auto-generated Solvers for Task: csharp_22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_22.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static List<int> Common(List<int> l1, List<int> l2)
    {
        return l1.Intersect(l2).Distinct().OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_22.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Return sorted unique common elements for two lists.
    /// </summary>
    public static List<int> Common(List<int> l1, List<int> l2)
    {
        if (l1 == null || l2 == null)
        {
            return new List<int>();
        }

        return l1.Intersect(l2).OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_22.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Common(List<int> l1, List<int> l2)
    {
        return l1.Intersect(l2).OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_22.Grok
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Common(List<int> l1, List<int> l2)
    {
        return l1.Intersect(l2).OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_22.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Common(List<int> l1, List<int> l2)
    {
        return l1.Intersect(l2).OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_22.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> Common(List<int> l1, List<int> l2)
    {
        return l1.Intersect(l2).OrderBy(x => x).ToList();
    }
}
}

namespace Benchmarks.csharp_22.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> Common(List<int> l1, List<int> l2) 
    {
        return l1.Intersect(l2).OrderBy(x => x).ToList();
    }
}
}
