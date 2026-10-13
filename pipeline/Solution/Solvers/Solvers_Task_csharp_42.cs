// Auto-generated Solvers for Task: csharp_42
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_42.GPT
{
using System;
using System.Globalization;

public class Solver
{
    public static int ClosestInteger(string value)
    {
        double x = double.Parse(value, CultureInfo.InvariantCulture);
        return (int)Math.Round(x, MidpointRounding.AwayFromZero);
    }
}
}

namespace Benchmarks.csharp_42.Gemini
{
using System;
using System.Globalization;

public class Solver
{
    public static int ClosestInteger(string value)
    {
        double parsedValue = double.Parse(value, CultureInfo.InvariantCulture);
        return (int)Math.Round(parsedValue, MidpointRounding.AwayFromZero);
    }
}
}

namespace Benchmarks.csharp_42.Claude
{
using System;

public class Solver
{
    public static int ClosestInteger(string value)
    {
        decimal d = decimal.Parse(value);
        return (int)Math.Round(d, MidpointRounding.AwayFromZero);
    }
}
}

namespace Benchmarks.csharp_42.Grok
{
using System;

public class Solver
{
    public static int ClosestInteger(string value)
    {
        double num = double.Parse(value);
        return (int)Math.Round(num, MidpointRounding.AwayFromZero);
    }
}
}

namespace Benchmarks.csharp_42.Mistral
{
using System;

public class Solver
{
    public static int ClosestInteger(string value)
    {
        double number = double.Parse(value);
        double floor = Math.Floor(number);
        double ceil = Math.Ceiling(number);

        if (number - floor == 0.5)
        {
            return (int)(number > 0 ? ceil : floor);
        }
        else if (ceil - number == 0.5)
        {
            return (int)(number > 0 ? ceil : floor);
        }
        else
        {
            return (int)Math.Round(number);
        }
    }
}
}

namespace Benchmarks.csharp_42.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int ClosestInteger(string value)
    {
        double number = double.Parse(value);
        
        if (Math.Abs(number - Math.Floor(number) - 0.5) < 1e-10 ||
            Math.Abs(number - Math.Ceiling(number) + 0.5) < 1e-10)
        {
            return (int)(number > 0 ? Math.Ceiling(number) : Math.Floor(number));
        }
        
        return (int)Math.Round(number, MidpointRounding.AwayFromZero);
    }
}
}

namespace Benchmarks.csharp_42.Llama
{
using System;

public class Solver 
{
    public static int ClosestInteger(string value) 
    {
        double number = double.Parse(value);
        double floor = Math.Floor(number);
        double ceil = Math.Ceiling(number);
        double diffFloor = Math.Abs(number - floor);
        double diffCeil = Math.Abs(ceil - number);
        if (diffFloor < diffCeil) 
        {
            return (int)floor;
        } 
        else if (diffFloor > diffCeil) 
        {
            return (int)ceil;
        } 
        else 
        {
            return number < 0 ? (int)floor : (int)ceil;
        }
    }
}
}
