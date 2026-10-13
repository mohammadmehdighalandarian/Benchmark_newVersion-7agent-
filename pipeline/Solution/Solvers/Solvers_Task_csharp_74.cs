// Auto-generated Solvers for Task: csharp_74
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_74.GPT
{
using System;
using System.Linq;

public class Solver
{
    public static bool CycpatternCheck(string a, string b)
    {
        int n = b.Length;
        if (n == 0 || n > a.Length) return false;

        for (int i = 0; i <= a.Length - n; i++)
        {
            string sub = a.Substring(i, n);
            if ((sub + sub).Contains(b))
                return true;
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_74.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    /// <summary> 
    /// You're an expert C# programmer
    /// You are given 2 words. You need to return True if the second word or any of its rotations is a substring in the first word
    /// CycpatternCheck("abcd","abd") => False
    /// CycpatternCheck("hello","ell") => True
    /// CycpatternCheck("whassup","psus") => False
    /// CycpatternCheck("abab","baa") => True
    /// CycpatternCheck("efef","eeff") => False
    /// CycpatternCheck("himenss","simen") => True
    /// </summary>
    public static bool CycpatternCheck(string a, string b)
    {
        if (string.IsNullOrEmpty(b)) return true;
        if (b.Length > a.Length) return false;

        int n = b.Length;
        for (int i = 0; i < n; i++)
        {
            // Generate rotation starting at index i
            string rotation = b.Substring(i) + b.Substring(0, i);
            if (a.Contains(rotation))
            {
                return true;
            }
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_74.Claude
{
using System;

public class Solver
{
    public static bool CycpatternCheck(string a, string b)
    {
        string doubled = b + b;
        for (int i = 0; i < b.Length; i++)
        {
            string rotation = doubled.Substring(i, b.Length);
            if (a.Contains(rotation)) return true;
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_74.Grok
{
using System;

public class Solver
{
    public static bool CycpatternCheck(string a, string b)
    {
        if (b.Length == 0) return true;
        for (int i = 0; i < b.Length; i++)
        {
            string rot = b.Substring(i) + b.Substring(0, i);
            if (a.Contains(rot)) return true;
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_74.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static bool CycpatternCheck(string a, string b)
    {
        if (string.IsNullOrEmpty(b))
            return true;

        string doubledB = b + b;
        for (int i = 0; i < b.Length; i++)
        {
            string rotation = doubledB.Substring(i, b.Length);
            if (a.Contains(rotation))
                return true;
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_74.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool CycpatternCheck(string a, string b)
    {
        if (string.IsNullOrEmpty(b)) return true;
        if (string.IsNullOrEmpty(a)) return false;
        
        string rotated = b;
        for (int i = 0; i < b.Length; i++)
        {
            if (a.Contains(rotated))
                return true;
            
            rotated = RotateLeft(rotated);
        }
        
        return false;
    }
    
    private static string RotateLeft(string s)
    {
        if (s.Length <= 1) return s;
        return s.Substring(1) + s[0];
    }
}
}

namespace Benchmarks.csharp_74.Llama
{
using System;
using System.Linq;

public class Solver 
{
    public static bool CycpatternCheck(string a, string b) 
    {
        if (a.Length < b.Length) return false;
        string rotatedB = b + b;
        return rotatedB.Contains(a.Substring(0, b.Length)) && a.Contains(b);
    }
}
}
