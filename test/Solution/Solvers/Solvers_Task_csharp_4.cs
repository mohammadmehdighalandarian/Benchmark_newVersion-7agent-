// Auto-generated Solvers for Task: csharp_4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_4.GPT
{
using System;

public class Solver
{
    public static int GreatestCommonDivisor(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}
}

namespace Benchmarks.csharp_4.Gemini
{
using System;

public class Solver
{
    /// <summary> 
    /// Return a greatest common divisor of two integers a and b
    /// >>> GreatestCommonDivisor(3, 5)
    /// 1
    /// >>> GreatestCommonDivisor(25, 15)
    /// 5
    /// </summary>
    public static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}
}

namespace Benchmarks.csharp_4.Claude
{
public class Solver
{
    public static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0) { int t = b; b = a % b; a = t; }
        return a;
    }
}
}

namespace Benchmarks.csharp_4.Grok
{
using System;

public class Solver
{
    public static int GreatestCommonDivisor(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}
}

namespace Benchmarks.csharp_4.Mistral
{
using System;

public class Solver
{
    public static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
}

namespace Benchmarks.csharp_4.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int GreatestCommonDivisor(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
}
}

namespace Benchmarks.csharp_4.Llama
{
using System;

public class Solver 
{
    public static int GreatestCommonDivisor(int a, int b) 
    {
        while (b != 0) 
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}
}
