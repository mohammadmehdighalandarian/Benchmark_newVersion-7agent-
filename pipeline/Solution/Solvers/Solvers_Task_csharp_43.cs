// Auto-generated Solvers for Task: csharp_43

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_43.GPT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Solver
    {
        public static List<int> MakeAPile(int n)
        {
            var res = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                res.Add(n + 2 * i);
            }

            return res;
        }
    }
}

namespace Benchmarks.csharp_43.Gemini
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        /// <summary> 
        /// Given a positive integer n, you have to make a pile of n levels of stones.
        /// The first level has n stones.
        /// The number of stones in the next level is:
        /// - the next odd number if n is odd.
        /// - the next even number if n is even.
        /// Return the number of stones in each level in a list, where element at index
        /// i represents the number of stones in the level (i+1).
        /// </summary>
        public static List<int> MakeAPile(int n)
        {
            List<int> result = new List<int>();
            int currentLevelStones = n;

            for (int i = 0; i < n; i++)
            {
                result.Add(currentLevelStones);
                currentLevelStones += 2;
            }

            return result;
        }
    }
}

namespace Benchmarks.csharp_43.Claude
{
    using System.Collections.Generic;

    public class Solver
    {
        public static List<int> MakeAPile(int n)
        {
            var result = new List<int>();
            for (int i = 0; i < n; i++)
                result.Add(n + i * 2);
            return result;
        }
    }
}

namespace Benchmarks.csharp_43.Grok
{
    using System.Collections.Generic;

    public class Solver
    {
        public static List<int> MakeAPile(int n)
        {
            List<int> pile = new List<int>();
            int current = n;
            for (int i = 0; i < n; i++)
            {
                pile.Add(current);
                current += 2;
            }

            return pile;
        }
    }
}

namespace Benchmarks.csharp_43.Mistral
{
    using System;
    using System.Collections.Generic;

    public class Solver
    {
        public static List<int> MakeAPile(int n)
        {
            List<int> pile = new List<int>();
            int current = n;
            bool isOdd = n % 2 != 0;

            for (int i = 0; i < n; i++)
            {
                pile.Add(current);
                current += isOdd ? 2 : 2;
            }

            return pile;
        }
    }
}

namespace Benchmarks.csharp_43.DeepSeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static List<int> MakeAPile(int n)
        {
            List<int> result = new List<int>();
            int current = n;

            for (int i = 0; i < n; i++)
            {
                result.Add(current);
                current += 2;
            }

            return result;
        }
    }
}

namespace Benchmarks.csharp_43.Llama
{
    using System;
    using System.Collections.Generic;

    public class Solver
    {
        public static List<int> MakeAPile(int n)
        {
            List<int> result = new List<int>();
            result.Add(n);
            for (int i = 1; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    n += 2;
                }
                else
                {
                    n += 2;
                }

                result.Add(n);
            }

            return result;
        }
    }
}