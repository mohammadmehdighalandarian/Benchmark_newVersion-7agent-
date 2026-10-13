// Auto-generated Solvers for Task: csharp_60

namespace Benchmarks.csharp_60.GPT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static int SumSquares(List<object> lst)
        {
            int sum = 0;

            foreach (var item in lst)
            {
                double val = Convert.ToDouble(item);
                int ceiled = (int)Math.Ceiling(val);
                sum += ceiled * ceiled;
            }

            return sum;
        }
    }
}

namespace Benchmarks.csharp_60.Gemini
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        /// <summary> 
        /// Returns the sum of squared numbers in the given list, 
        /// rounding each element to the upper integer (Ceiling) first.
        /// </summary>
        public static int SumSquares(List<object> lst)
        {
            return lst.Select(x =>
            {
                double val = Convert.ToDouble(x);
                int ceilingVal = (int)Math.Ceiling(val);
                return ceilingVal * ceilingVal;
            }).Sum();
        }
    }
}

namespace Benchmarks.csharp_60.Claude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static int SumSquares(List<object> lst)
        {
            return lst.Sum(x =>
            {
                double val = Convert.ToDouble(x);
                int ceiled = (int)Math.Ceiling(val);
                return ceiled * ceiled;
            });
        }
    }
}


namespace Benchmarks.csharp_60.Grok
{
    using System;
    using System.Collections.Generic;

    public class Solver
    {
        public static int SumSquares(List<object> lst)
        {
            int sum = 0;
            foreach (object obj in lst)
            {
                double num = Convert.ToDouble(obj);
                double ceiled = Math.Ceiling(num);
                int ceiledInt = (int)ceiled;
                sum += ceiledInt * ceiledInt;
            }

            return sum;
        }
    }
}

namespace Benchmarks.csharp_60.Mistral
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static int SumSquares(List<object> lst)
        {
            return lst.Select(x => (int)Math.Ceiling(Convert.ToDouble(x)))
                .Select(x => x * x)
                .Sum();
        }
    }
}

namespace Benchmarks.csharp_60.DeepSeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static int SumSquares(List<object> lst)
        {
            int sum = 0;
            foreach (object item in lst)
            {
                double number = Convert.ToDouble(item);
                int ceiling = (int)Math.Ceiling(number);
                sum += ceiling * ceiling;
            }

            return sum;
        }
    }
}

namespace Benchmarks.csharp_60.Llama
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static int SumSquares(List<object> lst)
        {
            return lst.Select(x => (int)Math.Ceiling(Convert.ToDouble(x))).Select(y => y * y).Sum();
        }
    }
}