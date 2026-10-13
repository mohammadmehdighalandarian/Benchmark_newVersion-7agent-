// Auto-generated Solvers for Task: csharp_32

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_32.GPT
{
    using System;

    public class Solver
    {
        public static string DecimalToBinary(int @decimal)
        {
            string binary = Convert.ToString(@decimal, 2);
            return "db" + binary + "db";
        }
    }
}

namespace Benchmarks.csharp_32.Gemini
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static string DecimalToBinary(int @decimal)
        {
            string binary = Convert.ToString(@decimal, 2);
            return $"db{binary}db";
        }
    }
}

namespace Benchmarks.csharp_32.Claude
{
    using System;

    public class Solver
    {
        public static string DecimalToBinary(int @decimal)
        {
            return "db" + Convert.ToString(@decimal, 2) + "db";
        }
    }
}

namespace Benchmarks.csharp_32.Grok
{
    using System;

    public class Solver
    {
        public static string DecimalToBinary(int @decimal)
        {
            return "db" + Convert.ToString(@decimal, 2) + "db";
        }
    }
}

namespace Benchmarks.csharp_32.Mistral
{
    using System;

    public class Solver
    {
        public static string DecimalToBinary(int decimalNumber)
        {
            string binary = Convert.ToString(decimalNumber, 2);
            return $"db{binary}db";
        }
    }
}

namespace Benchmarks.csharp_32.DeepSeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Solver
    {
        public static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return "db0db";
            }

            string binary = Convert.ToString(decimalNumber, 2);
            return "db" + binary + "db";
        }
    }
}

namespace Benchmarks.csharp_32.Llama
{
    using System;

    public class Solver
    {
        public static string DecimalToBinary(int decimalNumber)
        {
            return "db" + Convert.ToString(decimalNumber, 2) +"db";
        }
    }
}