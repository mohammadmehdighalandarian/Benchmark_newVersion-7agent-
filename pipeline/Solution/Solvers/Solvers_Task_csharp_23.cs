// Auto-generated Solvers for Task: csharp_23

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Benchmarks.csharp_23.GPT
{
    using System;

    public class Solver
    {
        public static int LargestPrimeFactor(int n)
        {
            int maxPrime = 1;

            while (n % 2 == 0)
            {
                maxPrime = 2;
                n /= 2;
            }

            for (int i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    maxPrime = i;
                    n /= i;
                }
            }

            if (n > 1)
            {
                maxPrime = n;
            }

            return maxPrime;
        }
    }
}

namespace Benchmarks.csharp_23.Gemini
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static int LargestPrimeFactor(int n)
        {
            int maxPrime = -1;

            // Extract the factor 2
            while (n % 2 == 0)
            {
                maxPrime = 2;
                n /= 2;
            }

            // Extract odd factors starting from 3
            for (int i = 3; (long)i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    maxPrime = i;
                    n /= i;
                }
            }

            // If n is still greater than 2, then the remaining n is the largest prime factor
            if (n > 2)
            {
                maxPrime = n;
            }

            return maxPrime;
        }
    }
}

namespace Benchmarks.csharp_23.Claude
{
    using System;

    public class Solver
    {
        public static int LargestPrimeFactor(int n)
        {
            int largest = 1;
            for (int i = 2; (long)i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    largest = i;
                    n /= i;
                }
            }

            if (n > 1) largest = n;
            return largest;
        }
    }
}

namespace Benchmarks.csharp_23.Grok
{
    using System;

    public class Solver
    {
        public static int LargestPrimeFactor(int n)
        {
            int largest = 1;
            while (n % 2 == 0)
            {
                largest = 2;
                n /= 2;
            }

            for (int i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    largest = i;
                    n /= i;
                }
            }

            if (n > 1)
            {
                largest = n;
            }

            return largest;
        }
    }
}

namespace Benchmarks.csharp_23.Mistral
{
    using System;

    public class Solver
    {
        public static int LargestPrimeFactor(int n)
        {
            throw new SyntaxErrorException();
        }
        
    }
}


namespace Benchmarks.csharp_23.DeepSeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Solver
    {
        public static int LargestPrimeFactor(int n)
        {
            int largest = 1;

            // Handle factor 2
            while (n % 2 == 0)
            {
                largest = 2;
                n /= 2;
            }

            // Handle odd factors
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    largest = i;
                    n /= i;
                }
            }

            // If remaining n is greater than 1, it's a prime factor
            if (n > 1)
            {
                largest = n;
            }

            return largest;
        }
    }
}

namespace Benchmarks.csharp_23.Llama
{
    using System;

    public class Solver
    {
        public static int LargestPrimeFactor(int n)
        {
            int largestFactor = 1;
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    largestFactor = i;
                    n /= i;
                }
            }

            if (n > 1)
            {
                largestFactor = n;
            }

            return largestFactor;
        }
    }
}