// Auto-generated Solvers for Task: csharp_76
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_76.GPT
{
using System;
using System.Linq;

public class Solver
{
    public static bool RightAngleTriangle(int a, int b, int c)
    {
        int[] s = new int[] { a, b, c };
        Array.Sort(s);

        long x = s[0];
        long y = s[1];
        long z = s[2];

        return x > 0 && y > 0 && z > 0 && (x * x + y * y == z * z);
    }
}
}

namespace Benchmarks.csharp_76.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Given the lengths of the three sides of a triangle. Return True if the three
    /// sides form a right-angled triangle, False otherwise.
    /// A right-angled triangle is a triangle in which one angle is right angle or 
    /// 90 degree.
    /// </summary>
    public static bool RightAngleTriangle(int a, int b, int c)
    {
        // A triangle must have sides with positive length
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }

        // Use long to prevent potential overflow during squaring
        long a2 = (long)a * a;
        long b2 = (long)b * b;
        long c2 = (long)c * c;

        // Check the Pythagorean theorem for all possible hypotenuses
        // a^2 + b^2 = c^2 OR a^2 + c^2 = b^2 OR b^2 + c^2 = a^2
        return (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
    }
}
}

namespace Benchmarks.csharp_76.Claude
{
using System;

public class Solver
{
    public static bool RightAngleTriangle(int a, int b, int c)
    {
        return a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a;
    }
}
}

namespace Benchmarks.csharp_76.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool RightAngleTriangle(int a, int b, int c)
    {
        int x = a * a;
        int y = b * b;
        int z = c * c;

        return (x + y == z) || (x + z == y) || (y + z == x);
    }
}
}

namespace Benchmarks.csharp_76.Mistral
{
using System;
using System.Linq;

public class Solver
{
    public static bool RightAngleTriangle(int a, int b, int c)
    {
        int[] sides = { a, b, c };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}
}

namespace Benchmarks.csharp_76.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool RightAngleTriangle(int a, int b, int c)
    {
        int[] sides = { a, b, c };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}
}

namespace Benchmarks.csharp_76.Llama
{
using System;
using System.Linq;

public class Solver
{
    public static bool RightAngleTriangle(int a, int b, int c)
    {
        var sides = new[] { a, b, c }.OrderBy(x => x).ToArray();
        return sides[0] > 0 && Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}
}
