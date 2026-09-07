// Auto-generated Tests for Task: csharp_55
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_55
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_55.GPT.Solver.AddElements(new List<int> {1,-2,-3,41,57,76,87,88,99},3);
            var expected1 = -4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_55.GPT.Solver.AddElements(new List<int> {111,121,3,4000,5,6},2);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_55.GPT.Solver.AddElements(new List<int> {11,21,3,90,5,6,7,8,9},4);
            var expected3 = 125;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_55.GPT.Solver.AddElements(new List<int> {111,21,3,4000,5,6,7,8,9},4);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_55.GPT.Solver.AddElements(new List<int> {1},1);
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_55.Gemini.Solver.AddElements(new List<int> {1,-2,-3,41,57,76,87,88,99},3);
            var expected1 = -4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_55.Gemini.Solver.AddElements(new List<int> {111,121,3,4000,5,6},2);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_55.Gemini.Solver.AddElements(new List<int> {11,21,3,90,5,6,7,8,9},4);
            var expected3 = 125;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_55.Gemini.Solver.AddElements(new List<int> {111,21,3,4000,5,6,7,8,9},4);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_55.Gemini.Solver.AddElements(new List<int> {1},1);
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_55.Claude.Solver.AddElements(new List<int> {1,-2,-3,41,57,76,87,88,99},3);
            var expected1 = -4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_55.Claude.Solver.AddElements(new List<int> {111,121,3,4000,5,6},2);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_55.Claude.Solver.AddElements(new List<int> {11,21,3,90,5,6,7,8,9},4);
            var expected3 = 125;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_55.Claude.Solver.AddElements(new List<int> {111,21,3,4000,5,6,7,8,9},4);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_55.Claude.Solver.AddElements(new List<int> {1},1);
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_55.Grok.Solver.AddElements(new List<int> {1,-2,-3,41,57,76,87,88,99},3);
            var expected1 = -4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_55.Grok.Solver.AddElements(new List<int> {111,121,3,4000,5,6},2);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_55.Grok.Solver.AddElements(new List<int> {11,21,3,90,5,6,7,8,9},4);
            var expected3 = 125;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_55.Grok.Solver.AddElements(new List<int> {111,21,3,4000,5,6,7,8,9},4);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_55.Grok.Solver.AddElements(new List<int> {1},1);
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_55.Mistral.Solver.AddElements(new List<int> {1,-2,-3,41,57,76,87,88,99},3);
            var expected1 = -4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_55.Mistral.Solver.AddElements(new List<int> {111,121,3,4000,5,6},2);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_55.Mistral.Solver.AddElements(new List<int> {11,21,3,90,5,6,7,8,9},4);
            var expected3 = 125;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_55.Mistral.Solver.AddElements(new List<int> {111,21,3,4000,5,6,7,8,9},4);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_55.Mistral.Solver.AddElements(new List<int> {1},1);
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_55.DeepSeek.Solver.AddElements(new List<int> {1,-2,-3,41,57,76,87,88,99},3);
            var expected1 = -4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_55.DeepSeek.Solver.AddElements(new List<int> {111,121,3,4000,5,6},2);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_55.DeepSeek.Solver.AddElements(new List<int> {11,21,3,90,5,6,7,8,9},4);
            var expected3 = 125;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_55.DeepSeek.Solver.AddElements(new List<int> {111,21,3,4000,5,6,7,8,9},4);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_55.DeepSeek.Solver.AddElements(new List<int> {1},1);
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_55.Llama.Solver.AddElements(new List<int> {1,-2,-3,41,57,76,87,88,99},3);
            var expected1 = -4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_55.Llama.Solver.AddElements(new List<int> {111,121,3,4000,5,6},2);
            var expected2 = 0;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_55.Llama.Solver.AddElements(new List<int> {11,21,3,90,5,6,7,8,9},4);
            var expected3 = 125;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_55.Llama.Solver.AddElements(new List<int> {111,21,3,4000,5,6,7,8,9},4);
            var expected4 = 24;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_55.Llama.Solver.AddElements(new List<int> {1},1);
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
