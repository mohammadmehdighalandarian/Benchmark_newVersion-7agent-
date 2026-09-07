// Auto-generated Solvers for Task: csharp_20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_20.GPT
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Solver
    {
        public static bool SameChars(string s0, string s1)
        {
            return new HashSet<char>(s0).SetEquals(new HashSet<char>(s1));
        }
    }
}

namespace Benchmarks.csharp_20.Gemini
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        /// <summary> 
        /// Check if two words have the same characters.
        /// </summary>
        public static bool SameChars(string s0, string s1)
        {
            if (s0 == null || s1 == null)
            {
                return s0 == s1;
            }

            HashSet<char> set0 = new HashSet<char>(s0);
            HashSet<char> set1 = new HashSet<char>(s1);

            return set0.SetEquals(set1);
        }
    }
}

namespace Benchmarks.csharp_20.Claude
{
    using System.Linq;

    public class Solver
    {
        public static bool SameChars(string s0, string s1)
        {
            var set0 = new System.Collections.Generic.HashSet<char>(s0);
            var set1 = new System.Collections.Generic.HashSet<char>(s1);
            return set0.SetEquals(set1);
        }
    }
}

namespace Benchmarks.csharp_20.Grok
{
    using System.Collections.Generic;

    public class Solver
    {
        public static bool SameChars(string s0, string s1)
        {
            var set0 = new HashSet<char>(s0);
            var set1 = new HashSet<char>(s1);
            return set0.SetEquals(set1);
        }
    }
}

namespace Benchmarks.csharp_20.DeepSeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static bool SameChars(string s0, string s1)
        {
            if (s0 == null || s1 == null)
                return false;

            var set0 = new HashSet<char>(s0);
            var set1 = new HashSet<char>(s1);

            return set0.SetEquals(set1);
        }
    }
}

namespace Benchmarks.csharp_20.Llama
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static bool SameChars(string s0, string s1)
        {
            var dict0 = s0.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            var dict1 = s1.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            return dict0.Keys.All(k => dict1.ContainsKey(k) && dict1[k] >= dict0[k])
                   && dict1.Keys.All(k => dict0.ContainsKey(k) && dict0[k] <= dict1[k]);
        }
    }
}

namespace Benchmarks.csharp_20.Mistral
{
    using System;
    using System.Linq;

    public class Solver
    {
        public static bool SameChars(string s0, string s1)
        {
            return new string(s0.OrderBy(c => c).ToArray()) == new string(s1.OrderBy(c => c).ToArray());
        }
    }
}