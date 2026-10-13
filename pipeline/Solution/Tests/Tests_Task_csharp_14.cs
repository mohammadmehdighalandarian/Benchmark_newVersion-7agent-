// Auto-generated Tests for Task: csharp_14
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_14
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_14.GPT.Solver.Fib4(5);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_14.GPT.Solver.Fib4(8);
            var expected2 = 28;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_14.GPT.Solver.Fib4(10);
            var expected3 = 104;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_14.GPT.Solver.Fib4(12);
            var expected4 = 386;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_14.Gemini.Solver.Fib4(5);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_14.Gemini.Solver.Fib4(8);
            var expected2 = 28;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_14.Gemini.Solver.Fib4(10);
            var expected3 = 104;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_14.Gemini.Solver.Fib4(12);
            var expected4 = 386;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_14.Claude.Solver.Fib4(5);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_14.Claude.Solver.Fib4(8);
            var expected2 = 28;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_14.Claude.Solver.Fib4(10);
            var expected3 = 104;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_14.Claude.Solver.Fib4(12);
            var expected4 = 386;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_14.Grok.Solver.Fib4(5);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_14.Grok.Solver.Fib4(8);
            var expected2 = 28;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_14.Grok.Solver.Fib4(10);
            var expected3 = 104;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_14.Grok.Solver.Fib4(12);
            var expected4 = 386;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_14.Mistral.Solver.Fib4(5);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_14.Mistral.Solver.Fib4(8);
            var expected2 = 28;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_14.Mistral.Solver.Fib4(10);
            var expected3 = 104;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_14.Mistral.Solver.Fib4(12);
            var expected4 = 386;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_14.DeepSeek.Solver.Fib4(5);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_14.DeepSeek.Solver.Fib4(8);
            var expected2 = 28;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_14.DeepSeek.Solver.Fib4(10);
            var expected3 = 104;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_14.DeepSeek.Solver.Fib4(12);
            var expected4 = 386;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_14.Llama.Solver.Fib4(5);
            var expected1 = 4;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_14.Llama.Solver.Fib4(8);
            var expected2 = 28;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_14.Llama.Solver.Fib4(10);
            var expected3 = 104;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_14.Llama.Solver.Fib4(12);
            var expected4 = 386;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
