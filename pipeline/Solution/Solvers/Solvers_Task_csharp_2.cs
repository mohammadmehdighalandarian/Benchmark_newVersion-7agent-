// Auto-generated Solvers for Task: csharp_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_2.GPT
{
using System;

public class Solver
{
    public static string StringXor(string a, string b)
    {
        char[] result = new char[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] == b[i] ? '0' : '1';
        }

        return new string(result);
    }
}
}

namespace Benchmarks.csharp_2.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solver
{
    /// <summary> 
    /// Input are two strings a and b consisting only of 1s and 0s.
    /// Perform binary XOR on these inputs and return result also as a string.
    /// >>> StringXor('010', '110')
    /// '100'
    /// </summary>
    public static string StringXor(string a, string b)
    {
        if (a == null || b == null) return null;
        
        char[] result = new char[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            // XOR logic: result is '0' if characters are the same, '1' if they are different
            result[i] = (a[i] == b[i]) ? '0' : '1';
        }
        
        return new string(result);
    }
}
}

namespace Benchmarks.csharp_2.Claude
{
using System;
using System.Linq;

public class Solver
{
    public static string StringXor(string a, string b)
    {
        return new string(a.Zip(b, (x, y) => x == y ? '0' : '1').ToArray());
    }
}
}

namespace Benchmarks.csharp_2.Grok
{
public class Solver
{
    public static string StringXor(string a, string b)
    {
        char[] result = new char[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = (a[i] == b[i]) ? '0' : '1';
        }
        return new string(result);
    }
}
}

namespace Benchmarks.csharp_2.Mistral
{
using System;

public class Solver
{
    public static string StringXor(string a, string b)
    {
        char[] result = new char[Math.Max(a.Length, b.Length)];
        int maxLength = Math.Max(a.Length, b.Length);

        for (int i = 0; i < maxLength; i++)
        {
            char charA = i < a.Length ? a[i] : '0';
            char charB = i < b.Length ? b[i] : '0';
            result[i] = (charA == charB) ? '0' : '1';
        }

        return new string(result);
    }
}
}

namespace Benchmarks.csharp_2.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static string StringXor(string a, string b)
    {
        char[] result = new char[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] == b[i] ? '0' : '1';
        }
        return new string(result);
    }
}
}

namespace Benchmarks.csharp_2.Llama
{
using System;
using System.Linq;

public class Solver 
{
    public static string StringXor(string a, string b) 
    {
        int maxLength = Math.Max(a.Length, b.Length);
        a = a.PadLeft(maxLength, '0');
        b = b.PadLeft(maxLength, '0');

        return string.Concat(a.Zip(b, (x, y) => (x == y) ? '0' : '1'));
    }
}
}
