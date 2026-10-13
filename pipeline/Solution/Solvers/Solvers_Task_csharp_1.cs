// Auto-generated Solvers for Task: csharp_1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_1.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> SumProduct(List<int> numbers)
    {
        int sum = 0;
        int product = 1;

        foreach (int n in numbers)
        {
            sum += n;
            product *= n;
        }

        return new List<int> { sum, product };
    }
}
}

namespace Benchmarks.csharp_1.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// For a given list of integers, return a list consisting of a sum and a product of all the integers in a list.
    /// Empty sum should be equal to 0 and empty product should be equal to 1.
    /// </summary>
    public static List<int> SumProduct(List<int> numbers)
    {
        int sum = 0;
        int product = 1;

        foreach (int n in numbers)
        {
            sum += n;
            product *= n;
        }

        return new List<int> { sum, product };
    }
}
}

namespace Benchmarks.csharp_1.Claude
{
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> SumProduct(List<int> numbers)
    {
        int sum = numbers.Sum();
        int product = numbers.Count == 0 ? 1 : numbers.Aggregate(1, (a, b) => a * b);
        return new List<int> { sum, product };
    }
}
}

namespace Benchmarks.csharp_1.Grok
{
using System.Collections.Generic;

public class Solver
{
    public static List<int> SumProduct (List<int> numbers) 
    {
        int sum = 0;
        int product = 1;
        foreach (int num in numbers)
        {
            sum += num;
            product *= num;
        }
        return new List<int> { sum, product };
    }
}
}

namespace Benchmarks.csharp_1.Mistral
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static (int sum, int product) SumProduct(List<int> numbers)
    {
        int sum = numbers.Sum();
        int product = numbers.Aggregate(1, (acc, val) => acc * val);
        return (sum, product);
    }
}
}

namespace Benchmarks.csharp_1.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<int> SumProduct(List<int> numbers)
    {
        int sum = 0;
        int product = 1;
        
        if (numbers == null || numbers.Count == 0)
        {
            return new List<int> { sum, product };
        }
        
        sum = numbers.Sum();
        product = numbers.Aggregate(1, (acc, val) => acc * val);
        
        return new List<int> { sum, product };
    }
}
}

namespace Benchmarks.csharp_1.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver 
{
    public static List<int> SumProduct(List<int> numbers) 
    {
        long sum = 0;
        long product = 1;
        foreach (var number in numbers) 
        {
            sum += number;
            product *= number;
        }
        return new List<int> { (int)sum, (int)product };
    }
}
}
