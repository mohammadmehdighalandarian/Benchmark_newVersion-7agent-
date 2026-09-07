// Auto-generated Tests for Task: csharp_57
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_57
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_57.GPT.Solver.Tri(3);
            var expected1 = new List<object> {1,3,2.0,8.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_57.GPT.Solver.Tri(4);
            var expected2 = new List<object> {1,3,2.0,8.0,3.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_57.GPT.Solver.Tri(5);
            var expected3 = new List<object> {1,3,2.0,8.0,3.0,15.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_57.GPT.Solver.Tri(6);
            var expected4 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_57.GPT.Solver.Tri(7);
            var expected5 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_57.GPT.Solver.Tri(8);
            var expected6 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_57.GPT.Solver.Tri(9);
            var expected7 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_57.GPT.Solver.Tri(20);
            var expected8 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0,6.0,48.0,7.0,63.0,8.0,80.0,9.0,99.0,10.0,120.0,11.0};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_57.GPT.Solver.Tri(0);
            var expected9 = new List<object> {1};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_57.GPT.Solver.Tri(1);
            var expected10 = new List<object> {1,3};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_57.Gemini.Solver.Tri(3);
            var expected1 = new List<object> {1,3,2.0,8.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_57.Gemini.Solver.Tri(4);
            var expected2 = new List<object> {1,3,2.0,8.0,3.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_57.Gemini.Solver.Tri(5);
            var expected3 = new List<object> {1,3,2.0,8.0,3.0,15.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_57.Gemini.Solver.Tri(6);
            var expected4 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_57.Gemini.Solver.Tri(7);
            var expected5 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_57.Gemini.Solver.Tri(8);
            var expected6 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_57.Gemini.Solver.Tri(9);
            var expected7 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_57.Gemini.Solver.Tri(20);
            var expected8 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0,6.0,48.0,7.0,63.0,8.0,80.0,9.0,99.0,10.0,120.0,11.0};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_57.Gemini.Solver.Tri(0);
            var expected9 = new List<object> {1};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_57.Gemini.Solver.Tri(1);
            var expected10 = new List<object> {1,3};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_57.Claude.Solver.Tri(3);
            var expected1 = new List<object> {1,3,2.0,8.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_57.Claude.Solver.Tri(4);
            var expected2 = new List<object> {1,3,2.0,8.0,3.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_57.Claude.Solver.Tri(5);
            var expected3 = new List<object> {1,3,2.0,8.0,3.0,15.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_57.Claude.Solver.Tri(6);
            var expected4 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_57.Claude.Solver.Tri(7);
            var expected5 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_57.Claude.Solver.Tri(8);
            var expected6 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_57.Claude.Solver.Tri(9);
            var expected7 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_57.Claude.Solver.Tri(20);
            var expected8 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0,6.0,48.0,7.0,63.0,8.0,80.0,9.0,99.0,10.0,120.0,11.0};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_57.Claude.Solver.Tri(0);
            var expected9 = new List<object> {1};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_57.Claude.Solver.Tri(1);
            var expected10 = new List<object> {1,3};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_57.Grok.Solver.Tri(3);
            var expected1 = new List<object> {1,3,2.0,8.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_57.Grok.Solver.Tri(4);
            var expected2 = new List<object> {1,3,2.0,8.0,3.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_57.Grok.Solver.Tri(5);
            var expected3 = new List<object> {1,3,2.0,8.0,3.0,15.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_57.Grok.Solver.Tri(6);
            var expected4 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_57.Grok.Solver.Tri(7);
            var expected5 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_57.Grok.Solver.Tri(8);
            var expected6 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_57.Grok.Solver.Tri(9);
            var expected7 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_57.Grok.Solver.Tri(20);
            var expected8 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0,6.0,48.0,7.0,63.0,8.0,80.0,9.0,99.0,10.0,120.0,11.0};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_57.Grok.Solver.Tri(0);
            var expected9 = new List<object> {1};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_57.Grok.Solver.Tri(1);
            var expected10 = new List<object> {1,3};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_57.Mistral.Solver.Tri(3);
            var expected1 = new List<object> {1,3,2.0,8.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_57.Mistral.Solver.Tri(4);
            var expected2 = new List<object> {1,3,2.0,8.0,3.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_57.Mistral.Solver.Tri(5);
            var expected3 = new List<object> {1,3,2.0,8.0,3.0,15.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_57.Mistral.Solver.Tri(6);
            var expected4 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_57.Mistral.Solver.Tri(7);
            var expected5 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_57.Mistral.Solver.Tri(8);
            var expected6 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_57.Mistral.Solver.Tri(9);
            var expected7 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_57.Mistral.Solver.Tri(20);
            var expected8 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0,6.0,48.0,7.0,63.0,8.0,80.0,9.0,99.0,10.0,120.0,11.0};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_57.Mistral.Solver.Tri(0);
            var expected9 = new List<object> {1};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_57.Mistral.Solver.Tri(1);
            var expected10 = new List<object> {1,3};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(3);
            var expected1 = new List<object> {1,3,2.0,8.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(4);
            var expected2 = new List<object> {1,3,2.0,8.0,3.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(5);
            var expected3 = new List<object> {1,3,2.0,8.0,3.0,15.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(6);
            var expected4 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(7);
            var expected5 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(8);
            var expected6 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(9);
            var expected7 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(20);
            var expected8 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0,6.0,48.0,7.0,63.0,8.0,80.0,9.0,99.0,10.0,120.0,11.0};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(0);
            var expected9 = new List<object> {1};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_57.DeepSeek.Solver.Tri(1);
            var expected10 = new List<object> {1,3};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_57.Llama.Solver.Tri(3);
            var expected1 = new List<object> {1,3,2.0,8.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_57.Llama.Solver.Tri(4);
            var expected2 = new List<object> {1,3,2.0,8.0,3.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_57.Llama.Solver.Tri(5);
            var expected3 = new List<object> {1,3,2.0,8.0,3.0,15.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_57.Llama.Solver.Tri(6);
            var expected4 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_57.Llama.Solver.Tri(7);
            var expected5 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_57.Llama.Solver.Tri(8);
            var expected6 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_57.Llama.Solver.Tri(9);
            var expected7 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_57.Llama.Solver.Tri(20);
            var expected8 = new List<object> {1,3,2.0,8.0,3.0,15.0,4.0,24.0,5.0,35.0,6.0,48.0,7.0,63.0,8.0,80.0,9.0,99.0,10.0,120.0,11.0};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_57.Llama.Solver.Tri(0);
            var expected9 = new List<object> {1};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_57.Llama.Solver.Tri(1);
            var expected10 = new List<object> {1,3};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
