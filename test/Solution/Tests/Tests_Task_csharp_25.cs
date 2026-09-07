// Auto-generated Tests for Task: csharp_25
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_25
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_25.GPT.Solver.Derivative(new List<int> {3,1,2,4,5});
            var expected1 = new List<int> {1,4,12,20};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_25.GPT.Solver.Derivative(new List<int> {1,2,3});
            var expected2 = new List<int> {2,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_25.GPT.Solver.Derivative(new List<int> {3,2,1});
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_25.GPT.Solver.Derivative(new List<int> {3,2,1,0,4});
            var expected4 = new List<int> {2,2,0,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_25.GPT.Solver.Derivative(new List<int> {1});
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_25.Gemini.Solver.Derivative(new List<int> {3,1,2,4,5});
            var expected1 = new List<int> {1,4,12,20};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_25.Gemini.Solver.Derivative(new List<int> {1,2,3});
            var expected2 = new List<int> {2,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_25.Gemini.Solver.Derivative(new List<int> {3,2,1});
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_25.Gemini.Solver.Derivative(new List<int> {3,2,1,0,4});
            var expected4 = new List<int> {2,2,0,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_25.Gemini.Solver.Derivative(new List<int> {1});
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_25.Claude.Solver.Derivative(new List<int> {3,1,2,4,5});
            var expected1 = new List<int> {1,4,12,20};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_25.Claude.Solver.Derivative(new List<int> {1,2,3});
            var expected2 = new List<int> {2,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_25.Claude.Solver.Derivative(new List<int> {3,2,1});
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_25.Claude.Solver.Derivative(new List<int> {3,2,1,0,4});
            var expected4 = new List<int> {2,2,0,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_25.Claude.Solver.Derivative(new List<int> {1});
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_25.Grok.Solver.Derivative(new List<int> {3,1,2,4,5});
            var expected1 = new List<int> {1,4,12,20};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_25.Grok.Solver.Derivative(new List<int> {1,2,3});
            var expected2 = new List<int> {2,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_25.Grok.Solver.Derivative(new List<int> {3,2,1});
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_25.Grok.Solver.Derivative(new List<int> {3,2,1,0,4});
            var expected4 = new List<int> {2,2,0,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_25.Grok.Solver.Derivative(new List<int> {1});
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_25.Mistral.Solver.Derivative(new List<int> {3,1,2,4,5});
            var expected1 = new List<int> {1,4,12,20};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_25.Mistral.Solver.Derivative(new List<int> {1,2,3});
            var expected2 = new List<int> {2,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_25.Mistral.Solver.Derivative(new List<int> {3,2,1});
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_25.Mistral.Solver.Derivative(new List<int> {3,2,1,0,4});
            var expected4 = new List<int> {2,2,0,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_25.Mistral.Solver.Derivative(new List<int> {1});
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_25.DeepSeek.Solver.Derivative(new List<int> {3,1,2,4,5});
            var expected1 = new List<int> {1,4,12,20};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_25.DeepSeek.Solver.Derivative(new List<int> {1,2,3});
            var expected2 = new List<int> {2,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_25.DeepSeek.Solver.Derivative(new List<int> {3,2,1});
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_25.DeepSeek.Solver.Derivative(new List<int> {3,2,1,0,4});
            var expected4 = new List<int> {2,2,0,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_25.DeepSeek.Solver.Derivative(new List<int> {1});
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_25.Llama.Solver.Derivative(new List<int> {3,1,2,4,5});
            var expected1 = new List<int> {1,4,12,20};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_25.Llama.Solver.Derivative(new List<int> {1,2,3});
            var expected2 = new List<int> {2,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_25.Llama.Solver.Derivative(new List<int> {3,2,1});
            var expected3 = new List<int> {2,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_25.Llama.Solver.Derivative(new List<int> {3,2,1,0,4});
            var expected4 = new List<int> {2,2,0,16};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_25.Llama.Solver.Derivative(new List<int> {1});
            var expected5 = new List<int> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
