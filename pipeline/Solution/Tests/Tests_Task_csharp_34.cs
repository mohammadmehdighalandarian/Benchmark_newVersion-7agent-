// Auto-generated Tests for Task: csharp_34
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_34
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_34.GPT.Solver.NumericalLetterGrade(new List<object> {4.0,3,1.7,2,3.5});
            var expected1 = new List<string> {"A+","B","C-","C","A-"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_34.GPT.Solver.NumericalLetterGrade(new List<object> {1.2});
            var expected2 = new List<string> {"D+"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_34.GPT.Solver.NumericalLetterGrade(new List<object> {0.5});
            var expected3 = new List<string> {"D-"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_34.GPT.Solver.NumericalLetterGrade(new List<object> {0.0});
            var expected4 = new List<string> {"E"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_34.GPT.Solver.NumericalLetterGrade(new List<object> {1,0.3,1.5,2.8,3.3});
            var expected5 = new List<string> {"D","D-","C-","B","B+"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_34.GPT.Solver.NumericalLetterGrade(new List<object> {0,0.7});
            var expected6 = new List<string> {"E","D-"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_34.Gemini.Solver.NumericalLetterGrade(new List<object> {4.0,3,1.7,2,3.5});
            var expected1 = new List<string> {"A+","B","C-","C","A-"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_34.Gemini.Solver.NumericalLetterGrade(new List<object> {1.2});
            var expected2 = new List<string> {"D+"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_34.Gemini.Solver.NumericalLetterGrade(new List<object> {0.5});
            var expected3 = new List<string> {"D-"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_34.Gemini.Solver.NumericalLetterGrade(new List<object> {0.0});
            var expected4 = new List<string> {"E"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_34.Gemini.Solver.NumericalLetterGrade(new List<object> {1,0.3,1.5,2.8,3.3});
            var expected5 = new List<string> {"D","D-","C-","B","B+"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_34.Gemini.Solver.NumericalLetterGrade(new List<object> {0,0.7});
            var expected6 = new List<string> {"E","D-"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_34.Claude.Solver.NumericalLetterGrade(new List<object> {4.0,3,1.7,2,3.5});
            var expected1 = new List<string> {"A+","B","C-","C","A-"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_34.Claude.Solver.NumericalLetterGrade(new List<object> {1.2});
            var expected2 = new List<string> {"D+"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_34.Claude.Solver.NumericalLetterGrade(new List<object> {0.5});
            var expected3 = new List<string> {"D-"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_34.Claude.Solver.NumericalLetterGrade(new List<object> {0.0});
            var expected4 = new List<string> {"E"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_34.Claude.Solver.NumericalLetterGrade(new List<object> {1,0.3,1.5,2.8,3.3});
            var expected5 = new List<string> {"D","D-","C-","B","B+"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_34.Claude.Solver.NumericalLetterGrade(new List<object> {0,0.7});
            var expected6 = new List<string> {"E","D-"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_34.Grok.Solver.NumericalLetterGrade(new List<object> {4.0,3,1.7,2,3.5});
            var expected1 = new List<string> {"A+","B","C-","C","A-"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_34.Grok.Solver.NumericalLetterGrade(new List<object> {1.2});
            var expected2 = new List<string> {"D+"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_34.Grok.Solver.NumericalLetterGrade(new List<object> {0.5});
            var expected3 = new List<string> {"D-"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_34.Grok.Solver.NumericalLetterGrade(new List<object> {0.0});
            var expected4 = new List<string> {"E"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_34.Grok.Solver.NumericalLetterGrade(new List<object> {1,0.3,1.5,2.8,3.3});
            var expected5 = new List<string> {"D","D-","C-","B","B+"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_34.Grok.Solver.NumericalLetterGrade(new List<object> {0,0.7});
            var expected6 = new List<string> {"E","D-"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_34.Mistral.Solver.NumericalLetterGrade(new List<object> {4.0,3,1.7,2,3.5});
            var expected1 = new List<string> {"A+","B","C-","C","A-"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_34.Mistral.Solver.NumericalLetterGrade(new List<object> {1.2});
            var expected2 = new List<string> {"D+"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_34.Mistral.Solver.NumericalLetterGrade(new List<object> {0.5});
            var expected3 = new List<string> {"D-"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_34.Mistral.Solver.NumericalLetterGrade(new List<object> {0.0});
            var expected4 = new List<string> {"E"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_34.Mistral.Solver.NumericalLetterGrade(new List<object> {1,0.3,1.5,2.8,3.3});
            var expected5 = new List<string> {"D","D-","C-","B","B+"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_34.Mistral.Solver.NumericalLetterGrade(new List<object> {0,0.7});
            var expected6 = new List<string> {"E","D-"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_34.DeepSeek.Solver.NumericalLetterGrade(new List<object> {4.0,3,1.7,2,3.5});
            var expected1 = new List<string> {"A+","B","C-","C","A-"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_34.DeepSeek.Solver.NumericalLetterGrade(new List<object> {1.2});
            var expected2 = new List<string> {"D+"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_34.DeepSeek.Solver.NumericalLetterGrade(new List<object> {0.5});
            var expected3 = new List<string> {"D-"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_34.DeepSeek.Solver.NumericalLetterGrade(new List<object> {0.0});
            var expected4 = new List<string> {"E"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_34.DeepSeek.Solver.NumericalLetterGrade(new List<object> {1,0.3,1.5,2.8,3.3});
            var expected5 = new List<string> {"D","D-","C-","B","B+"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_34.DeepSeek.Solver.NumericalLetterGrade(new List<object> {0,0.7});
            var expected6 = new List<string> {"E","D-"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_34.Llama.Solver.NumericalLetterGrade(new List<object> {4.0,3,1.7,2,3.5});
            var expected1 = new List<string> {"A+","B","C-","C","A-"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_34.Llama.Solver.NumericalLetterGrade(new List<object> {1.2});
            var expected2 = new List<string> {"D+"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_34.Llama.Solver.NumericalLetterGrade(new List<object> {0.5});
            var expected3 = new List<string> {"D-"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_34.Llama.Solver.NumericalLetterGrade(new List<object> {0.0});
            var expected4 = new List<string> {"E"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_34.Llama.Solver.NumericalLetterGrade(new List<object> {1,0.3,1.5,2.8,3.3});
            var expected5 = new List<string> {"D","D-","C-","B","B+"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_34.Llama.Solver.NumericalLetterGrade(new List<object> {0,0.7});
            var expected6 = new List<string> {"E","D-"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
