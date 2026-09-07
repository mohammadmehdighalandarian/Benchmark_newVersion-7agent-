// Auto-generated Solvers for Task: csharp_36
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_36.GPT
{
using System;

public class Solver
{
    public static string Solve(int N)
    {
        int sum = 0;

        while (N > 0)
        {
            sum += N % 10;
            N /= 10;
        }

        return Convert.ToString(sum, 2);
    }
}
}

namespace Benchmarks.csharp_36.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Given a positive integer N, return the total sum of its digits in binary.
    /// </summary>
    public static string Solve(int N)
    {
        int sum = 0;
        int temp = Math.Abs(N);

        // Calculate the sum of the digits of N in base 10
        if (temp == 0)
        {
            sum = 0;
        }
        else
        {
            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
        }

        // Convert the resulting sum to a binary string
        return Convert.ToString(sum, 2);
    }
}
}

namespace Benchmarks.csharp_36.Claude
{
using System;
public class Solver {
    public static string Solve(int N) {
        int sum = 0;
        while (N > 0) { sum += N % 10; N /= 10; }
        return Convert.ToString(sum, 2);
    }
}
}

namespace Benchmarks.csharp_36.Grok
{
using System;

public class Solver
{
    public static string Solve(int N)
    {
        int sum = 0;
        while (N > 0)
        {
            sum += N % 10;
            N /= 10;
        }
        return Convert.ToString(sum, 2);
    }
}
}

namespace Benchmarks.csharp_36.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static string Solve(int N)
    {
        int sum = N.ToString().Sum(c => c - '0');
        return Convert.ToString(sum, 2);
    }
}
}

namespace Benchmarks.csharp_36.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static string Solve(int N)
    {
        int sumOfDigits = 0;
        int temp = N;
        
        while (temp > 0)
        {
            sumOfDigits += temp % 10;
            temp /= 10;
        }
        
        return Convert.ToString(sumOfDigits, 2);
    }
}
}

namespace Benchmarks.csharp_36.Llama
{
using System;

public class Solver 
{
    public static string Solve(int N) 
    {
        int sum = 0;
        while (N > 0) 
        {
            sum += N % 10;
            N /= 10;
        }
        return Convert.ToString(sum, 2);
    }
}
}
