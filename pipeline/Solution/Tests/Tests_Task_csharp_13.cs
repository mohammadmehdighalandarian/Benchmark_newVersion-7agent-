// Auto-generated Tests for Task: csharp_13
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_13
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {1,3,5,0});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {1,3,-2,1});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {1,2,3,7});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {2,4,-5,3,5,7});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {1});
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,30});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,31});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,30});
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,31});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {1,3,5,0});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {1,3,-2,1});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {1,2,3,7});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {2,4,-5,3,5,7});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {1});
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,30});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,31});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,30});
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,31});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {1,3,5,0});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {1,3,-2,1});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {1,2,3,7});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {2,4,-5,3,5,7});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {1});
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,30});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,31});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,30});
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,31});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {1,3,5,0});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {1,3,-2,1});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {1,2,3,7});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {2,4,-5,3,5,7});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {1});
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,30});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,31});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,30});
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,31});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {1,3,5,0});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {1,3,-2,1});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {1,2,3,7});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {2,4,-5,3,5,7});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {1});
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,30});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,31});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,30});
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,31});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {1,3,5,0});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {1,3,-2,1});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {1,2,3,7});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {2,4,-5,3,5,7});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {1});
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,30});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,31});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,30});
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,31});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {1,3,5,0});
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {1,3,-2,1});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {1,2,3,7});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {2,4,-5,3,5,7});
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {1});
            var expected5 = false;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,30});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {-3,9,-1,3,2,31});
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,30});
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(new List<int> {-3,9,-1,4,2,31});
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
