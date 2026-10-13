// Auto-generated Solvers for Task: csharp_70
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_70.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<string> Bf(string planet1, string planet2)
    {
        string[] planets = new string[]
        {
            "Mercury", "Venus", "Earth", "Mars",
            "Jupiter", "Saturn", "Uranus", "Neptune"
        };

        int i1 = Array.IndexOf(planets, planet1);
        int i2 = Array.IndexOf(planets, planet2);

        if (i1 == -1 || i2 == -1)
            return new List<string>();

        int start = Math.Min(i1, i2);
        int end = Math.Max(i1, i2);

        List<string> result = new List<string>();

        for (int i = start + 1; i < end; i++)
        {
            result.Add(planets[i]);
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_70.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Returns a list containing all planets whose orbits are 
    /// located between the orbit of planet1 and the orbit of planet2, sorted by 
    /// the proximity to the sun.
    /// </summary>
    public static List<string> Bf(string planet1, string planet2)
    {
        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

        int index1 = Array.IndexOf(planets, planet1);
        int index2 = Array.IndexOf(planets, planet2);

        // If planet1 or planet2 are not correct planet names, return an empty list
        if (index1 == -1 || index2 == -1)
        {
            return new List<string>();
        }

        int start = Math.Min(index1, index2);
        int end = Math.Max(index1, index2);

        List<string> result = new List<string>();

        // Iterate through planets between the two indices
        for (int i = start + 1; i < end; i++)
        {
            result.Add(planets[i]);
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_70.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> Bf(string planet1, string planet2)
    {
        var planets = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
        int i1 = planets.IndexOf(planet1);
        int i2 = planets.IndexOf(planet2);
        if (i1 == -1 || i2 == -1) return new List<string>();
        int lo = Math.Min(i1, i2);
        int hi = Math.Max(i1, i2);
        return planets.Skip(lo + 1).Take(hi - lo - 1).ToList();
    }
}
}

namespace Benchmarks.csharp_70.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> Bf(string planet1, string planet2)
    {
        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
        int idx1 = Array.IndexOf(planets, planet1);
        int idx2 = Array.IndexOf(planets, planet2);
        if (idx1 == -1 || idx2 == -1) return new List<string>();
        int start = Math.Min(idx1, idx2) + 1;
        int end = Math.Max(idx1, idx2);
        return planets.Skip(start).Take(end - start).ToList();
    }
}
}

namespace Benchmarks.csharp_70.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> Bf(string planet1, string planet2)
    {
        var planets = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

        if (!planets.Contains(planet1) || !planets.Contains(planet2))
            return new List<string>();

        int index1 = planets.IndexOf(planet1);
        int index2 = planets.IndexOf(planet2);

        int start = Math.Min(index1, index2);
        int end = Math.Max(index1, index2);

        return planets.GetRange(start + 1, end - start - 1);
    }
}
}

namespace Benchmarks.csharp_70.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> Bf(string planet1, string planet2)
    {
        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
        
        int index1 = Array.IndexOf(planets, planet1);
        int index2 = Array.IndexOf(planets, planet2);
        
        if (index1 == -1 || index2 == -1)
        {
            return new List<string>();
        }
        
        int start = Math.Min(index1, index2);
        int end = Math.Max(index1, index2);
        
        List<string> result = new List<string>();
        for (int i = start + 1; i < end; i++)
        {
            result.Add(planets[i]);
        }
        
        return result;
    }
}
}

namespace Benchmarks.csharp_70.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> Bf(string planet1, string planet2)
    {
        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
        if (!planets.Contains(planet1) || !planets.Contains(planet2))
            return new List<string>();

        int index1 = Array.IndexOf(planets, planet1);
        int index2 = Array.IndexOf(planets, planet2);

        int start = Math.Min(index1, index2);
        int end = Math.Max(index1, index2);

        return planets.Skip(start + 1).Take(end - start - 1).ToList();
    }
}
}
