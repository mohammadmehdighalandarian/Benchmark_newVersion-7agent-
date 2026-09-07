// Auto-generated Solvers for Task: csharp_75
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_75.GPT
{
using System;

public class Solver
{
    public static string IntToMiniRoman(int number)
    {
        (int value, string symbol)[] map = new (int, string)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var result = "";

        foreach (var (value, symbol) in map)
        {
            while (number >= value)
            {
                result += symbol;
                number -= value;
            }
        }

        return result.ToLower();
    }
}
}

namespace Benchmarks.csharp_75.Gemini
{
using System;
using System.Text;

public class Solver
{
    /// <summary> 
    /// Given a positive integer, obtain its roman numeral equivalent as a string,
    /// and return it in lowercase.
    /// Restrictions: 1 <= num <= 1000
    /// </summary>
    public static string IntToMiniRoman(int number)
    {
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "m", "cm", "d", "cd", "c", "xc", "l", "xl", "x", "ix", "v", "iv", "i" };

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < values.Length; i++)
        {
            while (number >= values[i])
            {
                number -= values[i];
                result.Append(symbols[i]);
            }
        }

        return result.ToString();
    }
}
}

namespace Benchmarks.csharp_75.Claude
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static string IntToMiniRoman(int number)
    {
        var vals = new[] {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        var syms = new[] {"m","cm","d","cd","c","xc","l","xl","x","ix","v","iv","i"};
        var result = "";
        for(int i=0;i<vals.Length;i++)
            while(number>=vals[i]){result+=syms[i];number-=vals[i];}
        return result;
    }
}
}

namespace Benchmarks.csharp_75.Grok
{
using System;

public class Solver
{
    public static string IntToMiniRoman (int number)
    {
        string[] roman = { "m", "cm", "d", "cd", "c", "xc", "l", "xl", "x", "ix", "v", "iv", "i" };
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string result = "";
        for (int i = 0; i < values.Length; i++)
        {
            while (number >= values[i])
            {
                result += roman[i];
                number -= values[i];
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_75.Mistral
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static string IntToMiniRoman(int number)
    {
        var romanNumerals = new Dictionary<int, string>
        {
            {1000, "m"},
            {900, "cm"},
            {500, "d"},
            {400, "cd"},
            {100, "c"},
            {90, "xc"},
            {50, "l"},
            {40, "xl"},
            {10, "x"},
            {9, "ix"},
            {5, "v"},
            {4, "iv"},
            {1, "i"}
        };

        string result = "";
        foreach (var pair in romanNumerals)
        {
            while (number >= pair.Key)
            {
                result += pair.Value;
                number -= pair.Key;
            }
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_75.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static string IntToMiniRoman(int number)
    {
        string[] thousands = { "", "M", "MM", "MMM" };
        string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        
        string result = thousands[number / 1000] +
                        hundreds[(number % 1000) / 100] +
                        tens[(number % 100) / 10] +
                        ones[number % 10];
        
        return result.ToLower();
    }
}
}

namespace Benchmarks.csharp_75.Llama
{
using System;

public class Solver 
{
    public static string IntToMiniRoman(int number) 
    {
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] romanNumerals = { "m", "cm", "d", "cd", "c", "xc", "l", "xl", "x", "ix", "v", "iv", "i" };

        string result = "";
        for (int i = 0; i < values.Length; i++) 
        {
            while (number >= values[i]) 
            {
                number -= values[i];
                result += romanNumerals[i];
            }
        }
        return result;
    }
}
}
