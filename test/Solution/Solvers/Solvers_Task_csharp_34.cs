// Auto-generated Solvers for Task: csharp_34
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Benchmarks.csharp_34.GPT
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> NumericalLetterGrade(List<object> grades)
    {
        var result = new List<string>();

        foreach (var g in grades)
        {
            double grade = Convert.ToDouble(g);

            if (grade == 4.0)
                result.Add("A+");
            else if (grade > 3.7)
                result.Add("A");
            else if (grade > 3.3)
                result.Add("A-");
            else if (grade > 3.0)
                result.Add("B+");
            else if (grade > 2.7)
                result.Add("B");
            else if (grade > 2.3)
                result.Add("B-");
            else if (grade > 2.0)
                result.Add("C+");
            else if (grade > 1.7)
                result.Add("C");
            else if (grade > 1.3)
                result.Add("C-");
            else if (grade > 1.0)
                result.Add("D+");
            else if (grade > 0.7)
                result.Add("D");
            else if (grade > 0.0)
                result.Add("D-");
            else
                result.Add("E");
        }

        return result;
    }
}
}

namespace Benchmarks.csharp_34.Gemini
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    /// <summary> 
    /// Converts a list of numerical GPAs into letter grades based on a specific grading scale.
    /// </summary>
    public static List<string> NumericalLetterGrade(List<object> grades)
    {
        List<string> letterGrades = new List<string>();

        foreach (var gradeObj in grades)
        {
            double g = Convert.ToDouble(gradeObj);

            if (g >= 4.0)
            {
                letterGrades.Add("A+");
            }
            else if (g > 3.7)
            {
                letterGrades.Add("A");
            }
            else if (g > 3.3)
            {
                letterGrades.Add("A-");
            }
            else if (g > 3.0)
            {
                letterGrades.Add("B+");
            }
            else if (g > 2.7)
            {
                letterGrades.Add("B");
            }
            else if (g > 2.3)
            {
                letterGrades.Add("B-");
            }
            else if (g > 2.0)
            {
                letterGrades.Add("C+");
            }
            else if (g > 1.7)
            {
                letterGrades.Add("C");
            }
            else if (g > 1.3)
            {
                letterGrades.Add("C-");
            }
            else if (g > 1.0)
            {
                letterGrades.Add("D+");
            }
            else if (g > 0.7)
            {
                letterGrades.Add("D");
            }
            else if (g > 0.0)
            {
                letterGrades.Add("D-");
            }
            else
            {
                letterGrades.Add("E");
            }
        }

        return letterGrades;
    }
}
}

namespace Benchmarks.csharp_34.Claude
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<string> NumericalLetterGrade(List<object> grades)
    {
        var result = new List<string>();
        foreach (var g in grades)
        {
            double gpa = Convert.ToDouble(g);
            string grade;
            if (gpa == 4.0) grade = "A+";
            else if (gpa > 3.7) grade = "A";
            else if (gpa > 3.3) grade = "A-";
            else if (gpa > 3.0) grade = "B+";
            else if (gpa > 2.7) grade = "B";
            else if (gpa > 2.3) grade = "B-";
            else if (gpa > 2.0) grade = "C+";
            else if (gpa > 1.7) grade = "C";
            else if (gpa > 1.3) grade = "C-";
            else if (gpa > 1.0) grade = "D+";
            else if (gpa > 0.7) grade = "D";
            else if (gpa > 0.0) grade = "D-";
            else grade = "E";
            result.Add(grade);
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_34.Grok
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<string> NumericalLetterGrade(List<object> grades)
    {
        List<string> result = new List<string>();
        foreach (object o in grades)
        {
            double gpa = Convert.ToDouble(o);
            string grade;
            if (gpa == 4.0)
            {
                grade = "A+";
            }
            else if (gpa > 3.7)
            {
                grade = "A";
            }
            else if (gpa > 3.3)
            {
                grade = "A-";
            }
            else if (gpa > 3.0)
            {
                grade = "B+";
            }
            else if (gpa > 2.7)
            {
                grade = "B";
            }
            else if (gpa > 2.3)
            {
                grade = "B-";
            }
            else if (gpa > 2.0)
            {
                grade = "C+";
            }
            else if (gpa > 1.7)
            {
                grade = "C";
            }
            else if (gpa > 1.3)
            {
                grade = "C-";
            }
            else if (gpa > 1.0)
            {
                grade = "D+";
            }
            else if (gpa > 0.7)
            {
                grade = "D";
            }
            else if (gpa > 0.0)
            {
                grade = "D-";
            }
            else
            {
                grade = "E";
            }
            result.Add(grade);
        }
        return result;
    }
}
}

