// Auto-generated Solvers for Task: csharp_11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_11.GPT
{
using System;

public class Solver
{
    public static int PrimeFib(int n)
    {
        int count = 0;
        long a = 0;
        long b = 1;

        while (true)
        {
            long fib = a + b;
            a = b;
            b = fib;

            if (IsPrime(fib))
            {
                count++;
                if (count == n)
                    return (int)fib;
            }
        }
    }

    private static bool IsPrime(long num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (long i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_11.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int PrimeFib(int n)
    {
        int count = 0;
        long a = 0;
        long b = 1;

        while (true)
        {
            long next = a + b;
            a = b;
            b = next;

            if (IsPrime(b))
            {
                count++;
                if (count == n)
                {
                    return (int)b;
                }
            }
        }
    }

    private static bool IsPrime(long number)
    {
        if (number <= 1) return false;
        if (number == 2 || number == 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;

        for (long i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_11.Claude
{
using System;

public class Solver
{
    public static int PrimeFib(int n)
    {
        bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
                if (num % i == 0) return false;
            return true;
        }
        
        int count = 0, a = 1, b = 1;
        while (true)
        {
            int c = a + b;
            a = b;
            b = c;
            if (IsPrime(a) && ++count == n) return a;
        }
    }
}
}

namespace Benchmarks.csharp_11.Grok
{
using System;

public class Solver
{
    private static bool IsPrime(long num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        for (long i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    public static int PrimeFib(int n)
    {
        int count = 0;
        long a = 0;
        long b = 1;
        while (true)
        {
            long fib = a + b;
            a = b;
            b = fib;
            if (IsPrime(fib))
            {
                count++;
                if (count == n) return (int)fib;
            }
        }
    }
}
}

namespace Benchmarks.csharp_11.Mistral
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static int PrimeFib(int n)
    {
        int count = 0;
        int a = 1, b = 1, c = 0;
        while (count < n)
        {
            c = a + b;
            a = b;
            b = c;
            if (IsPrime(c))
            {
                count++;
            }
        }
        return c;
    }

    private static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_11.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int PrimeFib(int n)
    {
        if (n <= 0) return 0;
        
        List<int> primeFibNumbers = new List<int>();
        int a = 0, b = 1;
        
        while (primeFibNumbers.Count < n)
        {
            int next = a + b;
            a = b;
            b = next;
            
            if (IsPrime(next) && next > 1)
            {
                primeFibNumbers.Add(next);
            }
        }
        
        return primeFibNumbers[n - 1];
    }
    
    private static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        
        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0) return false;
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_11.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static int PrimeFib(int n) 
    {
        int count = 0;
        int a = 0;
        int b = 1;
        while (true) 
        {
            int fib = a + b;
            a = b;
            b = fib;
            if (IsPrime(fib)) 
            {
                count++;
                if (count == n) 
                {
                    return fib;
                }
            }
        }
    }

    public static bool IsPrime(int number) 
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
}
