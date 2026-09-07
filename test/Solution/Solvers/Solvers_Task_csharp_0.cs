// Auto-generated Solvers for Task: csharp_0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_0.GPT
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static bool BelowZero(List<int> operations)
    {
        int balance = 0;

        foreach (int operation in operations)
        {
            balance += operation;
            if (balance < 0)
                return true;
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_0.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool BelowZero(List<int> operations)
    {
        int balance = 0;

        foreach (int op in operations)
        {
            balance += op;
            if (balance < 0)
            {
                return true;
            }
        }

        return false;
    }
}
}

namespace Benchmarks.csharp_0.Claude
{
using System.Collections.Generic;

public class Solver
{
    public static bool BelowZero(List<int> operations)
    {
        int balance = 0;
        foreach (var op in operations)
        {
            balance += op;
            if (balance < 0) return true;
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_0.Grok
{
using System.Collections.Generic;

public class Solver
{
    public static bool BelowZero(List<int> operations)
    {
        int balance = 0;
        foreach (int operation in operations)
        {
            balance += operation;
            if (balance < 0)
            {
                return true;
            }
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_0.Mistral
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static bool BelowZero(List<int> operations)
    {
        int balance = 0;
        foreach (int op in operations)
        {
            balance += op;
            if (balance < 0)
            {
                return true;
            }
        }
        return false;
    }
}
}

namespace Benchmarks.csharp_0.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static bool BelowZero(List<int> operations)
    {
        int balance = 0;
        
        foreach (int operation in operations)
        {
            balance += operation;
            
            if (balance < 0)
            {
                return true;
            }
        }
        
        return false;
    }
}
}

namespace Benchmarks.csharp_0.Llama
{
using System;
using System.Collections.Generic;

public class Solver 
{
    public static bool BelowZero(List<int> operations) 
    {
        int balance = 0;
        foreach (var operation in operations) 
        {
            balance += operation;
            if (balance < 0) 
            {
                return true;
            }
        }
        return false;
    }
}
}
