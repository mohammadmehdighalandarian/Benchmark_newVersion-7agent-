// Auto-generated Solvers for Task: csharp_41
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_41.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static bool CheckDictCase(Dictionary<object, string> dict)
    {
        if (dict == null || dict.Count == 0)
            return false;

        bool allLower = true;
        bool allUpper = true;

        foreach (var key in dict.Keys)
        {
            if (key == null || key.GetType() != typeof(string))
                return false;

            string s = (string)key;

            if (s != s.ToLower())
                allLower = false;

            if (s != s.ToUpper())
                allUpper = false;
        }

        return allLower || allUpper;
    }
}
}

namespace Benchmarks.csharp_41.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
/// <summary>
/// Given a dictionary, return True if all keys are strings in lower
/// case or all keys are strings in upper case, else return False.
/// The function should return False if the given dictionary is empty.
/// </summary>
public static bool CheckDictCase(Dictionary<object, string> dict)
{
if (dict == null || dict.Count == 0)
{
return false;
}


    bool allLower = true;
    bool allUpper = true;

    foreach (var key in dict.Keys)
    {
        if (key is string s)
        {
            if (s != s.ToLower())
            {
                allLower = false;
            }
            if (s != s.ToUpper())
            {
                allUpper = false;
            }
        }
        else
        {
            // Key is not a string
            return false;
        }
    }

    return allLower || allUpper;
}



}
}

namespace Benchmarks.csharp_41.Claude
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool CheckDictCase(Dictionary<object, string> dict)
    {
        if (dict.Count == 0) return false;
        var keys = dict.Keys.ToList();
        if (keys.Any(k => !(k is string))) return false;
        var strKeys = keys.Cast<string>().ToList();
        return strKeys.All(k => k == k.ToLower()) || strKeys.All(k => k == k.ToUpper());
    }
}
}

namespace Benchmarks.csharp_41.Grok
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool CheckDictCase(Dictionary<object, string> dict)
    {
        if (dict == null || dict.Count == 0) return false;

        if (!dict.Keys.All(k => k is string)) return false;

        var stringKeys = dict.Keys.Cast<string>();

        bool allLower = stringKeys.All(k => k == k.ToLower());
        bool allUpper = stringKeys.All(k => k == k.ToUpper());

        return allLower || allUpper;
    }
}
}

namespace Benchmarks.csharp_41.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool CheckDictCase(Dictionary<object, string> dict)
    {
        if (dict.Count == 0)
        {
            return false;
        }

        bool allLower = true;
        bool allUpper = true;

        foreach (var key in dict.Keys)
        {
            if (key is not string strKey)
            {
                return false;
            }

            if (!strKey.All(char.IsLower))
            {
                allLower = false;
            }

            if (!strKey.All(char.IsUpper))
            {
                allUpper = false;
            }

            if (!allLower && !allUpper)
            {
                return false;
            }
        }

        return allLower || allUpper;
    }
}
}

namespace Benchmarks.csharp_41.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool CheckDictCase(Dictionary<object, string> dict)
    {
        if (dict == null || dict.Count == 0)
            return false;
        
        bool allLower = true;
        bool allUpper = true;
        
        foreach (var key in dict.Keys)
        {
            if (!(key is string))
                return false;
            
            string keyStr = (string)key;
            
            if (keyStr.Any(c => char.IsLetter(c) && !char.IsLower(c)))
                allLower = false;
            
            if (keyStr.Any(c => char.IsLetter(c) && !char.IsUpper(c)))
                allUpper = false;
            
            if (!allLower && !allUpper)
                return false;
        }
        
        return allLower || allUpper;
    }
}
}

namespace Benchmarks.csharp_41.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static bool CheckDictCase(Dictionary<object, string> dict) 
    {
        if (dict.Count == 0) return false;

        bool allLower = true;
        bool allUpper = true;

        foreach (var key in dict.Keys) 
        {
            if (!(key is string)) return false;
            string strKey = (string)key;
            if (!strKey.All(char.IsLower)) allLower = false;
            if (!strKey.All(char.IsUpper)) allUpper = false;
        }

        return allLower || allUpper;
    }
}
}
