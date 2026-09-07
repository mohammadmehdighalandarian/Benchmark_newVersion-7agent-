// Auto-generated Solvers for Task: csharp_31
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_31.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool IsMultiplyPrime(int a)
    {
        if (a <= 1) return false;

        List<int> factors = new List<int>();

        for (int i = 2; i * i <= a; i++)
        {
            while (a % i == 0)
            {
                factors.Add(i);
                a /= i;
            }
        }

        if (a > 1)
            factors.Add(a);

        if (factors.Count != 3)
            return false;

        foreach (var f in factors)
        {
            if (!IsPrime(f))
                return false;
        }

        return true;
    }

    private static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_31.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Returns true if the given number is the multiplication of 3 prime numbers
    /// and false otherwise.
    /// </summary>
    public static bool IsMultiplyPrime(int a)
    {
        if (a < 8) return false;

        int count = 0;
        int temp = a;

        // Iterate through potential factors starting from the smallest prime (2)
        for (int i = 2; i <= temp; i++)
        {
            // If i is a factor, divide temp by i as many times as possible
            // The first factor found is guaranteed to be prime
            while (temp % i == 0)
            {
                count++;
                temp /= i;
            }
        }

        // Return true if the total count of prime factors is exactly 3
        return count == 3;
    }
}
}

namespace Benchmarks.csharp_31.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool IsMultiplyPrime(int a)
    {
        bool IsPrime(int n) {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
        
        for (int i = 2; i < a; i++)
            for (int j = 2; j < a; j++)
                for (int k = 2; k < a; k++)
                    if (IsPrime(i) && IsPrime(j) && IsPrime(k) && i*j*k == a)
                        return true;
        return false;
    }
}
}

namespace Benchmarks.csharp_31.Grok
{
using System;

public class Solver
{
    public static bool IsMultiplyPrime(int a)
    {
        if (a <= 1) return false;
        int count = 0;
        while (a % 2 == 0)
        {
            count++;
            a /= 2;
        }
        for (int i = 3; i * i <= a; i += 2)
        {
            while (a % i == 0)
            {
                count++;
                a /= i;
            }
        }
        if (a > 1) count++;
        return count == 3;
    }
}
}

namespace Benchmarks.csharp_31.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool IsMultiplyPrime(int a)
    {
        if (a < 2) return false;

        List<int> primes = GetPrimesUpTo(100);
        var primeFactors = GetPrimeFactors(a, primes);

        if (primeFactors.Count != 3) return false;

        int product = 1;
        foreach (int prime in primeFactors)
        {
            product *= prime;
        }

        return product == a;
    }

    private static List<int> GetPrimesUpTo(int max)
    {
        List<int> primes = new List<int>();
        for (int i = 2; i < max; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    private static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    private static List<int> GetPrimeFactors(int num, List<int> primes)
    {
        List<int> factors = new List<int>();
        foreach (int prime in primes)
        {
            if (prime * prime > num) break;
            while (num % prime == 0)
            {
                factors.Add(prime);
                num /= prime;
            }
        }
        if (num > 1) factors.Add(num);
        return factors;
    }
}
}

namespace Benchmarks.csharp_31.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool IsMultiplyPrime(int a)
    {
        if (a <= 0) return false;
        
        List<int> primes = GetPrimesUpTo(100);
        
        for (int i = 0; i < primes.Count; i++)
        {
            for (int j = i; j < primes.Count; j++)
            {
                for (int k = j; k < primes.Count; k++)
                {
                    if (primes[i] * primes[j] * primes[k] == a)
                    {
                        return true;
                    }
                }
            }
        }
        
        return false;
    }
    
    private static List<int> GetPrimesUpTo(int limit)
    {
        List<int> primes = new List<int>();
        bool[] isComposite = new bool[limit + 1];
        
        for (int i = 2; i <= limit; i++)
        {
            if (!isComposite[i])
            {
                primes.Add(i);
                for (int j = i * i; j <= limit; j += i)
                {
                    isComposite[j] = true;
                }
            }
        }
        
        return primes;
    }
}
}

namespace Benchmarks.csharp_31.Llama
{
using System;
using System.Linq;

public class Solver
{
    public static bool IsMultiplyPrime(int a)
    {
        // Precompute prime numbers less than 100
        bool[] primes = new bool[100];
        for (int i = 0; i < 100; i++)
            primes[i] = true;
        primes[0] = primes[1] = false;
        for (int i = 2; i * i < 100; i++)
        {
            if (primes[i])
            {
                for (int j = i * i; j < 100; j += i)
                    primes[j] = false;
            }
        }

        // Check all combinations of three prime numbers
        for (int i = 2; i < 100; i++)
        {
            if (primes[i] && a % i == 0)
            {
                int quotient = a / i;
                for (int j = i; j < 100; j++)
                {
                    if (primes[j] && quotient % j == 0)
                    {
                        int last = quotient / j;
                        if (primes[last])
                            return true;
                    }
                }
            }
        }
        return false;
    }
}
}
