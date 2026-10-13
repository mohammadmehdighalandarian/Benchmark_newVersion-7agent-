// Auto-generated Tests for Task: csharp_47
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_47
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_47.GPT.Solver.F(5);
            var expected1 = new List<int> {1,2,6,24,15};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_47.GPT.Solver.F(7);
            var expected2 = new List<int> {1,2,6,24,15,720,28};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_47.GPT.Solver.F(1);
            var expected3 = new List<int> {1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_47.GPT.Solver.F(3);
            var expected4 = new List<int> {1,2,6};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_47.Gemini.Solver.F(5);
            var expected1 = new List<int> {1,2,6,24,15};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_47.Gemini.Solver.F(7);
            var expected2 = new List<int> {1,2,6,24,15,720,28};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_47.Gemini.Solver.F(1);
            var expected3 = new List<int> {1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_47.Gemini.Solver.F(3);
            var expected4 = new List<int> {1,2,6};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_47.Claude.Solver.F(5);
            var expected1 = new List<int> {1,2,6,24,15};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_47.Claude.Solver.F(7);
            var expected2 = new List<int> {1,2,6,24,15,720,28};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_47.Claude.Solver.F(1);
            var expected3 = new List<int> {1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_47.Claude.Solver.F(3);
            var expected4 = new List<int> {1,2,6};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_47.Grok.Solver.F(5);
            var expected1 = new List<int> {1,2,6,24,15};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_47.Grok.Solver.F(7);
            var expected2 = new List<int> {1,2,6,24,15,720,28};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_47.Grok.Solver.F(1);
            var expected3 = new List<int> {1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_47.Grok.Solver.F(3);
            var expected4 = new List<int> {1,2,6};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_47.Mistral.Solver.F(5);
            var expected1 = new List<int> {1,2,6,24,15};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_47.Mistral.Solver.F(7);
            var expected2 = new List<int> {1,2,6,24,15,720,28};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_47.Mistral.Solver.F(1);
            var expected3 = new List<int> {1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_47.Mistral.Solver.F(3);
            var expected4 = new List<int> {1,2,6};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_47.DeepSeek.Solver.F(5);
            var expected1 = new List<int> {1,2,6,24,15};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_47.DeepSeek.Solver.F(7);
            var expected2 = new List<int> {1,2,6,24,15,720,28};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_47.DeepSeek.Solver.F(1);
            var expected3 = new List<int> {1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_47.DeepSeek.Solver.F(3);
            var expected4 = new List<int> {1,2,6};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_47.Llama.Solver.F(5);
            var expected1 = new List<int> {1,2,6,24,15};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_47.Llama.Solver.F(7);
            var expected2 = new List<int> {1,2,6,24,15,720,28};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_47.Llama.Solver.F(1);
            var expected3 = new List<int> {1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_47.Llama.Solver.F(3);
            var expected4 = new List<int> {1,2,6};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
