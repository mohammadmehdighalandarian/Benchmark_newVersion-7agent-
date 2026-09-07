// Auto-generated Solvers for Task: csharp_6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_6.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<double> RescaleToUnit(List<double> numbers)
    {
        double min = numbers.Min();
        double max = numbers.Max();
        double range = max - min;

        return numbers.Select(x => (x - min) / range).ToList();
    }
}
}

namespace Benchmarks.csharp_6.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<double> RescaleToUnit(List<double> numbers)
    {
        double min = numbers.Min();
        double max = numbers.Max();
        double range = max - min;

        return numbers.Select(x => (x - min) / range).ToList();
    }
}
}

namespace Benchmarks.csharp_6.Claude
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<double> RescaleToUnit(List<double> numbers)
    {
        double min = numbers.Min(), max = numbers.Max();
        return numbers.Select(x => (x - min) / (max - min)).ToList();
    }
}
}

namespace Benchmarks.csharp_6.Grok
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<double> RescaleToUnit (List<double> numbers) 
    {
        double min = numbers.Min();
        double max = numbers.Max();
        return numbers.Select(x => (x - min) / (max - min)).ToList();
    }
}
}

namespace Benchmarks.csharp_6.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<double> RescaleToUnit(List<double> numbers)
    {
        double min = numbers.Min();
        double max = numbers.Max();
        double range = max - min;

        return numbers.Select(num => (num - min) / range).ToList();
    }
}
}

namespace Benchmarks.csharp_6.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<double> RescaleToUnit(List<double> numbers)
    {
        if (numbers == null || numbers.Count < 2)
            throw new ArgumentException("List must contain at least two elements");
        
        double min = numbers.Min();
        double max = numbers.Max();
        double range = max - min;
        
        if (range == 0)
            return numbers.Select(x => 0.5).ToList();
        
        return numbers.Select(x => (x - min) / range).ToList();
    }
}
}

namespace Benchmarks.csharp_6.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<double> RescaleToUnit(List<double> numbers)
    {
        double min = numbers.Min();
        double max = numbers.Max();
        return numbers.Select(n => (n - min) / (max - min)).ToList();
    }
}
}
