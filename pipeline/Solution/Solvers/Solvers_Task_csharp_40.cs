// Auto-generated Solvers for Task: csharp_40
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_40.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Skjkasdkd(List<int> lst)
    {
        int maxPrime = int.MinValue;
        bool found = false;

        foreach (int num in lst)
        {
            if (IsPrime(num))
            {
                if (!found || num > maxPrime)
                {
                    maxPrime = num;
                    found = true;
                }
            }
        }

        if (!found) return 0;

        int sum = 0;
        int n = maxPrime;

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    private static bool IsPrime(int n)
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

namespace Benchmarks.csharp_40.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Finds the largest prime value in a list of integers and returns the sum of its digits.
    /// </summary>
    public static int Skjkasdkd(List<int> lst)
    {
        if (lst == null || lst.Count == 0)
        {
            return 0;
        }

        int? maxPrime = null;

        foreach (int num in lst)
        {
            if (IsPrime(num))
            {
                if (maxPrime == null || num > maxPrime)
                {
                    maxPrime = num;
                }
            }
        }

        if (maxPrime == null)
        {
            return 0;
        }

        return SumOfDigits(maxPrime.Value);
    }

    private static bool IsPrime(int n)
    {
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

    private static int SumOfDigits(int n)
    {
        int sum = 0;
        int absN = Math.Abs(n);
        while (absN > 0)
        {
            sum += absN % 10;
            absN /= 10;
        }
        return sum;
    }
}
}

namespace Benchmarks.csharp_40.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Skjkasdkd(List<int> lst)
    {
        bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
        
        int largest = lst.Where(IsPrime).DefaultIfEmpty(0).Max();
        return largest.ToString().Sum(c => c - '0');
    }
}
}

namespace Benchmarks.csharp_40.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static int Skjkasdkd (List<int> lst)
    {
        int maxPrime = -1;
        foreach (int num in lst)
        {
            if (num > 1 && IsPrime(num) && (maxPrime == -1 || num > maxPrime))
            {
                maxPrime = num;
            }
        }
        int sum = 0;
        int temp = maxPrime;
        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        return sum;
    }

    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_40.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Skjkasdkd(List<int> lst)
    {
        int maxPrime = -1;
        foreach (int num in lst)
        {
            if (IsPrime(num) && num > maxPrime)
            {
                maxPrime = num;
            }
        }
        
        if (maxPrime == -1)
        {
            return 0;
        }
        
        return SumOfDigits(maxPrime);
    }
    
    private static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        if (num == 2)
        {
            return true;
        }
        if (num % 2 == 0)
        {
            return false;
        }
        
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    private static int SumOfDigits(int num)
    {
        int sum = 0;
        num = Math.Abs(num);
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
}

namespace Benchmarks.csharp_40.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int Skjkasdkd(List<int> lst)
    {
        int largestPrime = 0;
        
        foreach (int num in lst)
        {
            if (IsPrime(num) && num > largestPrime)
            {
                largestPrime = num;
            }
        }
        
        return SumOfDigits(largestPrime);
    }
    
    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0) return false;
        }
        
        return true;
    }
    
    private static int SumOfDigits(int n)
    {
        int sum = 0;
        n = Math.Abs(n);
        
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        
        return sum;
    }
}
}

namespace Benchmarks.csharp_40.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static int Skjkasdkd(List<int> lst) 
    {
        int maxPrime = lst.Where(IsPrime).DefaultIfEmpty(0).Max();
        return SumOfDigits(maxPrime);
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

    private static int SumOfDigits(int n) 
    {
        return Math.Abs(n).ToString().Select(c => int.Parse(c.ToString())).Sum();
    }
}
}
