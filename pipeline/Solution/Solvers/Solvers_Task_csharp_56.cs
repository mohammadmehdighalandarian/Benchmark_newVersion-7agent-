// Auto-generated Solvers for Task: csharp_56
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_56.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static string Intersection(List<int> interval1, List<int> interval2)
    {
        int start1 = interval1[0], end1 = interval1[1];
        int start2 = interval2[0], end2 = interval2[1];

        int left = Math.Max(start1, start2);
        int right = Math.Min(end1, end2);

        if (left > right)
            return "NO";

        int len = right - left + 1;

        if (IsPrime(len))
            return "YES";

        return "NO";
    }

    private static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_56.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Determines whether the length of the intersection of two closed intervals is a prime number.
    /// </summary>
    public static string Intersection(List<int> interval1, List<int> interval2)
    {
        int start1 = interval1[0];
        int end1 = interval1[1];
        int start2 = interval2[0];
        int end2 = interval2[1];

        // Find the intersection boundaries
        int intersectionStart = Math.Max(start1, start2);
        int intersectionEnd = Math.Min(end1, end2);

        // Check if an intersection exists
        if (intersectionStart > intersectionEnd)
        {
            return "NO";
        }

        // Calculate the length of the closed interval intersection
        int length = intersectionEnd - intersectionStart;

        // Return YES if length is prime, else NO
        return IsPrime(length) ? "YES" : "NO";
    }

    /// <summary>
    /// Helper method to determine if an integer is a prime number.
    /// </summary>
    private static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(n));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}
}

namespace Benchmarks.csharp_56.Claude
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static string Intersection(List<int> interval1, List<int> interval2)
    {
        int start = Math.Max(interval1[0], interval2[0]);
        int end = Math.Min(interval1[1], interval2[1]);
        if (start > end) return "NO";
        int len = end - start;
        if (len < 2) return "NO";
        for (int i = 2; i <= Math.Sqrt(len); i++)
            if (len % i == 0) return "NO";
        return "YES";
    }
}
}

namespace Benchmarks.csharp_56.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static string Intersection(List<int> interval1, List<int> interval2)
    {
        int start1 = interval1[0];
        int end1 = interval1[1];
        int start2 = interval2[0];
        int end2 = interval2[1];

        int intersectStart = Math.Max(start1, start2);
        int intersectEnd = Math.Min(end1, end2);

        if (intersectStart > intersectEnd)
        {
            return "NO";
        }

        int length = intersectEnd - intersectStart;

        return IsPrime(length) ? "YES" : "NO";
    }

    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; (long)i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        return true;
    }
}
}

namespace Benchmarks.csharp_56.Mistral
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static string Intersection(List<int> interval1, List<int> interval2)
    {
        int start1 = interval1[0], end1 = interval1[1];
        int start2 = interval2[0], end2 = interval2[1];

        int intersectionStart = Math.Max(start1, start2);
        int intersectionEnd = Math.Min(end1, end2);

        if (intersectionStart > intersectionEnd)
        {
            return "NO";
        }

        int length = intersectionEnd - intersectionStart + 1;
        if (length < 2)
        {
            return "NO";
        }

        for (int i = 2; i * i <= length; i++)
        {
            if (length % i == 0)
            {
                return "NO";
            }
        }

        return "YES";
    }
}
}

namespace Benchmarks.csharp_56.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static string Intersection(List<int> interval1, List<int> interval2)
    {
        int start1 = interval1[0];
        int end1 = interval1[1];
        int start2 = interval2[0];
        int end2 = interval2[1];
        
        int intersectStart = Math.Max(start1, start2);
        int intersectEnd = Math.Min(end1, end2);
        
        if (intersectStart > intersectEnd)
        {
            return "NO";
        }
        
        int length = intersectEnd - intersectStart + 1;
        
        if (IsPrime(length))
        {
            return "YES";
        }
        
        return "NO";
    }
    
    private static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        
        if (n == 2)
        {
            return true;
        }
        
        if (n % 2 == 0)
        {
            return false;
        }
        
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
}
}

namespace Benchmarks.csharp_56.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static string Intersection(List<int> interval1, List<int> interval2) 
    {
        int start1 = interval1[0];
        int end1 = interval1[1];
        int start2 = interval2[0];
        int end2 = interval2[1];

        int intersectionStart = Math.Max(start1, start2);
        int intersectionEnd = Math.Min(end1, end2);

        if (intersectionStart > intersectionEnd) 
        {
            return "NO";
        }

        int intersectionLength = intersectionEnd - intersectionStart + 1;

        if (IsPrime(intersectionLength)) 
        {
            return "YES";
        } 
        else 
        {
            return "NO";
        }
    }

    private static bool IsPrime(int number) 
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2) 
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
}
