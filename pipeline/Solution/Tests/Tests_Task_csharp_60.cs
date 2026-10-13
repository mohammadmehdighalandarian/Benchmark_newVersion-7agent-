// Auto-generated Tests for Task: csharp_60

using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_60
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { 1, 2, 3 });
                var expected1 = 14;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { 1.0, 2, 3 });
                var expected2 = 14;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { 1, 3, 5, 7 });
                var expected3 = 84;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { 1.4, 4.2, 0 });
                var expected4 = 29;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { -2.4, 1, 1 });
                var expected5 = 6;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { 100, 1, 15, 2 });
                var expected6 = 10230;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { 10000, 10000 });
                var expected7 = 200000000;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

                var actual8 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { -1.4, 4.6, 6.3 });
                var expected8 = 75;
                var result8 = compareLogic.Compare(actual8, expected8);
                TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

                var actual9 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { -1.4, 17.9, 18.9, 19.9 });
                var expected9 = 1086;
                var result9 = compareLogic.Compare(actual9, expected9);
                TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

                var actual10 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { 0 });
                var expected10 = 0;
                var result10 = compareLogic.Compare(actual10, expected10);
                TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

                var actual11 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { -1 });
                var expected11 = 1;
                var result11 = compareLogic.Compare(actual11, expected11);
                TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

                var actual12 = Benchmarks.csharp_60.GPT.Solver.SumSquares(new List<object> { -1, 1, 0 });
                var expected12 = 2;
                var result12 = compareLogic.Compare(actual12, expected12);
                TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { 1, 2, 3 });
                var expected1 = 14;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { 1.0, 2, 3 });
                var expected2 = 14;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { 1, 3, 5, 7 });
                var expected3 = 84;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { 1.4, 4.2, 0 });
                var expected4 = 29;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { -2.4, 1, 1 });
                var expected5 = 6;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { 100, 1, 15, 2 });
                var expected6 = 10230;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { 10000, 10000 });
                var expected7 = 200000000;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

                var actual8 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { -1.4, 4.6, 6.3 });
                var expected8 = 75;
                var result8 = compareLogic.Compare(actual8, expected8);
                TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

                var actual9 =
                    Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { -1.4, 17.9, 18.9, 19.9 });
                var expected9 = 1086;
                var result9 = compareLogic.Compare(actual9, expected9);
                TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

                var actual10 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { 0 });
                var expected10 = 0;
                var result10 = compareLogic.Compare(actual10, expected10);
                TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

                var actual11 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { -1 });
                var expected11 = 1;
                var result11 = compareLogic.Compare(actual11, expected11);
                TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

                var actual12 = Benchmarks.csharp_60.Gemini.Solver.SumSquares(new List<object> { -1, 1, 0 });
                var expected12 = 2;
                var result12 = compareLogic.Compare(actual12, expected12);
                TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { 1, 2, 3 });
                var expected1 = 14;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { 1.0, 2, 3 });
                var expected2 = 14;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { 1, 3, 5, 7 });
                var expected3 = 84;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { 1.4, 4.2, 0 });
                var expected4 = 29;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { -2.4, 1, 1 });
                var expected5 = 6;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { 100, 1, 15, 2 });
                var expected6 = 10230;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { 10000, 10000 });
                var expected7 = 200000000;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

                var actual8 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { -1.4, 4.6, 6.3 });
                var expected8 = 75;
                var result8 = compareLogic.Compare(actual8, expected8);
                TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

                var actual9 =
                    Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { -1.4, 17.9, 18.9, 19.9 });
                var expected9 = 1086;
                var result9 = compareLogic.Compare(actual9, expected9);
                TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

                var actual10 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { 0 });
                var expected10 = 0;
                var result10 = compareLogic.Compare(actual10, expected10);
                TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

                var actual11 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { -1 });
                var expected11 = 1;
                var result11 = compareLogic.Compare(actual11, expected11);
                TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

                var actual12 = Benchmarks.csharp_60.Claude.Solver.SumSquares(new List<object> { -1, 1, 0 });
                var expected12 = 2;
                var result12 = compareLogic.Compare(actual12, expected12);
                TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { 1, 2, 3 });
                var expected1 = 14;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { 1.0, 2, 3 });
                var expected2 = 14;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { 1, 3, 5, 7 });
                var expected3 = 84;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { 1.4, 4.2, 0 });
                var expected4 = 29;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { -2.4, 1, 1 });
                var expected5 = 6;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { 100, 1, 15, 2 });
                var expected6 = 10230;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { 10000, 10000 });
                var expected7 = 200000000;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

                var actual8 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { -1.4, 4.6, 6.3 });
                var expected8 = 75;
                var result8 = compareLogic.Compare(actual8, expected8);
                TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

                var actual9 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { -1.4, 17.9, 18.9, 19.9 });
                var expected9 = 1086;
                var result9 = compareLogic.Compare(actual9, expected9);
                TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

                var actual10 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { 0 });
                var expected10 = 0;
                var result10 = compareLogic.Compare(actual10, expected10);
                TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

                var actual11 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { -1 });
                var expected11 = 1;
                var result11 = compareLogic.Compare(actual11, expected11);
                TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

                var actual12 = Benchmarks.csharp_60.Grok.Solver.SumSquares(new List<object> { -1, 1, 0 });
                var expected12 = 2;
                var result12 = compareLogic.Compare(actual12, expected12);
                TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { 1, 2, 3 });
                var expected1 = 14;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { 1.0, 2, 3 });
                var expected2 = 14;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { 1, 3, 5, 7 });
                var expected3 = 84;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { 1.4, 4.2, 0 });
                var expected4 = 29;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { -2.4, 1, 1 });
                var expected5 = 6;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { 100, 1, 15, 2 });
                var expected6 = 10230;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { 10000, 10000 });
                var expected7 = 200000000;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

                var actual8 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { -1.4, 4.6, 6.3 });
                var expected8 = 75;
                var result8 = compareLogic.Compare(actual8, expected8);
                TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

                var actual9 =
                    Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { -1.4, 17.9, 18.9, 19.9 });
                var expected9 = 1086;
                var result9 = compareLogic.Compare(actual9, expected9);
                TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

                var actual10 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { 0 });
                var expected10 = 0;
                var result10 = compareLogic.Compare(actual10, expected10);
                TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

                var actual11 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { -1 });
                var expected11 = 1;
                var result11 = compareLogic.Compare(actual11, expected11);
                TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

                var actual12 = Benchmarks.csharp_60.Mistral.Solver.SumSquares(new List<object> { -1, 1, 0 });
                var expected12 = 2;
                var result12 = compareLogic.Compare(actual12, expected12);
                TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { 1, 2, 3 });
                var expected1 = 14;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { 1.0, 2, 3 });
                var expected2 = 14;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { 1, 3, 5, 7 });
                var expected3 = 84;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { 1.4, 4.2, 0 });
                var expected4 = 29;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { -2.4, 1, 1 });
                var expected5 = 6;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { 100, 1, 15, 2 });
                var expected6 = 10230;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { 10000, 10000 });
                var expected7 = 200000000;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

                var actual8 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { -1.4, 4.6, 6.3 });
                var expected8 = 75;
                var result8 = compareLogic.Compare(actual8, expected8);
                TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

                var actual9 =
                    Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { -1.4, 17.9, 18.9, 19.9 });
                var expected9 = 1086;
                var result9 = compareLogic.Compare(actual9, expected9);
                TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

                var actual10 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { 0 });
                var expected10 = 0;
                var result10 = compareLogic.Compare(actual10, expected10);
                TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

                var actual11 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { -1 });
                var expected11 = 1;
                var result11 = compareLogic.Compare(actual11, expected11);
                TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

                var actual12 = Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(new List<object> { -1, 1, 0 });
                var expected12 = 2;
                var result12 = compareLogic.Compare(actual12, expected12);
                TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { 1, 2, 3 });
                var expected1 = 14;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { 1.0, 2, 3 });
                var expected2 = 14;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { 1, 3, 5, 7 });
                var expected3 = 84;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { 1.4, 4.2, 0 });
                var expected4 = 29;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { -2.4, 1, 1 });
                var expected5 = 6;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { 100, 1, 15, 2 });
                var expected6 = 10230;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { 10000, 10000 });
                var expected7 = 200000000;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

                var actual8 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { -1.4, 4.6, 6.3 });
                var expected8 = 75;
                var result8 = compareLogic.Compare(actual8, expected8);
                TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

                var actual9 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { -1.4, 17.9, 18.9, 19.9 });
                var expected9 = 1086;
                var result9 = compareLogic.Compare(actual9, expected9);
                TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

                var actual10 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { 0 });
                var expected10 = 0;
                var result10 = compareLogic.Compare(actual10, expected10);
                TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

                var actual11 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { -1 });
                var expected11 = 1;
                var result11 = compareLogic.Compare(actual11, expected11);
                TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

                var actual12 = Benchmarks.csharp_60.Llama.Solver.SumSquares(new List<object> { -1, 1, 0 });
                var expected12 = 2;
                var result12 = compareLogic.Compare(actual12, expected12);
                TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }
    }
}