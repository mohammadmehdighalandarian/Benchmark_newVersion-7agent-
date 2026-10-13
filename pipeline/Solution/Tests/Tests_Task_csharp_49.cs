// Auto-generated Tests for Task: csharp_49
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_49
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_49.GPT.Solver.MoveOneBall(new List<int> {3,4,5,1,2});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_49.GPT.Solver.MoveOneBall(new List<int> {3,5,10,1,2});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_49.GPT.Solver.MoveOneBall(new List<int> {4,3,1,2});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_49.GPT.Solver.MoveOneBall(new List<int> {3,5,4,1,2});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_49.GPT.Solver.MoveOneBall(new List<int> {});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_49.Gemini.Solver.MoveOneBall(new List<int> {3,4,5,1,2});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_49.Gemini.Solver.MoveOneBall(new List<int> {3,5,10,1,2});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_49.Gemini.Solver.MoveOneBall(new List<int> {4,3,1,2});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_49.Gemini.Solver.MoveOneBall(new List<int> {3,5,4,1,2});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_49.Gemini.Solver.MoveOneBall(new List<int> {});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_49.Claude.Solver.MoveOneBall(new List<int> {3,4,5,1,2});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_49.Claude.Solver.MoveOneBall(new List<int> {3,5,10,1,2});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_49.Claude.Solver.MoveOneBall(new List<int> {4,3,1,2});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_49.Claude.Solver.MoveOneBall(new List<int> {3,5,4,1,2});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_49.Claude.Solver.MoveOneBall(new List<int> {});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_49.Grok.Solver.MoveOneBall(new List<int> {3,4,5,1,2});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_49.Grok.Solver.MoveOneBall(new List<int> {3,5,10,1,2});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_49.Grok.Solver.MoveOneBall(new List<int> {4,3,1,2});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_49.Grok.Solver.MoveOneBall(new List<int> {3,5,4,1,2});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_49.Grok.Solver.MoveOneBall(new List<int> {});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_49.Mistral.Solver.MoveOneBall(new List<int> {3,4,5,1,2});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_49.Mistral.Solver.MoveOneBall(new List<int> {3,5,10,1,2});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_49.Mistral.Solver.MoveOneBall(new List<int> {4,3,1,2});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_49.Mistral.Solver.MoveOneBall(new List<int> {3,5,4,1,2});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_49.Mistral.Solver.MoveOneBall(new List<int> {});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_49.DeepSeek.Solver.MoveOneBall(new List<int> {3,4,5,1,2});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_49.DeepSeek.Solver.MoveOneBall(new List<int> {3,5,10,1,2});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_49.DeepSeek.Solver.MoveOneBall(new List<int> {4,3,1,2});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_49.DeepSeek.Solver.MoveOneBall(new List<int> {3,5,4,1,2});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_49.DeepSeek.Solver.MoveOneBall(new List<int> {});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_49.Llama.Solver.MoveOneBall(new List<int> {3,4,5,1,2});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_49.Llama.Solver.MoveOneBall(new List<int> {3,5,10,1,2});
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_49.Llama.Solver.MoveOneBall(new List<int> {4,3,1,2});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_49.Llama.Solver.MoveOneBall(new List<int> {3,5,4,1,2});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_49.Llama.Solver.MoveOneBall(new List<int> {});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
