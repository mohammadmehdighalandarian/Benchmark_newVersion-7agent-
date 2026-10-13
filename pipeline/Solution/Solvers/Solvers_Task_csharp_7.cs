// Auto-generated Solvers for Task: csharp_7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_7.GPT
{
using System;
using System.Linq;

public class Solver
{
    public static string FlipCase(string string0)
    {
        return new string(string0.Select(c =>
            char.IsLower(c) ? char.ToUpper(c) :
            char.IsUpper(c) ? char.ToLower(c) :
            c).ToArray());
    }
}
}

namespace Benchmarks.csharp_7.Gemini
{
using System;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// For a given string, flip lowercase characters to uppercase and uppercase to lowercase.
    /// >>> FlipCase('Hello')
    /// 'hELLO'
    /// </summary>
    public static string FlipCase(string string0)
    {
        if (string0 == null)
        {
            return null;
        }

        return new string(string0.Select(c => 
            char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)
        ).ToArray());
    }
}
}

namespace Benchmarks.csharp_7.Claude
{
using System;
public class Solver {
    public static string FlipCase(string string0) {
        var result = new char[string0.Length];
        for (int i = 0; i < string0.Length; i++)
            result[i] = char.IsUpper(string0[i]) ? char.ToLower(string0[i]) : char.ToUpper(string0[i]);
        return new string(result);
    }
}
}

namespace Benchmarks.csharp_7.Grok
{
using System;

public class Solver
{
    public static string FlipCase (string string0) 
    {
        char[] charArray = string0.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
            else if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }
        return new string(charArray);
    }
}
}

namespace Benchmarks.csharp_7.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static string FlipCase(string string0)
    {
        return new string(string0.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
    }
}
}

namespace Benchmarks.csharp_7.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static string FlipCase(string string0)
    {
        if (string0 == null)
            return null;
        
        char[] result = new char[string0.Length];
        
        for (int i = 0; i < string0.Length; i++)
        {
            char c = string0[i];
            if (char.IsLower(c))
                result[i] = char.ToUpper(c);
            else if (char.IsUpper(c))
                result[i] = char.ToLower(c);
            else
                result[i] = c;
        }
        
        return new string(result);
    }
}
}

namespace Benchmarks.csharp_7.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static string FlipCase(string string0)
    {
        char[] arr = string0.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (char.IsLower(arr[i]))
                arr[i] = char.ToUpper(arr[i]);
            else if (char.IsUpper(arr[i]))
                arr[i] = char.ToLower(arr[i]);
        }
        return new string(arr);
    }
}
}
