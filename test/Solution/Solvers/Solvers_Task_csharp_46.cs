// Auto-generated Solvers for Task: csharp_46
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_46.GPT
{
using System;
using System.Linq;

public class Solver
{
    public static object RoundedAvg(int n, int m)
    {
        if (n > m) return -1;

        double avg = (n + m) / 2.0;
        int rounded = (int)Math.Floor(avg);

        string binary = Convert.ToString(rounded, 2);
        return "0b" + binary;
    }
}
}

namespace Benchmarks.csharp_46.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
/// <summary>
/// Computes the average of the integers from n through m (inclusive).
/// Rounds the answer to the nearest integer and converts it to binary.
/// If n > m, returns -1.
/// </summary>
public static object RoundedAvg(int n, int m)
{
// Guard clause: if n is greater than m, return -1.
if (n > m)
{
return -1;
}


    // The average of a sequence of consecutive integers from n to m
    // is the arithmetic mean of the first and last numbers: (n + m) / 2.
    // We use double to handle cases where (n + m) is odd (resulting in .5).
    // Casting m to double handles potential overflow during the addition of two large ints.
    double average = (n + (double)m) / 2.0;

    // Round the average to the nearest integer. 
    // Based on the example RoundedAvg(20, 33) => "0b11010" (which is 26),
    // we use MidpointRounding.ToEven (Banker's Rounding), which is the 
    // default behavior of Math.Round in C#. 26.5 rounds to 26.
    int roundedValue = (int)Math.Round(average, MidpointRounding.ToEven);

    // Convert the rounded integer to its binary string representation.
    string binaryRepresentation = Convert.ToString(roundedValue, 2);

    // Prepend the "0b" prefix and return the result.
    return "0b" + binaryRepresentation;
}



}
}

namespace Benchmarks.csharp_46.Claude
{
using System;

public class Solver
{
    public static object RoundedAvg(int n, int m)
    {
        if (n > m) return -1;
        int avg = (int)Math.Round((double)(n + m) / 2);
        return "0b" + Convert.ToString(avg, 2);
    }
}
}

namespace Benchmarks.csharp_46.Grok
{
using System;

public class Solver
{
    public static object RoundedAvg(int n, int m)
    {
        if (n > m)
        {
            return -1;
        }

        long first = n;
        long last = m;
        long count = last - first + 1;
        long sum = (first + last) * count / 2;
        double avg = (double)sum / count;
        long rounded = (long)Math.Round(avg);
        string binary = Convert.ToString(rounded, 2);
        return "0b" + binary;
    }
}
}

namespace Benchmarks.csharp_46.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static object RoundedAvg(int n, int m)
    {
        if (n > m)
        {
            return -1;
        }

        double sum = Enumerable.Range(n, m - n + 1).Average();
        int roundedAvg = (int)Math.Round(sum);
        return "0b" + Convert.ToString(roundedAvg, 2);
    }
}
}

namespace Benchmarks.csharp_46.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using KellermanSoftware.CompareNetObjects;

public class Solver
{
    public static object RoundedAvg(int n, int m)
    {
        if (n > m)
        {
            return -1;
        }
        
        long sum = 0;
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }
        
        double average = (double)sum / (m - n + 1);
        int rounded = (int)Math.Round(average, MidpointRounding.AwayFromZero);
        
        return "0b" + Convert.ToString(rounded, 2);
    }
}
}

namespace Benchmarks.csharp_46.Llama
{
using System;
using System.Linq;

public class Solver 
{
    public static object RoundedAvg(int n, int m) 
    {
        if (n > m) return -1;
        var count = m - n + 1;
        var sum = (long)n * count + (long)count * (count - 1) / 2;
        var average = (int)Math.Round((double)sum / count);
        return $"0b{Convert.ToString(average, 2)}";
    }
}
}
