// Auto-generated Solvers for Task: csharp_35
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_35.GPT
{
using System;

public class Solver
{
    public static bool PrimeLength(string string0)
    {
        int n = string0.Length;

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

namespace Benchmarks.csharp_35.Gemini
{
using System;

public class Solver
{
    /// <summary> 
    /// Takes a string and returns True if the string length is a prime number or False otherwise.
    /// </summary>
    public static bool PrimeLength(string string0)
    {
        int n = string0.Length;
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(n));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_35.Claude
{
using System;

public class Solver
{
    public static bool PrimeLength(string string0)
    {
        int n = string0.Length;
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
}
}

namespace Benchmarks.csharp_35.Grok
{
using System;

public class Solver
{
    public static bool PrimeLength(string string0)
    {
        int len = string0.Length;
        if (len <= 1) return false;
        if (len == 2) return true;
        if (len % 2 == 0) return false;
        for (int i = 3; i * i <= len; i += 2)
        {
            if (len % i == 0) return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_35.Mistral
{
using System;

public class Solver
{
    public static bool PrimeLength(string string0)
    {
        int length = string0.Length;
        if (length <= 1) return false;
        if (length == 2) return true;
        if (length % 2 == 0) return false;

        for (int i = 3; i * i <= length; i += 2)
        {
            if (length % i == 0)
                return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_35.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static bool PrimeLength(string string0)
    {
        int length = string0.Length;
        
        if (length <= 1)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(length); i++)
        {
            if (length % i == 0)
                return false;
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_35.Llama
{
using System;

public class Solver 
{
    public static bool PrimeLength(string string0) 
    {
        int length = string0.Length;
        if (length <= 1) return false;
        for (int i = 2; i * i <= length; i++) 
        {
            if (length % i == 0) return false;
        }
        return true;
    }
}
}
