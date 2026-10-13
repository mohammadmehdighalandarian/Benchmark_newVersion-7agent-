// Auto-generated Solvers for Task: csharp_47
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_47.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<int> F(int n)
    {
        List<int> result = new List<int>(n);
        long fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;

            if (i % 2 == 0)
            {
                result.Add((int)fact);
            }
            else
            {
                result.Add(i * (i + 1) / 2);
            }
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_47.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> F(int n)
    {
        List<int> result = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                // Calculate Factorial of i for even i
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                result.Add(factorial);
            }
            else
            {
                // Calculate Sum from 1 to i for odd i
                // Formula: (n * (n + 1)) / 2
                int sum = (i * (i + 1)) / 2;
                result.Add(sum);
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_47.Claude
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<int> F(int n)
    {
        var result = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++) fact *= j;
                result.Add(fact);
            }
            else
            {
                result.Add(i * (i + 1) / 2);
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_47.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<int> F (int n) 
    {
        List<int> res = new List<int>(n);
        long sum = 0;
        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
            fact *= i;
            if (i % 2 == 0)
            {
                res.Add((int)fact);
            }
            else
            {
                res.Add((int)sum);
            }
        }
        return res;
    }
}
}

namespace Benchmarks.csharp_47.Mistral
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<int> F(int n)
    {
        List<int> result = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                result.Add(factorial);
            }
            else
            {
                int sum = 0;
                for (int j = 1; j <= i; j++)
                {
                    sum += j;
                }
                result.Add(sum);
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_47.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> F(int n)
    {
        List<int> result = new List<int>();
        
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                // Even index: factorial of i
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                result.Add(factorial);
            }
            else
            {
                // Odd index: sum from 1 to i
                int sum = i * (i + 1) / 2;
                result.Add(sum);
            }
        }
        
        return result;
    }
}
}

namespace Benchmarks.csharp_47.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> F(int n) 
    {
        List<int> result = new List<int>();
        for (int i = 1; i <= n; i++) 
        {
            if (i % 2 == 0) 
            {
                long factorial = 1;
                for (int j = 1; j <= i; j++) 
                {
                    factorial *= j;
                }
                result.Add((int)Math.Min(factorial, int.MaxValue));
            } 
            else 
            {
                result.Add(i * (i + 1) / 2);
            }
        }
        return result;
    }
}
}