namespace Benchmarks.csharp_34.Mistral
{
using System;
using System.Collections.Generic;

public class Solver
{
    public static List<string> NumericalLetterGrade(List<object> grades)
    {
        List<string> letterGrades = new List<string>();
        foreach (object gradeObj in grades)
        {
            double grade = Convert.ToDouble(gradeObj);
            if (grade == 4.0)
                letterGrades.Add("A+");
            else if (grade > 3.7)
                letterGrades.Add("A");
            else if (grade > 3.3)
                letterGrades.Add("A-");
            else if (grade > 3.0)
                letterGrades.Add("B+");
            else if (grade > 2.7)
                letterGrades.Add("B");
            else if (grade > 2.3)
                letterGrades.Add("B-");
            else if (grade > 2.0)
                letterGrades.Add("C+");
            else if (grade > 1.7)
                letterGrades.Add("C");
            else if (grade > 1.3)
                letterGrades.Add("C-");
            else if (grade > 1.0)
                letterGrades.Add("D+");
            else if (grade > 0.7)
                letterGrades.Add("D");
            else if (grade > 0.0)
                letterGrades.Add("D-");
            else
                letterGrades.Add("E");
        }
        return letterGrades;
    }
}
}

namespace Benchmarks.csharp_34.DeepSeek
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> NumericalLetterGrade(List<object> grades)
    {
        List<string> result = new List<string>();
        
        foreach (object gradeObj in grades)
        {
            double gpa = Convert.ToDouble(gradeObj);
            string letterGrade = "";
            
            if (gpa == 4.0)
                letterGrade = "A+";
            else if (gpa > 3.7)
                letterGrade = "A";
            else if (gpa > 3.3)
                letterGrade = "A-";
            else if (gpa > 3.0)
                letterGrade = "B+";
            else if (gpa > 2.7)
                letterGrade = "B";
            else if (gpa > 2.3)
                letterGrade = "B-";
            else if (gpa > 2.0)
                letterGrade = "C+";
            else if (gpa > 1.7)
                letterGrade = "C";
            else if (gpa > 1.3)
                letterGrade = "C-";
            else if (gpa > 1.0)
                letterGrade = "D+";
            else if (gpa > 0.7)
                letterGrade = "D";
            else if (gpa > 0.0)
                letterGrade = "D-";
            else if (gpa == 0.0)
                letterGrade = "E";
            
            result.Add(letterGrade);
        }
        
        return result;
    }
}
}

namespace Benchmarks.csharp_34.Llama
{
using System;
using System.Collections.Generic;
using System.Linq;

public class Solver
{
    public static List<string> NumericalLetterGrade(List<object> grades)
    {
        return grades.Select(gpa => Convert.ToDouble(gpa)).Select(MapGpaToGrade).ToList();
    }

    private static string MapGpaToGrade(double gpa)
    {
        if (gpa == 4.0) return "A+";
        if (gpa > 3.7) return "A";
        if (gpa > 3.3) return "A-";
        if (gpa > 3.0) return "B+";
        if (gpa > 2.7) return "B";
        if (gpa > 2.3) return "B-";
        if (gpa > 2.0) return "C+";
        if (gpa > 1.7) return "C";
        if (gpa > 1.3) return "C-";
        if (gpa > 1.0) return "D+";
        if (gpa > 0.7) return "D";
        if (gpa > 0.0) return "D-";
        return "E";
    }
}
}
