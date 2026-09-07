// Auto-generated Tests for Task: csharp_8
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_8
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_8.GPT.Solver.GetPositive(new List<int> {-1,-2,4,5,6});
            var expected1 = new List<int> {4,5,6};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_8.GPT.Solver.GetPositive(new List<int> {5,3,-5,2,3,3,9,0,123,1,-10});
            var expected2 = new List<int> {5,3,2,3,3,9,123,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_8.GPT.Solver.GetPositive(new List<int> {-1,-2});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_8.GPT.Solver.GetPositive(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_8.Gemini.Solver.GetPositive(new List<int> {-1,-2,4,5,6});
            var expected1 = new List<int> {4,5,6};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_8.Gemini.Solver.GetPositive(new List<int> {5,3,-5,2,3,3,9,0,123,1,-10});
            var expected2 = new List<int> {5,3,2,3,3,9,123,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_8.Gemini.Solver.GetPositive(new List<int> {-1,-2});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_8.Gemini.Solver.GetPositive(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_8.Claude.Solver.GetPositive(new List<int> {-1,-2,4,5,6});
            var expected1 = new List<int> {4,5,6};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_8.Claude.Solver.GetPositive(new List<int> {5,3,-5,2,3,3,9,0,123,1,-10});
            var expected2 = new List<int> {5,3,2,3,3,9,123,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_8.Claude.Solver.GetPositive(new List<int> {-1,-2});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_8.Claude.Solver.GetPositive(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_8.Grok.Solver.GetPositive(new List<int> {-1,-2,4,5,6});
            var expected1 = new List<int> {4,5,6};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_8.Grok.Solver.GetPositive(new List<int> {5,3,-5,2,3,3,9,0,123,1,-10});
            var expected2 = new List<int> {5,3,2,3,3,9,123,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_8.Grok.Solver.GetPositive(new List<int> {-1,-2});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_8.Grok.Solver.GetPositive(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_8.Mistral.Solver.GetPositive(new List<int> {-1,-2,4,5,6});
            var expected1 = new List<int> {4,5,6};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_8.Mistral.Solver.GetPositive(new List<int> {5,3,-5,2,3,3,9,0,123,1,-10});
            var expected2 = new List<int> {5,3,2,3,3,9,123,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_8.Mistral.Solver.GetPositive(new List<int> {-1,-2});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_8.Mistral.Solver.GetPositive(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_8.DeepSeek.Solver.GetPositive(new List<int> {-1,-2,4,5,6});
            var expected1 = new List<int> {4,5,6};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_8.DeepSeek.Solver.GetPositive(new List<int> {5,3,-5,2,3,3,9,0,123,1,-10});
            var expected2 = new List<int> {5,3,2,3,3,9,123,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_8.DeepSeek.Solver.GetPositive(new List<int> {-1,-2});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_8.DeepSeek.Solver.GetPositive(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_8.Llama.Solver.GetPositive(new List<int> {-1,-2,4,5,6});
            var expected1 = new List<int> {4,5,6};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_8.Llama.Solver.GetPositive(new List<int> {5,3,-5,2,3,3,9,0,123,1,-10});
            var expected2 = new List<int> {5,3,2,3,3,9,123,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_8.Llama.Solver.GetPositive(new List<int> {-1,-2});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_8.Llama.Solver.GetPositive(new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
