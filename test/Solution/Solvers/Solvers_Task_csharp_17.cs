// Auto-generated Solvers for Task: csharp_17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_17.GPT
{
using System;
using System.Linq;

public class Solver
{
    public static string RemoveVowels(string text)
    {
        return new string(text.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
    }
}
}

namespace Benchmarks.csharp_17.Gemini
{
using System;
using System.Text.RegularExpressions;

public class Solver
{
    public static string RemoveVowels(string text)
    {
        if (text == null)
        {
            return text;
        }
        return Regex.Replace(text, "[aeiouAEIOU]", "");
    }
}
}

namespace Benchmarks.csharp_17.Claude
{
using System;
using System.Text.RegularExpressions;

public class Solver
{
    public static string RemoveVowels(string text)
    {
        return Regex.Replace(text, "[aeiouAEIOU]", "");
    }
}
}

namespace Benchmarks.csharp_17.Grok
{
using System.Text;

public class Solver
{
    public static string RemoveVowels(string text)
    {
        string vowels = "aeiouAEIOU";
        StringBuilder sb = new StringBuilder();
        foreach (char c in text)
        {
            if (!vowels.Contains(c))
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
}

namespace Benchmarks.csharp_17.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static string RemoveVowels(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return new string(text.Where(c => !vowels.Contains(c)).ToArray());
    }
}
}

namespace Benchmarks.csharp_17.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static string RemoveVowels(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;
        
        var vowels = new HashSet<char>(new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
        return new string(text.Where(c => !vowels.Contains(c)).ToArray());
    }
}
}

namespace Benchmarks.csharp_17.Llama
{
using System;
using System.Linq;

public class Solver 
{
    public static string RemoveVowels(string text) 
    {
        return new string(text.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
    }
}
}
