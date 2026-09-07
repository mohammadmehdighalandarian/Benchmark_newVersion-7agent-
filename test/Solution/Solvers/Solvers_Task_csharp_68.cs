// Auto-generated Solvers for Task: csharp_68
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_68.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static int SpecialFilter(List<int> nums)
    {
        int count = 0;

        foreach (int n in nums)
        {
            if (n <= 10) continue;

            int x = Math.Abs(n);

            int last = x % 10;

            int first = x;
            while (first >= 10)
                first /= 10;

            if (IsOddDigit(first) && IsOddDigit(last))
                count++;
        }

        return count;
    }

    private static bool IsOddDigit(int d)
    {
        return d == 1 || d == 3 || d == 5 || d == 7 || d == 9;
    }
}
}

namespace Benchmarks.csharp_68.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Returns the number of elements in the array that are greater than 10 and both 
    /// first and last digits of a number are odd (1, 3, 5, 7, 9).
    /// </summary>
    public static int SpecialFilter(List<int> nums)
    {
        int count = 0;
        foreach (int num in nums)
        {
            // Requirement 1: Number must be greater than 10
            if (num > 10)
            {
                string s = num.ToString();
                
                // Get the first and last characters as integers
                int firstDigit = s[0] - '0';
                int lastDigit = s[s.Length - 1] - '0';

                // Requirement 2: Both first and last digits must be odd
                if (IsOdd(firstDigit) && IsOdd(lastDigit))
                {
                    count++;
                }
            }
        }
        return count;
    }

    private static bool IsOdd(int digit)
    {
        return digit % 2 != 0;
    }
}
}

namespace Benchmarks.csharp_68.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int SpecialFilter(List<int> nums)
    {
        int[] odd = {1,3,5,7,9};
        return nums.Count(n => {
            if (n <= 10) return false;
            string s = n.ToString();
            return odd.Contains(s[0]-'0') && odd.Contains(s[s.Length-1]-'0');
        });
    }
}
}

namespace Benchmarks.csharp_68.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int SpecialFilter(List<int> nums)
    {
        return nums.Count(n =>
        {
            if (n <= 10) return false;
            int last = n % 10;
            if (last % 2 == 0) return false;
            int first = n;
            while (first >= 10) first /= 10;
            return first % 2 == 1;
        });
    }
}
}

namespace Benchmarks.csharp_68.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static int SpecialFilter(List<int> nums)
    {
        return nums.Count(n =>
        {
            if (n <= 10) return false;
            string s = Math.Abs(n).ToString();
            int firstDigit = int.Parse(s[0].ToString());
            int lastDigit = int.Parse(s[^1].ToString());
            return firstDigit % 2 != 0 && lastDigit % 2 != 0;
        });
    }
}
}

namespace Benchmarks.csharp_68.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Solver
{
    public static int SpecialFilter(List<int> nums)
    {
        int count = 0;
        
        foreach (int num in nums)
        {
            if (num > 10)
            {
                int absNum = Math.Abs(num);
                string numStr = absNum.ToString();
                
                char firstDigit = numStr[0];
                char lastDigit = numStr[numStr.Length - 1];
                
                bool firstOdd = (firstDigit - '0') % 2 == 1;
                bool lastOdd = (lastDigit - '0') % 2 == 1;
                
                if (firstOdd && lastOdd)
                {
                    count++;
                }
            }
        }
        
        return count;
    }
}
}

namespace Benchmarks.csharp_68.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static int SpecialFilter(List<int> nums) 
    {
        return nums.Count(num => num > 10 && IsFirstAndLastDigitOdd(num));
    }

    private static bool IsFirstAndLastDigitOdd(int num) 
    {
        var numStr = Math.Abs(num).ToString();
        return int.Parse(numStr[0].ToString()) % 2 != 0 && int.Parse(numStr[numStr.Length - 1].ToString()) % 2 != 0;
    }
}
}
