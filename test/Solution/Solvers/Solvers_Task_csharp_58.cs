// Auto-generated Solvers for Task: csharp_58
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_58.GPT
{
using System;

public class Solver
{
    public static int Digits(int n)
    {
        int product = 1;
        bool hasOdd = false;

        while (n > 0)
        {
            int digit = n % 10;
            if (digit % 2 != 0)
            {
                product *= digit;
                hasOdd = true;
            }
            n /= 10;
        }

        return hasOdd ? product : 0;
    }
}
}

namespace Benchmarks.csharp_58.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Given a positive integer n, return the product of the odd Digits.
    /// Return 0 if all Digits are even.
    /// </summary>
    public static int Digits(int n)
    {
        int product = 1;
        bool hasOdd = false;

        // Convert to string to handle digits or use mathematical approach
        // Mathematical approach is generally more efficient
        while (n > 0)
        {
            int digit = n % 10;
            if (digit % 2 != 0)
            {
                product *= digit;
                hasOdd = true;
            }
            n /= 10;
        }

        return hasOdd ? product : 0;
    }
}
}

namespace Benchmarks.csharp_58.Claude
{
using System;
using System.Linq;

public class Solver
{
    public static int Digits(int n)
    {
        var odd = n.ToString().Select(c => c - '0').Where(d => d % 2 != 0).ToList();
        return odd.Count == 0 ? 0 : odd.Aggregate(1, (a, b) => a * b);
    }
}
}

namespace Benchmarks.csharp_58.Grok
{
public class Solver
{
    public static int Digits (int n)
    {
        int product = 1;
        bool hasOdd = false;
        while (n > 0)
        {
            int digit = n % 10;
            if (digit % 2 == 1)
            {
                product *= digit;
                hasOdd = true;
            }
            n /= 10;
        }
        return hasOdd ? product : 0;
    }
}
}

namespace Benchmarks.csharp_58.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static int Digits(int n)
    {
        int product = 1;
        bool hasOddDigit = false;

        foreach (char c in n.ToString())
        {
            int digit = int.Parse(c.ToString());
            if (digit % 2 != 0)
            {
                product *= digit;
                hasOddDigit = true;
            }
        }

        return hasOddDigit ? product : 0;
    }
}
}

namespace Benchmarks.csharp_58.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int Digits(int n)
    {
        int product = 1;
        bool hasOdd = false;
        
        while (n > 0)
        {
            int digit = n % 10;
            if (digit % 2 != 0)
            {
                product *= digit;
                hasOdd = true;
            }
            n /= 10;
        }
        
        return hasOdd ? product : 0;
    }
}
}

namespace Benchmarks.csharp_58.Llama
{
using System;
using System.Linq;

public class Solver 
{
    public static int Digits(int n) 
    {
        int product = 1;
        bool hasOdd = false;
        foreach (char digit in n.ToString()) 
        {
            int d = int.Parse(digit.ToString());
            if (d % 2 != 0) 
            {
                hasOdd = true;
                product *= d;
            }
        }
        return hasOdd ? product : 0;
    }
}
}
