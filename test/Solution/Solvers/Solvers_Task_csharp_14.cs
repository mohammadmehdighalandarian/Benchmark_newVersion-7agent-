// Auto-generated Solvers for Task: csharp_14
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_14.GPT
{
using System;

public class Solver
{
    public static int Fib4(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 0;
        if (n == 2) return 2;
        if (n == 3) return 0;

        int a = 0, b = 0, c = 2, d = 0;

        for (int i = 4; i <= n; i++)
        {
            int next = a + b + c + d;
            a = b;
            b = c;
            c = d;
            d = next;
        }

        return d;
    }
}
}

namespace Benchmarks.csharp_14.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
/// <summary>
/// Computes the n-th element of the Fib4 number sequence efficiently without recursion.
/// Fib4(0) -> 0, Fib4(1) -> 0, Fib4(2) -> 2, Fib4(3) -> 0
/// Fib4(n) -> Fib4(n-1) + Fib4(n-2) + Fib4(n-3) + Fib4(n-4)
/// </summary>
public static int Fib4(int n)
{
if (n == 0) return 0;
if (n == 1) return 0;
if (n == 2) return 2;
if (n == 3) return 0;


    int a = 0; // Fib4(0)
    int b = 0; // Fib4(1)
    int c = 2; // Fib4(2)
    int d = 0; // Fib4(3)

    int result = 0;
    for (int i = 4; i <= n; i++)
    {
        result = a + b + c + d;
        a = b;
        b = c;
        c = d;
        d = result;
    }

    return d;
}



}
}

namespace Benchmarks.csharp_14.Claude
{
using System;

public class Solver
{
    public static int Fib4(int n)
    {
        if (n == 0 || n == 1 || n == 3) return 0;
        if (n == 2) return 2;
        int a = 0, b = 0, c = 2, d = 0;
        for (int i = 4; i <= n; i++)
        {
            int next = a + b + c + d;
            a = b; b = c; c = d; d = next;
        }
        return d;
    }
}
}

namespace Benchmarks.csharp_14.Grok
{
public class Solver
{
    public static int Fib4 (int n)
    {
        if (n == 0 || n == 1 || n == 3) return 0;
        if (n == 2) return 2;
        int a = 0;
        int b = 0;
        int c = 2;
        int d = 0;
        for (int i = 4; i <= n; i++)
        {
            int next = a + b + c + d;
            a = b;
            b = c;
            c = d;
            d = next;
        }
        return d;
    }
}
}

namespace Benchmarks.csharp_14.Mistral
{
using System;

public class Solver
{
    public static int Fib4(int n)
    {
        if (n == 0 || n == 1 || n == 3)
            return 0;
        if (n == 2)
            return 2;

        int a = 0, b = 0, c = 2, d = 0;
        int result = 0;

        for (int i = 4; i <= n; i++)
        {
            result = a + b + c + d;
            a = b;
            b = c;
            c = d;
            d = result;
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_14.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int Fib4(int n)
    {
        if (n == 0 || n == 1) return 0;
        if (n == 2) return 2;
        if (n == 3) return 0;
        
        int a = 0; // Fib4(0)
        int b = 0; // Fib4(1)
        int c = 2; // Fib4(2)
        int d = 0; // Fib4(3)
        int result = 0;
        
        for (int i = 4; i <= n; i++)
        {
            result = a + b + c + d;
            a = b;
            b = c;
            c = d;
            d = result;
        }
        
        return result;
    }
}
}

namespace Benchmarks.csharp_14.Llama
{
using System;

public class Solver 
{
    public static int Fib4(int n) 
    {
        if (n == 0) return 0;
        if (n == 1) return 0;
        if (n == 2) return 2;
        if (n == 3) return 0;

        int[] fib4 = new int[n + 1];
        fib4[0] = 0;
        fib4[1] = 0;
        fib4[2] = 2;
        fib4[3] = 0;

        for (int i = 4; i <= n; i++) 
        {
            fib4[i] = fib4[i - 1] + fib4[i - 2] + fib4[i - 3] + fib4[i - 4];
        }

        return fib4[n];
    }
}
}
