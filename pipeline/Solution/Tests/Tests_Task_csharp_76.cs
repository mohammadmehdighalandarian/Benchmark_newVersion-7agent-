// Auto-generated Tests for Task: csharp_76
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_76
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(3,4,5);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(1,2,3);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(10,6,8);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(2,2,2);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(7,24,25);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(10,5,7);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(5,12,13);
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(15,8,17);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(48,55,73);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(1,1,1);
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(2,2,10);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(3,4,5);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(1,2,3);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(10,6,8);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(2,2,2);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(7,24,25);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(10,5,7);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(5,12,13);
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(15,8,17);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(48,55,73);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(1,1,1);
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(2,2,10);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(3,4,5);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(1,2,3);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(10,6,8);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(2,2,2);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(7,24,25);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(10,5,7);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(5,12,13);
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(15,8,17);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(48,55,73);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(1,1,1);
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(2,2,10);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(3,4,5);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(1,2,3);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(10,6,8);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(2,2,2);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(7,24,25);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(10,5,7);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(5,12,13);
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(15,8,17);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(48,55,73);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(1,1,1);
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(2,2,10);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(3,4,5);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(1,2,3);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(10,6,8);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(2,2,2);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(7,24,25);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(10,5,7);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(5,12,13);
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(15,8,17);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(48,55,73);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(1,1,1);
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(2,2,10);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(3,4,5);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(1,2,3);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(10,6,8);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(2,2,2);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(7,24,25);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(10,5,7);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(5,12,13);
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(15,8,17);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(48,55,73);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(1,1,1);
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(2,2,10);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(3,4,5);
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(1,2,3);
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(10,6,8);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(2,2,2);
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(7,24,25);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(10,5,7);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(5,12,13);
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(15,8,17);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(48,55,73);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(1,1,1);
            var expected10 = false;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(2,2,10);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
