// Auto-generated Solvers for Task: csharp_27

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_27.GPT
{
    using System;

    public class Solver
    {
        public static int VowelsCount(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int count = 0;
            string vowels = "aeiou";

            for (int i = 0; i < s.Length; i++)
            {
                char c = char.ToLower(s[i]);

                if (vowels.Contains(c))
                {
                    count++;
                }
                else if (c == 'y' && i == s.Length - 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

namespace Benchmarks.csharp_27.Gemini
{
    using System;
    using System.Linq;

    public class Solver
    {
        public static int VowelsCount(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int count = 0;
            string lowerStr = s.ToLower();

            for (int i = 0; i < lowerStr.Length; i++)
            {
                char c = lowerStr[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
                else if (c == 'y' && i == lowerStr.Length - 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

namespace Benchmarks.csharp_27.Claude
{
    using System;
    using System.Linq;

    public class Solver
    {
        public static int VowelsCount(string s)
        {
            string lower = s.ToLower();
            int count = lower.Count(c => "aeiou".Contains(c));
            if (lower.Length > 0 && lower[lower.Length - 1] == 'y') count++;
            return count;
        }
    }
}

namespace Benchmarks.csharp_27.Grok
{
    using System;

    public class Solver
    {
        public static int VowelsCount(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            string lower = s.ToLower();
            int count = 0;
            for (int i = 0; i < lower.Length; i++)
            {
                char c = lower[i];
                if ("aeiou".Contains(c) || (c == 'y' && i == lower.Length - 1))
                {
                    count++;
                }
            }

            return count;
        }
    }
}

namespace Benchmarks.csharp_27.DeepSeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Solver
    {
        public static int VowelsCount(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int count = 0;
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (vowels.Contains(c))
                {
                    count++;
                }
                else if (i == s.Length - 1 && (c == 'y' || c == 'Y'))
                {
                    count++;
                }
            }

            return count;
        }
    }
}

namespace Benchmarks.csharp_27.Mistral
{
    using System;
    using System;
    using System;

    public class Solver
    {
        public static int VowelsCount(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int count = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                count++;

                
            }
            return count;
        }
    }
}

namespace Benchmarks.csharp_27.Llama
{
    using System;
    using System.Linq;

    public class Solver
    {
        public static int VowelsCount(string s)
        {
            int count = 0;
            string lowerS = s.ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < lowerS.Length; i++)
            {
                char c = lowerS[i];
                if (vowels.Contains(c))
                {
                    count++;
                }
                else if (c == 'y' && i == lowerS.Length - 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}