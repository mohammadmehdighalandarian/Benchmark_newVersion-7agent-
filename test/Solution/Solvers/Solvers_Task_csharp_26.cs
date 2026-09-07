// Auto-generated Solvers for Task: csharp_26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_26.GPT
{
    using System;

    public class Solver
    {
        public static int Fibfib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 0;
            if (n == 2) return 1;

            int a = 0, b = 0, c = 1;

            for (int i = 3; i <= n; i++)
            {
                int next = a + b + c;
                a = b;
                b = c;
                c = next;
            }

            return c;
        }
    }
}

namespace Benchmarks.csharp_26.Gemini
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        /// <summary>
        /// The FibFib number sequence is a sequence similar to the Fibbonacci sequence that's defined as follows:
        /// Fibfib(0) == 0
        /// Fibfib(1) == 0
        /// Fibfib(2) == 1
        /// Fibfib(n) == Fibfib(n-1) + Fibfib(n-2) + Fibfib(n-3).
        /// </summary>
        public static int Fibfib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 0;
            if (n == 2) return 1;


            int a = 0; // Fibfib(n-3)
            int b = 0; // Fibfib(n-2)
            int c = 1; // Fibfib(n-1)
            int result = 0;

            for (int i = 3; i <= n; i++)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
            }

            return c;
        }
    }
}

namespace Benchmarks.csharp_26.Claude
{
    public class Solver
    {
        public static int Fibfib(int n)
        {
            if (n == 0 || n == 1) return 0;
            if (n == 2) return 1;
            int a = 0, b = 0, c = 1;
            for (int i = 3; i <= n; i++)
            {
                int next = a + b + c;
                a = b;
                b = c;
                c = next;
            }

            return c;
        }
    }
}

namespace Benchmarks.csharp_26.Grok
{
    public class Solver
    {
        public static int Fibfib(int n)
        {
            if (n == 0 || n == 1) return 0;
            if (n == 2) return 1;
            int a = 0, b = 0, c = 1;
            for (int i = 3; i <= n; i++)
            {
                int next = a + b + c;
                a = b;
                b = c;
                c = next;
            }

            return c;
        }
    }
}

namespace Benchmarks.csharp_26.DeepSeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Solver
    {
        public static int Fibfib(int n)
        {
            if (n == 0 || n == 1)
                return 0;
            if (n == 2)
                return 1;

            int a = 0, b = 0, c = 1;
            int result = 0;

            for (int i = 3; i <= n; i++)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
            }

            return result;
        }
    }
}

namespace Benchmarks.csharp_26.Llama
{
    using System;

    public class Solver
    {
        public static int Fibfib(int n)
        {
            if (n == 0 || n == 1) return 0;
            if (n == 2) return 1;

            int[] fibfib = new int[n + 1];
            fibfib[0] = 0;
            fibfib[1] = 0;
            fibfib[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                fibfib[i] = fibfib[i - 1] + fibfib[i - 2] + fibfib[i - 3];
            }

            return fibfib[n];
        }
    }
}

namespace Benchmarks.csharp_26.Mistral
{
    using System;

    public class Solver
    {
        public static int Fibfib(int n)
        {
            if (n == 0 || n == 1)
            {
                return 0;
            }

            return n;
        }
    }

}