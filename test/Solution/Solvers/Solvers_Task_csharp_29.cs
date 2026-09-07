// Auto-generated Solvers for Task: csharp_29
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_29.GPT
{
using System;

public class Solver
{
    public static object TriangleArea(int a, int b, int c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
            return -1;

        double s = (a + b + c) / 2.0;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        return Math.Round(area, 2);
    }
}
}

namespace Benchmarks.csharp_29.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Given the lengths of the three sides of a triangle. Return the area of
    /// the triangle rounded to 2 decimal points if the three sides form a valid triangle. 
    /// Otherwise return -1
    /// Three sides make a valid triangle when the sum of any two sides is greater 
    /// than the third side.
    /// </summary>
    public static object TriangleArea(int a, int b, int c)
    {
        // Check for valid triangle inequality
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            return -1;
        }

        // Use Heron's formula: Area = sqrt(s(s-a)(s-b)(s-c))
        // where s is the semi-perimeter: (a+b+c)/2
        double s = (a + b + c) / 2.0;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        // Return the area rounded to 2 decimal points
        return Math.Round(area, 2);
    }
}
}

namespace Benchmarks.csharp_29.Claude
{
using System;

public class Solver
{
    public static object TriangleArea(int a, int b, int c)
    {
        if (a + b <= c || a + c <= b || b + c <= a) return -1;
        double s = (a + b + c) / 2.0;
        return Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), 2);
    }
}
}

namespace Benchmarks.csharp_29.Grok
{
using System;

public class Solver
{
    public static object TriangleArea (int a, int b, int c) 
    {
        if (a + b <= c || a + c <= b || b + c <= a)
            return -1;
        double s = (a + b + c) / 2.0;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return Math.Round(area, 2);
    }
}
}

namespace Benchmarks.csharp_29.Mistral
{
using System;

public class Solver
{
    public static double TriangleArea(int a, int b, int c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            return -1;
        }

        double s = (a + b + c) / 2.0;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return Math.Round(area, 2);
    }
}
}

namespace Benchmarks.csharp_29.DeepSeek
{
using System;

public class Solver
{
    public static object TriangleArea(int a, int b, int c)
    {
        // Check if the three sides form a valid triangle
        if (a + b > c && a + c > b && b + c > a)
        {
            // Calculate semi-perimeter
            double s = (a + b + c) / 2.0;
            
            // Calculate area using Heron's formula
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            
            // Round to 2 decimal places
            return Math.Round(area, 2);
        }
        
        return -1;
    }
}
}

namespace Benchmarks.csharp_29.Llama
{
using System;

public class Solver 
{
    public static object TriangleArea(int a, int b, int c) 
    {
        if (a + b > c && a + c > b && b + c > a) 
        {
            double s = (a + b + c) / 2.0;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return Math.Round(area, 2);
        }
        return -1;
    }
}
}
