// Auto-generated Solvers for Task: csharp_9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_9.GPT
{
using System;

public class Solver
{
    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        int limit = (int)Math.Sqrt(n);
        for (int i = 3; i <= limit; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_9.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Return true if a given number is prime, and false otherwise.
    /// </summary>
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_9.Claude
{
using System;

public class Solver
{
    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (int i = 3; i * i <= n; i += 2)
            if (n % i == 0) return false;
        return true;
    }
}
}

namespace Benchmarks.csharp_9.Grok
{
using System;

public class Solver
{
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_9.Mistral
{
using System;

public class Solver
{
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_9.DeepSeek
{
using System;

public class Solver
{
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        int limit = (int)Math.Sqrt(n);
        for (int i = 3; i <= limit; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_9.Llama
{
using System;

public class Solver 
{
    public static bool IsPrime(int n) 
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
