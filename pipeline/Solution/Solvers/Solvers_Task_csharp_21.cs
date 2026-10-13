// Auto-generated Solvers for Task: csharp_21
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_21.GPT
{
using System;

public class Solver
{
    public static int Fib(int n)
    {
        if (n <= 1) return n;

        int a = 1, b = 1;

        for (int i = 3; i <= n; i++)
        {
            int c = a + b;
            a = b;
            b = c;
        }

        return b;
    }
}
}

namespace Benchmarks.csharp_21.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    /// <summary> 
    /// Return n-th Fibonacci number.
    /// >>> Fib(10)
    /// 55
    /// >>> Fib(1)
    /// 1
    /// >>> Fib(8)
    /// 21
    /// </summary>
    public static int Fib(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;

        int a = 0;
        int b = 1;

        for (int i = 2; i <= n; i++)
        {
            int next = a + b;
            a = b;
            b = next;
        }

        return b;
    }
}
}

namespace Benchmarks.csharp_21.Claude
{
using System;

public class Solver
{
    public static int Fib(int n)
    {
        if (n <= 1) return n == 1 ? 1 : 0;
        int a = 1, b = 1;
        for (int i = 2; i < n; i++) { int c = a + b; a = b; b = c; }
        return b;
    }
}
}

namespace Benchmarks.csharp_21.Grok
{
public class Solver
{
    public static int Fib(int n)
    {
        if (n <= 1) return n;
        int prev2 = 0;
        int prev1 = 1;
        for (int i = 2; i <= n; i++)
        {
            int current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }
        return prev1;
    }
}
}

namespace Benchmarks.csharp_21.Mistral
{
using System;

public class Solver
{
    public static int Fib(int n)
    {
        if (n <= 1)
            return n;
        int a = 0, b = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_21.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int Fib(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
}

namespace Benchmarks.csharp_21.Llama
{
using System;

public class Solver 
{
    public static int Fib(int n) 
    {
        if (n <= 1) return n;
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++) 
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
}
