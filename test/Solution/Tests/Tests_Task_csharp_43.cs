// Auto-generated Tests for Task: csharp_43
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_43
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_43.GPT.Solver.MakeAPile(3);
            var expected1 = new List<int> {3,5,7};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_43.GPT.Solver.MakeAPile(4);
            var expected2 = new List<int> {4,6,8,10};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_43.GPT.Solver.MakeAPile(5);
            var expected3 = new List<int> {5,7,9,11,13};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_43.GPT.Solver.MakeAPile(6);
            var expected4 = new List<int> {6,8,10,12,14,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_43.GPT.Solver.MakeAPile(8);
            var expected5 = new List<int> {8,10,12,14,16,18,20,22};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_43.Gemini.Solver.MakeAPile(3);
            var expected1 = new List<int> {3,5,7};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_43.Gemini.Solver.MakeAPile(4);
            var expected2 = new List<int> {4,6,8,10};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_43.Gemini.Solver.MakeAPile(5);
            var expected3 = new List<int> {5,7,9,11,13};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_43.Gemini.Solver.MakeAPile(6);
            var expected4 = new List<int> {6,8,10,12,14,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_43.Gemini.Solver.MakeAPile(8);
            var expected5 = new List<int> {8,10,12,14,16,18,20,22};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_43.Claude.Solver.MakeAPile(3);
            var expected1 = new List<int> {3,5,7};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_43.Claude.Solver.MakeAPile(4);
            var expected2 = new List<int> {4,6,8,10};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_43.Claude.Solver.MakeAPile(5);
            var expected3 = new List<int> {5,7,9,11,13};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_43.Claude.Solver.MakeAPile(6);
            var expected4 = new List<int> {6,8,10,12,14,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_43.Claude.Solver.MakeAPile(8);
            var expected5 = new List<int> {8,10,12,14,16,18,20,22};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_43.Grok.Solver.MakeAPile(3);
            var expected1 = new List<int> {3,5,7};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_43.Grok.Solver.MakeAPile(4);
            var expected2 = new List<int> {4,6,8,10};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_43.Grok.Solver.MakeAPile(5);
            var expected3 = new List<int> {5,7,9,11,13};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_43.Grok.Solver.MakeAPile(6);
            var expected4 = new List<int> {6,8,10,12,14,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_43.Grok.Solver.MakeAPile(8);
            var expected5 = new List<int> {8,10,12,14,16,18,20,22};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_43.Mistral.Solver.MakeAPile(3);
            var expected1 = new List<int> {3,5,7};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_43.Mistral.Solver.MakeAPile(4);
            var expected2 = new List<int> {4,6,8,10};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_43.Mistral.Solver.MakeAPile(5);
            var expected3 = new List<int> {5,7,9,11,13};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_43.Mistral.Solver.MakeAPile(6);
            var expected4 = new List<int> {6,8,10,12,14,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_43.Mistral.Solver.MakeAPile(8);
            var expected5 = new List<int> {8,10,12,14,16,18,20,22};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_43.DeepSeek.Solver.MakeAPile(3);
            var expected1 = new List<int> {3,5,7};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_43.DeepSeek.Solver.MakeAPile(4);
            var expected2 = new List<int> {4,6,8,10};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_43.DeepSeek.Solver.MakeAPile(5);
            var expected3 = new List<int> {5,7,9,11,13};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_43.DeepSeek.Solver.MakeAPile(6);
            var expected4 = new List<int> {6,8,10,12,14,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_43.DeepSeek.Solver.MakeAPile(8);
            var expected5 = new List<int> {8,10,12,14,16,18,20,22};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_43.Llama.Solver.MakeAPile(3);
            var expected1 = new List<int> {3,5,7};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_43.Llama.Solver.MakeAPile(4);
            var expected2 = new List<int> {4,6,8,10};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_43.Llama.Solver.MakeAPile(5);
            var expected3 = new List<int> {5,7,9,11,13};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_43.Llama.Solver.MakeAPile(6);
            var expected4 = new List<int> {6,8,10,12,14,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_43.Llama.Solver.MakeAPile(8);
            var expected5 = new List<int> {8,10,12,14,16,18,20,22};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
