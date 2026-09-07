// Auto-generated Tests for Task: csharp_3

using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_3
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try
            {
                CompareLogic compareLogic = new CompareLogic();
                var actual1 = Benchmarks.csharp_3.GPT.Solver.Longest(new List<string> { });
                object expected1 = null;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_3.GPT.Solver.Longest(new List<string> { "x", "y", "z" });
                var expected2 = "x";
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_3.GPT.Solver.Longest(new List<string>
                    { "x", "yyy", "zzzz", "www", "kkkk", "abc" });
                var expected3 = "zzzz";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");
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
                var actual1 = Benchmarks.csharp_3.Gemini.Solver.Longest(new List<string> { });
                object expected1 = null;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_3.Gemini.Solver.Longest(new List<string> { "x", "y", "z" });
                var expected2 = "x";
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_3.Gemini.Solver.Longest(new List<string>
                    { "x", "yyy", "zzzz", "www", "kkkk", "abc" });
                var expected3 = "zzzz";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");
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
                var actual1 = Benchmarks.csharp_3.Claude.Solver.Longest(new List<string> { });
                object expected1 = null;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_3.Claude.Solver.Longest(new List<string> { "x", "y", "z" });
                var expected2 = "x";
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_3.Claude.Solver.Longest(new List<string>
                    { "x", "yyy", "zzzz", "www", "kkkk", "abc" });
                var expected3 = "zzzz";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");
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
                var actual1 = Benchmarks.csharp_3.Grok.Solver.Longest(new List<string> { });
                object expected1 = null;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_3.Grok.Solver.Longest(new List<string> { "x", "y", "z" });
                var expected2 = "x";
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_3.Grok.Solver.Longest(new List<string>
                    { "x", "yyy", "zzzz", "www", "kkkk", "abc" });
                var expected3 = "zzzz";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");
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
                var actual1 = Benchmarks.csharp_3.Mistral.Solver.Longest(new List<string> { });
                object expected1 = null;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_3.Mistral.Solver.Longest(new List<string> { "x", "y", "z" });
                var expected2 = "x";
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_3.Mistral.Solver.Longest(new List<string>
                    { "x", "yyy", "zzzz", "www", "kkkk", "abc" });
                var expected3 = "zzzz";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");
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
                var actual1 = Benchmarks.csharp_3.DeepSeek.Solver.Longest(new List<string> { });
                object expected1 = null;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_3.DeepSeek.Solver.Longest(new List<string> { "x", "y", "z" });
                var expected2 = "x";
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_3.DeepSeek.Solver.Longest(new List<string>
                    { "x", "yyy", "zzzz", "www", "kkkk", "abc" });
                var expected3 = "zzzz";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");
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
                var actual1 = Benchmarks.csharp_3.Llama.Solver.Longest(new List<string> { });
                object expected1 = null;
                var result1 = compareLogic.Compare(actual1, expected1);
                TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

                var actual2 = Benchmarks.csharp_3.Llama.Solver.Longest(new List<string> { "x", "y", "z" });
                var expected2 = "x";
                var result2 = compareLogic.Compare(actual2, expected2);
                TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

                var actual3 = Benchmarks.csharp_3.Llama.Solver.Longest(new List<string>
                    { "x", "yyy", "zzzz", "www", "kkkk", "abc" });
                var expected3 = "zzzz";
                var result3 = compareLogic.Compare(actual3, expected3);
                TestUtils.Check(result3, "Exception --- test case 2 failed to pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL FAIL: " + ex.Message);
            }
        }
    }
}