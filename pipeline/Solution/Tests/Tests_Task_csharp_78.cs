// Auto-generated Tests for Task: csharp_78

using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_78
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_78.GPT.Solver.StringToMd5("Hello world");
                var expected1 = "3e25960a79dbc69b674cd4ec67a72c62";
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_78.GPT.Solver.StringToMd5("");
                object expected2 = null;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_78.GPT.Solver.StringToMd5("A B C");
                var expected3 = "0ef78513b0cb8cef12743f5aeb35f888";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_78.GPT.Solver.StringToMd5("password");
                var expected4 = "5f4dcc3b5aa765d61d8327deb882cf99";
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
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
                var actual1 = Benchmarks.csharp_78.Gemini.Solver.StringToMd5("Hello world");
                var expected1 = "3e25960a79dbc69b674cd4ec67a72c62";
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_78.Gemini.Solver.StringToMd5("");
                object expected2 = null;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_78.Gemini.Solver.StringToMd5("A B C");
                var expected3 = "0ef78513b0cb8cef12743f5aeb35f888";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_78.Gemini.Solver.StringToMd5("password");
                var expected4 = "5f4dcc3b5aa765d61d8327deb882cf99";
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
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
                var actual1 = Benchmarks.csharp_78.Claude.Solver.StringToMd5("Hello world");
                var expected1 = "3e25960a79dbc69b674cd4ec67a72c62";
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_78.Claude.Solver.StringToMd5("");
                object expected2 = null;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_78.Claude.Solver.StringToMd5("A B C");
                var expected3 = "0ef78513b0cb8cef12743f5aeb35f888";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_78.Claude.Solver.StringToMd5("password");
                var expected4 = "5f4dcc3b5aa765d61d8327deb882cf99";
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
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
                var actual1 = Benchmarks.csharp_78.Grok.Solver.StringToMd5("Hello world");
                var expected1 = "3e25960a79dbc69b674cd4ec67a72c62";
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_78.Grok.Solver.StringToMd5("");
                object expected2 = null;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_78.Grok.Solver.StringToMd5("A B C");
                var expected3 = "0ef78513b0cb8cef12743f5aeb35f888";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_78.Grok.Solver.StringToMd5("password");
                var expected4 = "5f4dcc3b5aa765d61d8327deb882cf99";
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
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
                var actual1 = Benchmarks.csharp_78.Mistral.Solver.StringToMd5("Hello world");
                var expected1 = "3e25960a79dbc69b674cd4ec67a72c62";
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_78.Mistral.Solver.StringToMd5("");
                object expected2 = null;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_78.Mistral.Solver.StringToMd5("A B C");
                var expected3 = "0ef78513b0cb8cef12743f5aeb35f888";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_78.Mistral.Solver.StringToMd5("password");
                var expected4 = "5f4dcc3b5aa765d61d8327deb882cf99";
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
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
                var actual1 = Benchmarks.csharp_78.DeepSeek.Solver.StringToMd5("Hello world");
                var expected1 = "3e25960a79dbc69b674cd4ec67a72c62";
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_78.DeepSeek.Solver.StringToMd5("");
                object expected2 = null;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_78.DeepSeek.Solver.StringToMd5("A B C");
                var expected3 = "0ef78513b0cb8cef12743f5aeb35f888";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_78.DeepSeek.Solver.StringToMd5("password");
                var expected4 = "5f4dcc3b5aa765d61d8327deb882cf99";
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
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
                var actual1 = Benchmarks.csharp_78.Llama.Solver.StringToMd5("Hello world");
                var expected1 = "3e25960a79dbc69b674cd4ec67a72c62";
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_78.Llama.Solver.StringToMd5("");
                object expected2 = null;
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_78.Llama.Solver.StringToMd5("A B C");
                var expected3 = "0ef78513b0cb8cef12743f5aeb35f888";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

                var actual4 = Benchmarks.csharp_78.Llama.Solver.StringToMd5("password");
                var expected4 = "5f4dcc3b5aa765d61d8327deb882cf99";
                var result4 = compareLogic.Compare(actual4, expected4);
                TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }
    }
}