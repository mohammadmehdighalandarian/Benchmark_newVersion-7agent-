// Auto-generated Solvers for Task: csharp_64
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_64.GPT
{
using System;

public class Solver
{
    public static int SpecialFactorial(int n)
    {
        int fact = 1;
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            result *= fact;
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_64.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// The Brazilian factorial is defined as:
    /// brazilian_factorial(n) = n! * (n-1)! * (n-2)! * ... * 1!
    /// where n > 0
    /// </summary>
    public static int SpecialFactorial(int n)
    {
        if (n <= 0) return 0;
        
        int result = 1;
        int currentFactorial = 1;
        
        for (int i = 1; i <= n; i++)
        {
            currentFactorial *= i;
            result *= currentFactorial;
        }
        
        return result;
    }
}
}

namespace Benchmarks.csharp_64.Claude
{
using System;

public class Solver
{
    public static int SpecialFactorial(int n)
    {
        int result = 1;
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            result *= fact;
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_64.Grok
{
public class Solver
{
    public static int SpecialFactorial(int n)
    {
        int product = 1;
        for (int m = 1; m <= n; m++)
        {
            int exp = n - m + 1;
            for (int i = 0; i < exp; i++)
            {
                product *= m;
            }
        }
        return product;
    }
}
}

namespace Benchmarks.csharp_64.Mistral
{
using System;

public class Solver
{
    public static int SpecialFactorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= Factorial(i);
        }
        return result;
    }

    private static int Factorial(int num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
}

namespace Benchmarks.csharp_64.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int SpecialFactorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= Factorial(i);
        }
        return result;
    }

    private static int Factorial(int num)
    {
        int fact = 1;
        for (int i = 2; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
}

namespace Benchmarks.csharp_64.Llama
{
using System;

public class Solver 
{
    public static int SpecialFactorial(int n) 
    {
        long result = 1;
        for (int i = 1; i <= n; i++) 
        {
            long factorial = 1;
            for (int j = 1; j <= i; j++) 
            {
                factorial *= j;
            }
            result *= factorial;
            if (result > int.MaxValue) 
            {
                throw new OverflowException();
            }
        }
        return (int)result;
    }
}
}
