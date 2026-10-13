// Auto-generated Solvers for Task: csharp_66
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_66.GPT
{
using System;

public class Solver
{
    public static bool Simplify(string x, string n)
    {
        var partsX = x.Split('/');
        var partsN = n.Split('/');

        long a = long.Parse(partsX[0]);
        long b = long.Parse(partsX[1]);
        long c = long.Parse(partsN[0]);
        long d = long.Parse(partsN[1]);

        long numerator = a * c;
        long denominator = b * d;

        return numerator % denominator == 0;
    }
}
}

namespace Benchmarks.csharp_66.Gemini
{
using System;

public class Solver
{
    /// <summary> 
    /// You're an expert C# programmer
    /// Your task is to implement a function that will Simplify the expression
    /// x * n. The function returns True if x * n evaluates to a whole number and False
    /// otherwise. Both x and n, are string representation of a fraction, and have the following format,
    /// <numerator>/<denominator> where both numerator and denominator are positive whole numbers.
    /// 
    /// You can assume that x, and n are valid fractions, and do not have zero as denominator.
    /// 
    /// Simplify("1/5", "5/1") = True
    /// Simplify("1/6", "2/1") = False
    /// Simplify("7/10", "10/2") = False
    /// 
    /// </summary>
    public static bool Simplify(string x, string n)
    {
        string[] xParts = x.Split('/');
        string[] nParts = n.Split('/');

        long xNum = long.Parse(xParts[0]);
        long xDen = long.Parse(xParts[1]);
        long nNum = long.Parse(nParts[0]);
        long nDen = long.Parse(nParts[1]);

        long numeratorProduct = xNum * nNum;
        long denominatorProduct = xDen * nDen;

        return numeratorProduct % denominatorProduct == 0;
    }
}
}

namespace Benchmarks.csharp_66.Claude
{
using System;

public class Solver
{
    public static bool Simplify(string x, string n)
    {
        var xp = x.Split('/');
        var np = n.Split('/');
        long num = long.Parse(xp[0]) * long.Parse(np[0]);
        long den = long.Parse(xp[1]) * long.Parse(np[1]);
        return num % den == 0;
    }
}
}

namespace Benchmarks.csharp_66.Grok
{
using System;
using System.Numerics;

public class Solver
{
    public static bool Simplify(string x, string n)
    {
        string[] x_parts = x.Split('/');
        BigInteger x_num = BigInteger.Parse(x_parts[0]);
        BigInteger x_den = BigInteger.Parse(x_parts[1]);

        string[] n_parts = n.Split('/');
        BigInteger n_num = BigInteger.Parse(n_parts[0]);
        BigInteger n_den = BigInteger.Parse(n_parts[1]);

        BigInteger num = x_num * n_num;
        BigInteger den = x_den * n_den;

        return num % den == 0;
    }
}
}

namespace Benchmarks.csharp_66.Mistral
{
using System;

public class Solver
{
    public static bool Simplify(string x, string n)
    {
        var xParts = x.Split('/');
        var nParts = n.Split('/');

        long xNumerator = long.Parse(xParts[0]);
        long xDenominator = long.Parse(xParts[1]);
        long nNumerator = long.Parse(nParts[0]);
        long nDenominator = long.Parse(nParts[1]);

        long numerator = xNumerator * nNumerator;
        long denominator = xDenominator * nDenominator;

        return numerator % denominator == 0;
    }
}
}

namespace Benchmarks.csharp_66.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static bool Simplify(string x, string n)
    {
        string[] xParts = x.Split('/');
        string[] nParts = n.Split('/');
        
        int xNumerator = int.Parse(xParts[0]);
        int xDenominator = int.Parse(xParts[1]);
        int nNumerator = int.Parse(nParts[0]);
        int nDenominator = int.Parse(nParts[1]);
        
        int productNumerator = xNumerator * nNumerator;
        int productDenominator = xDenominator * nDenominator;
        
        return productNumerator % productDenominator == 0;
    }
}
}

namespace Benchmarks.csharp_66.Llama
{
using System;

public class Solver 
{
    public static bool Simplify(string x, string n) 
    {
        var partsX = x.Split('/');
        var partsN = n.Split('/');

        long numeratorX = long.Parse(partsX[0]);
        long denominatorX = long.Parse(partsX[1]);

        long numeratorN = long.Parse(partsN[0]);
        long denominatorN = long.Parse(partsN[1]);

        long productNumerator = numeratorX * numeratorN;
        long productDenominator = denominatorX * denominatorN;

        return productNumerator % productDenominator == 0;
    }
}
}
