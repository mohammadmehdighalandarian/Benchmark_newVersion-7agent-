// Auto-generated Tests for Task: csharp_9
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_9
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_9.GPT.Solver.IsPrime(6);
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_9.GPT.Solver.IsPrime(101);
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_9.GPT.Solver.IsPrime(11);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_9.GPT.Solver.IsPrime(13441);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_9.GPT.Solver.IsPrime(61);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_9.GPT.Solver.IsPrime(4);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_9.GPT.Solver.IsPrime(1);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_9.GPT.Solver.IsPrime(5);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_9.GPT.Solver.IsPrime(11);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_9.GPT.Solver.IsPrime(17);
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_9.GPT.Solver.IsPrime(85);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_9.GPT.Solver.IsPrime(77);
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_9.GPT.Solver.IsPrime(255379);
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(6);
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(101);
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(11);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(13441);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(61);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(4);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(1);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(5);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(11);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(17);
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(85);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(77);
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_9.Gemini.Solver.IsPrime(255379);
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_9.Claude.Solver.IsPrime(6);
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_9.Claude.Solver.IsPrime(101);
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_9.Claude.Solver.IsPrime(11);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_9.Claude.Solver.IsPrime(13441);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_9.Claude.Solver.IsPrime(61);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_9.Claude.Solver.IsPrime(4);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_9.Claude.Solver.IsPrime(1);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_9.Claude.Solver.IsPrime(5);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_9.Claude.Solver.IsPrime(11);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_9.Claude.Solver.IsPrime(17);
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_9.Claude.Solver.IsPrime(85);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_9.Claude.Solver.IsPrime(77);
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_9.Claude.Solver.IsPrime(255379);
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_9.Grok.Solver.IsPrime(6);
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_9.Grok.Solver.IsPrime(101);
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_9.Grok.Solver.IsPrime(11);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_9.Grok.Solver.IsPrime(13441);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_9.Grok.Solver.IsPrime(61);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_9.Grok.Solver.IsPrime(4);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_9.Grok.Solver.IsPrime(1);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_9.Grok.Solver.IsPrime(5);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_9.Grok.Solver.IsPrime(11);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_9.Grok.Solver.IsPrime(17);
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_9.Grok.Solver.IsPrime(85);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_9.Grok.Solver.IsPrime(77);
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_9.Grok.Solver.IsPrime(255379);
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(6);
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(101);
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(11);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(13441);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(61);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(4);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(1);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(5);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(11);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(17);
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(85);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(77);
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_9.Mistral.Solver.IsPrime(255379);
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(6);
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(101);
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(11);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(13441);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(61);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(4);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(1);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(5);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(11);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(17);
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(85);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(77);
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(255379);
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_9.Llama.Solver.IsPrime(6);
            var expected1 = false;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_9.Llama.Solver.IsPrime(101);
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_9.Llama.Solver.IsPrime(11);
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_9.Llama.Solver.IsPrime(13441);
            var expected4 = true;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_9.Llama.Solver.IsPrime(61);
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_9.Llama.Solver.IsPrime(4);
            var expected6 = false;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_9.Llama.Solver.IsPrime(1);
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_9.Llama.Solver.IsPrime(5);
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_9.Llama.Solver.IsPrime(11);
            var expected9 = true;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_9.Llama.Solver.IsPrime(17);
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_9.Llama.Solver.IsPrime(85);
            var expected11 = false;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_9.Llama.Solver.IsPrime(77);
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_9.Llama.Solver.IsPrime(255379);
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
