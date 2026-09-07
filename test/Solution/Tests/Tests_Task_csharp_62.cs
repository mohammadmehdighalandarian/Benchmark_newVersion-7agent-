// Auto-generated Tests for Task: csharp_62
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_62
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_62.GPT.Solver.CanArrange(new List<int> {1,2,4,3,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_62.GPT.Solver.CanArrange(new List<int> {1,2,4,5});
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_62.GPT.Solver.CanArrange(new List<int> {1,4,2,5,6,7,8,9,10});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_62.GPT.Solver.CanArrange(new List<int> {4,8,5,7,3});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_62.GPT.Solver.CanArrange(new List<int> {});
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_62.Gemini.Solver.CanArrange(new List<int> {1,2,4,3,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_62.Gemini.Solver.CanArrange(new List<int> {1,2,4,5});
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_62.Gemini.Solver.CanArrange(new List<int> {1,4,2,5,6,7,8,9,10});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_62.Gemini.Solver.CanArrange(new List<int> {4,8,5,7,3});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_62.Gemini.Solver.CanArrange(new List<int> {});
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_62.Claude.Solver.CanArrange(new List<int> {1,2,4,3,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_62.Claude.Solver.CanArrange(new List<int> {1,2,4,5});
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_62.Claude.Solver.CanArrange(new List<int> {1,4,2,5,6,7,8,9,10});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_62.Claude.Solver.CanArrange(new List<int> {4,8,5,7,3});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_62.Claude.Solver.CanArrange(new List<int> {});
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_62.Grok.Solver.CanArrange(new List<int> {1,2,4,3,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_62.Grok.Solver.CanArrange(new List<int> {1,2,4,5});
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_62.Grok.Solver.CanArrange(new List<int> {1,4,2,5,6,7,8,9,10});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_62.Grok.Solver.CanArrange(new List<int> {4,8,5,7,3});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_62.Grok.Solver.CanArrange(new List<int> {});
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_62.Mistral.Solver.CanArrange(new List<int> {1,2,4,3,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_62.Mistral.Solver.CanArrange(new List<int> {1,2,4,5});
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_62.Mistral.Solver.CanArrange(new List<int> {1,4,2,5,6,7,8,9,10});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_62.Mistral.Solver.CanArrange(new List<int> {4,8,5,7,3});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_62.Mistral.Solver.CanArrange(new List<int> {});
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_62.DeepSeek.Solver.CanArrange(new List<int> {1,2,4,3,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_62.DeepSeek.Solver.CanArrange(new List<int> {1,2,4,5});
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_62.DeepSeek.Solver.CanArrange(new List<int> {1,4,2,5,6,7,8,9,10});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_62.DeepSeek.Solver.CanArrange(new List<int> {4,8,5,7,3});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_62.DeepSeek.Solver.CanArrange(new List<int> {});
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_62.Llama.Solver.CanArrange(new List<int> {1,2,4,3,5});
            var expected1 = 3;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_62.Llama.Solver.CanArrange(new List<int> {1,2,4,5});
            var expected2 = -1;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_62.Llama.Solver.CanArrange(new List<int> {1,4,2,5,6,7,8,9,10});
            var expected3 = 2;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_62.Llama.Solver.CanArrange(new List<int> {4,8,5,7,3});
            var expected4 = 4;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_62.Llama.Solver.CanArrange(new List<int> {});
            var expected5 = -1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
