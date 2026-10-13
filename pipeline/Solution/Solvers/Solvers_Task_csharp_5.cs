// Auto-generated Solvers for Task: csharp_5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_5.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string SortNumbers(string numbers)
    {
        var order = new Dictionary<string, int>
        {
            ["zero"] = 0,
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
            ["four"] = 4,
            ["five"] = 5,
            ["six"] = 6,
            ["seven"] = 7,
            ["eight"] = 8,
            ["nine"] = 9
        };

        return string.Join(" ",
            numbers.Split(' ')
                   .OrderBy(n => order[n]));
    }
}
}

namespace Benchmarks.csharp_5.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string SortNumbers(string numbers)
    {
        if (string.IsNullOrWhiteSpace(numbers))
        {
            return string.Empty;
        }

        Dictionary<string, int> weightMap = new Dictionary<string, int>
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };

        string[] parts = numbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        var sortedParts = parts.OrderBy(word => weightMap.ContainsKey(word) ? weightMap[word] : 10);

        return string.Join(" ", sortedParts);
    }
}
}

namespace Benchmarks.csharp_5.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string SortNumbers(string numbers)
    {
        var order = new[] { "zero","one","two","three","four","five","six","seven","eight","nine" };
        if (string.IsNullOrWhiteSpace(numbers)) return "";
        return string.Join(" ", numbers.Split(' ').OrderBy(n => Array.IndexOf(order, n)));
    }
}
}

namespace Benchmarks.csharp_5.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string SortNumbers(string numbers)
    {
        if (string.IsNullOrWhiteSpace(numbers))
            return "";

        var wordToNum = new Dictionary<string, int>
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };

        var parts = numbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var sortedParts = parts.OrderBy(p => wordToNum[p]);
        return string.Join(" ", sortedParts);
    }
}
}

namespace Benchmarks.csharp_5.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static string SortNumbers(string numbers)
    {
        var numberWords = numbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var numberMap = new
        {
            zero = 0,
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9
        };

        var sortedNumbers = numberWords
            .OrderBy(word => (int)numberMap.GetType().GetField(word).GetValue(numberMap))
            .ToArray();

        return string.Join(" ", sortedNumbers);
    }
}
}

namespace Benchmarks.csharp_5.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string SortNumbers(string numbers)
    {
        if (string.IsNullOrWhiteSpace(numbers))
            return string.Empty;
        
        var numberWords = new List<string> { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        
        var inputNumbers = numbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        var sortedNumbers = inputNumbers
            .OrderBy(w => numberWords.IndexOf(w))
            .ToArray();
        
        return string.Join(" ", sortedNumbers);
    }
}
}

namespace Benchmarks.csharp_5.Llama
{
using System;
using System.Linq;

public class Solver 
{
    public static string SortNumbers(string numbers) 
    {
        var numberWords = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var sorted = numbers.Split(' ').OrderBy(n => Array.IndexOf(numberWords, n));
        return string.Join(" ", sorted);
    }
}
}
