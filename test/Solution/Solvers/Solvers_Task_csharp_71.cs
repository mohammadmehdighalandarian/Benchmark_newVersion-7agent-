// Auto-generated Solvers for Task: csharp_71
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_71.GPT
{
using System;

public class Solver
{
    public static int XOrY(int n, int x, int y)
    {
        if (n <= 1) return y;
        if (n == 2) return x;
        if (n % 2 == 0) return y;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return y;
        }

        return x;
    }
}
}

namespace Benchmarks.csharp_71.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// A simple program which should return the value of x if n is 
    /// a prime number and should return the value of y otherwise.
    /// </summary>
    public static int XOrY(int n, int x, int y)
    {
        if (IsPrime(n))
        {
            return x;
        }
        return y;
    }

    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(n));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_71.Claude
{
using System;

public class Solver
{
    public static int XOrY(int n, int x, int y)
    {
        if (n < 2) return y;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return y;
        return x;
    }
}
}

namespace Benchmarks.csharp_71.Grok
{
using System;

public class Solver
{
    public static int XOrY (int n, int x, int y)
    {
        if (n <= 1)
        {
            return y;
        }
        if (n == 2 || n == 3)
        {
            return x;
        }
        if (n % 2 == 0 || n % 3 == 0)
        {
            return y;
        }
        for (int i = 5; (long)i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return y;
            }
        }
        return x;
    }
}
}

namespace Benchmarks.csharp_71.Mistral
{
using System;

public class Solver
{
    public static int XOrY(int n, int x, int y)
    {
        if (n <= 1)
            return y;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return y;
        }
        return x;
    }
}
}

namespace Benchmarks.csharp_71.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int XOrY(int n, int x, int y)
    {
        if (IsPrime(n))
        {
            return x;
        }
        else
        {
            return y;
        }
    }
    
    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        
        int boundary = (int)Math.Sqrt(n);
        for (int i = 3; i <= boundary; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_71.Llama
{
using System;

public class Solver 
{
    public static int XOrY(int n, int x, int y) 
    {
        if (n <= 1) return y;
        for (int i = 2; i * i <= n; i++) 
        {
            if (n % i == 0) return y;
        }
        return x;
    }
}
}
