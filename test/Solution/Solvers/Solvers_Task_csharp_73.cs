// Auto-generated Solvers for Task: csharp_73

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_73.GPT
{
    using System;

    public class Solver
    {
        public static string StrongestExtension(string class_name, List<string> extensions)
        {
            string strongest = extensions[0];
            int bestStrength = Strength(strongest);

            for (int i = 1; i < extensions.Count; i++)
            {
                int currentStrength = Strength(extensions[i]);
                if (currentStrength > bestStrength)
                {
                    bestStrength = currentStrength;
                    strongest = extensions[i];
                }
            }

            return class_name + "." + strongest;
        }

        private static int Strength(string extension)
        {
            int upper = 0;
            int lower = 0;

            foreach (char c in extension)
            {
                if (char.IsUpper(c)) upper++;
                else if (char.IsLower(c)) lower++;
            }

            return upper - lower;
        }
    }
}

namespace Benchmarks.csharp_73.Gemini
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        /// <summary> 
        /// You're an expert C# programmer
        /// You will be given the name of a class (a string) and a list of extensions.
        /// The extensions are to be used to load additional classes to the class. The
        /// strength of the extension is as follows: Let CAP be the number of the uppercase
        /// letters in the extension's name, and let SM be the number of lowercase letters 
        /// in the extension's name, the strength is given by the fraction CAP - SM. 
        /// You should find the strongest extension and return a string in this 
        /// format: ClassName.StrongestExtensionName.
        /// If there are two or more extensions with the same strength, you should
        /// choose the one that comes first in the list.
        /// </summary>
        public static string StrongestExtension(string class_name, List<string> extensions)
        {
            string strongest = extensions[0];
            int maxStrength = int.MinValue;

            foreach (string ext in extensions)
            {
                int cap = 0;
                int sm = 0;

                foreach (char c in ext)
                {
                    if (char.IsUpper(c))
                    {
                        cap++;
                    }
                    else if (char.IsLower(c))
                    {
                        sm++;
                    }
                }

                int currentStrength = cap - sm;

                if (currentStrength > maxStrength)
                {
                    maxStrength = currentStrength;
                    strongest = ext;
                }
            }

            return $"{class_name}.{strongest}";
        }
    }
}

namespace Benchmarks.csharp_73.Claude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static string StrongestExtension(string class_name, List<string> extensions)
        {
            string best = extensions[0];
            int bestStrength = int.MinValue;
            foreach (var ext in extensions)
            {
                int cap = ext.Count(char.IsUpper);
                int sm = ext.Count(char.IsLower);
                int strength = cap - sm;
                if (strength > bestStrength)
                {
                    bestStrength = strength;
                    best = ext;
                }
            }

            return $"{class_name}.{best}";
        }
    }
}

namespace Benchmarks.csharp_73.Grok
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static string StrongestExtension(string class_name, List<string> extensions)
        {
            string bestExt = extensions[0];
            int maxStr = extensions[0].Count(char.IsUpper) - extensions[0].Count(char.IsLower);
            for (int i = 1; i < extensions.Count; i++)
            {
                string ext = extensions[i];
                int strength = ext.Count(char.IsUpper) - ext.Count(char.IsLower);
                if (strength > maxStr)
                {
                    maxStr = strength;
                    bestExt = ext;
                }
            }

            return class_name + "." + bestExt;
        }
    }
}

namespace Benchmarks.csharp_73.Mistral
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static string StrongestExtension(string class_name, List<string> extensions)
        {
            string strongestExtension = extensions[0];
            int maxStrength = CalculateStrength(strongestExtension);

            foreach (var ext in extensions)
            {
                int currentStrength = CalculateStrength(ext);
                if (currentStrength > maxStrength)
                {
                    maxStrength = currentStrength;
                    strongestExtension = ext;
                }
            }

            return $"{class_name}.{strongestExtension}";
        }

        private static int CalculateStrength(string extension)
        {
            int cap = extension.Count(c => char.IsUpper(c));
            int sm = extension.Count(c => char.IsLower(c));
            return cap - sm;
        }
    }
}

namespace Benchmarks.csharp_73.DeepSeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static string StrongestExtension(string class_name, List<string> extensions)
        {
            string strongestExtension = null;
            int maxStrength = int.MinValue;

            foreach (string extension in extensions)
            {
                int cap = extension.Count(c => char.IsUpper(c));
                int sm = extension.Count(c => char.IsLower(c));
                int strength = cap - sm;

                if (strength > maxStrength)
                {
                    maxStrength = strength;
                    strongestExtension = extension;
                }
            }

            return $"{class_name}.{strongestExtension}";
        }
    }
}

namespace Benchmarks.csharp_73.Llama
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solver
    {
        public static string StrongestExtension(string class_name, List<string> extensions)
        {
            int maxStrength = int.MinValue;
            string strongestExtension = null;

            foreach (var extension in extensions)
            {
                int cap = extension.Count(char.IsUpper);
                int sm = extension.Count(char.IsLower);
                int strength = cap - sm;

                if (strength > maxStrength)
                {
                    maxStrength = strength;
                    strongestExtension = extension;
                }
            }

            return $"{class_name}.{strongestExtension}";
        }
    }
}