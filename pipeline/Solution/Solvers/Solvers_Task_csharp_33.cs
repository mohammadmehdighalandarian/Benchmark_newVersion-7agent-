// Auto-generated Solvers for Task: csharp_33
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_33.GPT
{
using System;

public class Solver
{
    public static bool IsHappy(string s)
    {
        if (s == null || s.Length < 3)
            return false;

        for (int i = 0; i < s.Length - 2; i++)
        {
            char a = s[i];
            char b = s[i + 1];
            char c = s[i + 2];

            if (a == b || a == c || b == c)
                return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_33.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    /// <summary> 
    /// Checks if a string is happy.
    /// A string is happy if its length is at least 3 and every 3 consecutive letters are distinct.
    /// </summary>
    public static bool IsHappy(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 3)
        {
            return false;
        }

        for (int i = 0; i <= s.Length - 3; i++)
        {
            char first = s[i];
            char second = s[i + 1];
            char third = s[i + 2];

            if (first == second || first == third || second == third)
            {
                return false;
            }
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_33.Claude
{
using System;

public class Solver
{
    public static bool IsHappy(string s)
    {
        if (s.Length < 3) return false;
        for (int i = 0; i <= s.Length - 3; i++)
            if (s[i] == s[i+1] || s[i+1] == s[i+2] || s[i] == s[i+2]) return false;
        return true;
    }
}
}

namespace Benchmarks.csharp_33.Grok
{
using System;

public class Solver
{
    public static bool IsHappy(string s)
    {
        if (s.Length < 3) return false;
        for (int i = 0; i <= s.Length - 3; i++)
        {
            if (s[i] == s[i + 1] || s[i] == s[i + 2] || s[i + 1] == s[i + 2])
            {
                return false;
            }
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_33.Mistral
{
using System;

public class Solver
{
    public static bool IsHappy(string s)
    {
        if (s.Length < 3)
        {
            return false;
        }

        for (int i = 0; i <= s.Length - 3; i++)
        {
            if (s[i] == s[i + 1] || s[i] == s[i + 2] || s[i + 1] == s[i + 2])
            {
                return false;
            }
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_33.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static bool IsHappy(string s)
    {
        if (s.Length < 3)
        {
            return false;
        }
        
        for (int i = 0; i <= s.Length - 3; i++)
        {
            if (s[i] == s[i + 1] || s[i] == s[i + 2] || s[i + 1] == s[i + 2])
            {
                return false;
            }
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_33.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool IsHappy(string s)
    {
        if (s.Length < 3) return false;
        for (int i = 0; i <= s.Length - 3; i++)
        {
            if (s[i] == s[i + 1] || s[i] == s[i + 2] || s[i + 1] == s[i + 2])
                return false;
        }
        return true;
    }
}
}
