// Auto-generated Tests for Task: csharp_27

using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_27
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_27.GPT.Solver.VowelsCount("abcde");
                var expected1 = 2;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_27.GPT.Solver.VowelsCount("Alone");
                var expected2 = 3;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_27.GPT.Solver.VowelsCount("key");
                var expected3 = 2;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_27.GPT.Solver.VowelsCount("bye");
                var expected4 = 1;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_27.GPT.Solver.VowelsCount("keY");
                var expected5 = 2;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_27.GPT.Solver.VowelsCount("bYe");
                var expected6 = 1;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_27.GPT.Solver.VowelsCount("ACEDY");
                var expected7 = 3;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
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
                var actual1 = Benchmarks.csharp_27.Gemini.Solver.VowelsCount("abcde");
                var expected1 = 2;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_27.Gemini.Solver.VowelsCount("Alone");
                var expected2 = 3;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_27.Gemini.Solver.VowelsCount("key");
                var expected3 = 2;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_27.Gemini.Solver.VowelsCount("bye");
                var expected4 = 1;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_27.Gemini.Solver.VowelsCount("keY");
                var expected5 = 2;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_27.Gemini.Solver.VowelsCount("bYe");
                var expected6 = 1;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_27.Gemini.Solver.VowelsCount("ACEDY");
                var expected7 = 3;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
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
                var actual1 = Benchmarks.csharp_27.Claude.Solver.VowelsCount("abcde");
                var expected1 = 2;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_27.Claude.Solver.VowelsCount("Alone");
                var expected2 = 3;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_27.Claude.Solver.VowelsCount("key");
                var expected3 = 2;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_27.Claude.Solver.VowelsCount("bye");
                var expected4 = 1;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_27.Claude.Solver.VowelsCount("keY");
                var expected5 = 2;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_27.Claude.Solver.VowelsCount("bYe");
                var expected6 = 1;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_27.Claude.Solver.VowelsCount("ACEDY");
                var expected7 = 3;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
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
                var actual1 = Benchmarks.csharp_27.Grok.Solver.VowelsCount("abcde");
                var expected1 = 2;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_27.Grok.Solver.VowelsCount("Alone");
                var expected2 = 3;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_27.Grok.Solver.VowelsCount("key");
                var expected3 = 2;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_27.Grok.Solver.VowelsCount("bye");
                var expected4 = 1;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_27.Grok.Solver.VowelsCount("keY");
                var expected5 = 2;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_27.Grok.Solver.VowelsCount("bYe");
                var expected6 = 1;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_27.Grok.Solver.VowelsCount("ACEDY");
                var expected7 = 3;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
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
                var actual1 = Benchmarks.csharp_27.Mistral.Solver.VowelsCount("abcde");
                var expected1 = 2;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_27.Mistral.Solver.VowelsCount("Alone");
                var expected2 = 3;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_27.Mistral.Solver.VowelsCount("key");
                var expected3 = 2;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_27.Mistral.Solver.VowelsCount("bye");
                var expected4 = 1;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_27.Mistral.Solver.VowelsCount("keY");
                var expected5 = 2;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_27.Mistral.Solver.VowelsCount("bYe");
                var expected6 = 1;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_27.Mistral.Solver.VowelsCount("ACEDY");
                var expected7 = 3;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
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
                var actual1 = Benchmarks.csharp_27.DeepSeek.Solver.VowelsCount("abcde");
                var expected1 = 2;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_27.DeepSeek.Solver.VowelsCount("Alone");
                var expected2 = 3;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_27.DeepSeek.Solver.VowelsCount("key");
                var expected3 = 2;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_27.DeepSeek.Solver.VowelsCount("bye");
                var expected4 = 1;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_27.DeepSeek.Solver.VowelsCount("keY");
                var expected5 = 2;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_27.DeepSeek.Solver.VowelsCount("bYe");
                var expected6 = 1;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_27.DeepSeek.Solver.VowelsCount("ACEDY");
                var expected7 = 3;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
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
                var actual1 = Benchmarks.csharp_27.Llama.Solver.VowelsCount("abcde");
                var expected1 = 2;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_27.Llama.Solver.VowelsCount("Alone");
                var expected2 = 3;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_27.Llama.Solver.VowelsCount("key");
                var expected3 = 2;
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_27.Llama.Solver.VowelsCount("bye");
                var expected4 = 1;
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

                var actual5 = Benchmarks.csharp_27.Llama.Solver.VowelsCount("keY");
                var expected5 = 2;
                var result5 = compareLogic.Compare(actual5, expected5);
                TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

                var actual6 = Benchmarks.csharp_27.Llama.Solver.VowelsCount("bYe");
                var expected6 = 1;
                var result6 = compareLogic.Compare(actual6, expected6);
                TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

                var actual7 = Benchmarks.csharp_27.Llama.Solver.VowelsCount("ACEDY");
                var expected7 = 3;
                var result7 = compareLogic.Compare(actual7, expected7);
                TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }
    }
}