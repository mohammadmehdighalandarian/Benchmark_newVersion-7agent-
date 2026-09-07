// Auto-generated Solvers for Task: csharp_77
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_77.GPT
{
using System;
using System.Linq;

public class Solver
{
    public static string Solve(string s)
    {
        bool hasLetter = s.Any(char.IsLetter);

        if (!hasLetter)
        {
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            return new string(rev);
        }

        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (char.IsLetter(c))
            {
                result[i] = char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c);
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }
}
}

namespace Benchmarks.csharp_77.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// If s contains letters, reverse the case of each letter.
    /// If s contains no letters, reverse the entire string.
    /// </summary>
    public static string Solve(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }

        bool hasLetters = s.Any(char.IsLetter);

        if (hasLetters)
        {
            char[] result = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsLower(c))
                {
                    result[i] = char.ToUpper(c);
                }
                else if (char.IsUpper(c))
                {
                    result[i] = char.ToLower(c);
                }
                else
                {
                    result[i] = c;
                }
            }
            return new string(result);
        }
        else
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
}

namespace Benchmarks.csharp_77.Claude
{
using System;
using System.Linq;

public class Solver
{
    public static string Solve(string s)
    {
        if (!s.Any(char.IsLetter))
            return new string(s.Reverse().ToArray());
        return new string(s.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
    }
}
}

namespace Benchmarks.csharp_77.Grok
{
using System;

public class Solver
{
    public static string Solve(string s)
    {
        bool hasLetter = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                hasLetter = true;
                break;
            }
        }

        if (!hasLetter)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        char[] result = s.ToCharArray();
        for (int i = 0; i < result.Length; i++)
        {
            char c = result[i];
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                {
                    result[i] = char.ToLower(c);
                }
                else
                {
                    result[i] = char.ToUpper(c);
                }
            }
        }
        return new string(result);
    }
}
}

namespace Benchmarks.csharp_77.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static string Solve(string s)
    {
        bool hasLetters = s.Any(char.IsLetter);
        if (!hasLetters)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        else
        {
            return new string(s.Select(c => char.IsLetter(c) ? (char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)) : c).ToArray());
        }
    }
}
}

namespace Benchmarks.csharp_77.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static string Solve(string s)
    {
        bool hasLetter = s.Any(char.IsLetter);
        
        if (!hasLetter)
        {
            return new string(s.Reverse().ToArray());
        }
        
        char[] result = new char[s.Length];
        
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (char.IsLetter(c))
            {
                if (char.IsLower(c))
                    result[i] = char.ToUpper(c);
                else
                    result[i] = char.ToLower(c);
            }
            else
            {
                result[i] = c;
            }
        }
        
        return new string(result);
    }
}
}

namespace Benchmarks.csharp_77.Llama
{
using System;
using System.Linq;
using System.Text;

public class Solver
{
    public static string Solve(string s)
    {
        if (s == null)
        {
            return null;
        }

        bool containsLetters = s.Any(Char.IsLetter);

        if (!containsLetters)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        else
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                {
                    if (Char.IsLower(c))
                    {
                        result.Append(Char.ToUpper(c));
                    }
                    else
                    {
                        result.Append(Char.ToLower(c));
                    }
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
}
