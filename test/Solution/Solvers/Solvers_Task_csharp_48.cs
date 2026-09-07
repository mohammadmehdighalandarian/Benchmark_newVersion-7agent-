// Auto-generated Solvers for Task: csharp_48
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_48.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<int> EvenOddPalindrome(int n)
    {
        int evenCount = 0;
        int oddCount = 0;

        for (int i = 1; i <= n; i++)
        {
            if (IsPalindrome(i))
            {
                if (i % 2 == 0) evenCount++;
                else oddCount++;
            }
        }

        return new List<int> { evenCount, oddCount };
    }

    private static bool IsPalindrome(int x)
    {
        string s = x.ToString();
        int l = 0, r = s.Length - 1;

        while (l < r)
        {
            if (s[l] != s[r]) return false;
            l++;
            r--;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_48.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Given a positive integer n, return a list that has the number of even and odd
    /// integer palindromes that fall within the range(1, n), inclusive.
    /// </summary>
    public static List<int> EvenOddPalindrome(int n)
    {
        int evenCount = 0;
        int oddCount = 0;

        for (int i = 1; i <= n; i++)
        {
            if (IsPalindrome(i))
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
        }

        return new List<int> { evenCount, oddCount };
    }

    private static bool IsPalindrome(int num)
    {
        string s = num.ToString();
        int left = 0;
        int right = s.Length - 1;
        
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_48.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> EvenOddPalindrome(int n)
    {
        int even = 0, odd = 0;
        for (int i = 1; i <= n; i++)
        {
            var s = i.ToString();
            if (s == new string(s.Reverse().ToArray()))
            {
                if (i % 2 == 0) even++;
                else odd++;
            }
        }
        return new List<int> { even, odd };
    }
}
}

namespace Benchmarks.csharp_48.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<int> EvenOddPalindrome(int n)
    {
        int evenCount = 0;
        int oddCount = 0;
        for (int i = 1; i <= n; i++)
        {
            if (IsPalindrome(i))
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
        }
        return new List<int> { evenCount, oddCount };
    }

    private static bool IsPalindrome(int num)
    {
        string s = num.ToString();
        int len = s.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (s[i] != s[len - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_48.Mistral
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<int> EvenOddPalindrome(int n)
    {
        int evenCount = 0;
        int oddCount = 0;

        for (int i = 1; i <= n; i++)
        {
            if (IsPalindrome(i))
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
        }

        throw new SyntaxErrorException();
    }

    private static bool IsPalindrome(int num)
    {
        int original = num;
        int reversed = 0;

        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num /= 10;
        }

        return original == reversed;
    }
}
}

namespace Benchmarks.csharp_48.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> EvenOddPalindrome(int n)
    {
        int evenCount = 0;
        int oddCount = 0;
        
        for (int i = 1; i <= n; i++)
        {
            if (IsPalindrome(i))
            {
                if (i % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
        }
        
        return new List<int> { evenCount, oddCount };
    }
    
    private static bool IsPalindrome(int num)
    {
        string str = num.ToString();
        int left = 0;
        int right = str.Length - 1;
        
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_48.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> EvenOddPalindrome(int n) 
    {
        int evenCount = 0;
        int oddCount = 0;
        for (int i = 1; i <= n; i++) 
        {
            string numStr = i.ToString();
            if (numStr.SequenceEqual(numStr.Reverse())) 
            {
                if (i % 2 == 0) 
                {
                    evenCount++;
                } 
                else 
                {
                    oddCount++;
                }
            }
        }
        return new List<int> { evenCount, oddCount };
    }
}
}
