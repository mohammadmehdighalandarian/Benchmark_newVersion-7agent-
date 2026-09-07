// Auto-generated Tests for Task: csharp_38
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_38
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_38.GPT.Solver.NextSmallest(new List<int> {1,2,3,4,5});
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_38.GPT.Solver.NextSmallest(new List<int> {5,1,4,3,2});
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_38.GPT.Solver.NextSmallest(new List<int> {});
            object expected3 = null;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_38.GPT.Solver.NextSmallest(new List<int> {1,1});
            object expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_38.GPT.Solver.NextSmallest(new List<int> {1,1,1,1,0});
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_38.GPT.Solver.NextSmallest(new List<int> {1,1});
            object expected6 = null;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_38.GPT.Solver.NextSmallest(new List<int> {-35,34,12,-45});
            var expected7 = -35;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_38.Gemini.Solver.NextSmallest(new List<int> {1,2,3,4,5});
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_38.Gemini.Solver.NextSmallest(new List<int> {5,1,4,3,2});
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_38.Gemini.Solver.NextSmallest(new List<int> {});
            object expected3 = null;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_38.Gemini.Solver.NextSmallest(new List<int> {1,1});
            object expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_38.Gemini.Solver.NextSmallest(new List<int> {1,1,1,1,0});
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_38.Gemini.Solver.NextSmallest(new List<int> {1,1});
            object expected6 = null;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_38.Gemini.Solver.NextSmallest(new List<int> {-35,34,12,-45});
            var expected7 = -35;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_38.Claude.Solver.NextSmallest(new List<int> {1,2,3,4,5});
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_38.Claude.Solver.NextSmallest(new List<int> {5,1,4,3,2});
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_38.Claude.Solver.NextSmallest(new List<int> {});
            object expected3 = null;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_38.Claude.Solver.NextSmallest(new List<int> {1,1});
            object expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_38.Claude.Solver.NextSmallest(new List<int> {1,1,1,1,0});
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_38.Claude.Solver.NextSmallest(new List<int> {1,1});
            object expected6 = null;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_38.Claude.Solver.NextSmallest(new List<int> {-35,34,12,-45});
            var expected7 = -35;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_38.Grok.Solver.NextSmallest(new List<int> {1,2,3,4,5});
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_38.Grok.Solver.NextSmallest(new List<int> {5,1,4,3,2});
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_38.Grok.Solver.NextSmallest(new List<int> {});
            object expected3 = null;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_38.Grok.Solver.NextSmallest(new List<int> {1,1});
            object expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_38.Grok.Solver.NextSmallest(new List<int> {1,1,1,1,0});
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_38.Grok.Solver.NextSmallest(new List<int> {1,1});
            object expected6 = null;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_38.Grok.Solver.NextSmallest(new List<int> {-35,34,12,-45});
            var expected7 = -35;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_38.Mistral.Solver.NextSmallest(new List<int> {1,2,3,4,5});
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_38.Mistral.Solver.NextSmallest(new List<int> {5,1,4,3,2});
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_38.Mistral.Solver.NextSmallest(new List<int> {});
            object expected3 = null;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_38.Mistral.Solver.NextSmallest(new List<int> {1,1});
            object expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_38.Mistral.Solver.NextSmallest(new List<int> {1,1,1,1,0});
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_38.Mistral.Solver.NextSmallest(new List<int> {1,1});
            object expected6 = null;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_38.Mistral.Solver.NextSmallest(new List<int> {-35,34,12,-45});
            var expected7 = -35;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_38.DeepSeek.Solver.NextSmallest(new List<int> {1,2,3,4,5});
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_38.DeepSeek.Solver.NextSmallest(new List<int> {5,1,4,3,2});
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_38.DeepSeek.Solver.NextSmallest(new List<int> {});
            object expected3 = null;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_38.DeepSeek.Solver.NextSmallest(new List<int> {1,1});
            object expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_38.DeepSeek.Solver.NextSmallest(new List<int> {1,1,1,1,0});
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_38.DeepSeek.Solver.NextSmallest(new List<int> {1,1});
            object expected6 = null;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_38.DeepSeek.Solver.NextSmallest(new List<int> {-35,34,12,-45});
            var expected7 = -35;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_38.Llama.Solver.NextSmallest(new List<int> {1,2,3,4,5});
            var expected1 = 2;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_38.Llama.Solver.NextSmallest(new List<int> {5,1,4,3,2});
            var expected2 = 2;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_38.Llama.Solver.NextSmallest(new List<int> {});
            object expected3 = null;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_38.Llama.Solver.NextSmallest(new List<int> {1,1});
            object expected4 = null;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_38.Llama.Solver.NextSmallest(new List<int> {1,1,1,1,0});
            var expected5 = 1;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_38.Llama.Solver.NextSmallest(new List<int> {1,1});
            object expected6 = null;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_38.Llama.Solver.NextSmallest(new List<int> {-35,34,12,-45});
            var expected7 = -35;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
