// Auto-generated Tests for Task: csharp_66
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_66
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_66.GPT.Solver.Simplify("1/5","5/1");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_66.GPT.Solver.Simplify("1/6","2/1");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_66.GPT.Solver.Simplify("5/1","3/1");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_66.GPT.Solver.Simplify("7/10","10/2");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_66.GPT.Solver.Simplify("2/10","50/10");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_66.GPT.Solver.Simplify("7/2","4/2");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_66.GPT.Solver.Simplify("11/6","6/1");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_66.GPT.Solver.Simplify("2/3","5/2");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_66.GPT.Solver.Simplify("5/2","3/5");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_66.GPT.Solver.Simplify("2/4","8/4");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_66.GPT.Solver.Simplify("2/4","4/2");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_66.GPT.Solver.Simplify("1/5","5/1");
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_66.GPT.Solver.Simplify("1/5","1/5");
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
            var actual1 = Benchmarks.csharp_66.Gemini.Solver.Simplify("1/5","5/1");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_66.Gemini.Solver.Simplify("1/6","2/1");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_66.Gemini.Solver.Simplify("5/1","3/1");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_66.Gemini.Solver.Simplify("7/10","10/2");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_66.Gemini.Solver.Simplify("2/10","50/10");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_66.Gemini.Solver.Simplify("7/2","4/2");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_66.Gemini.Solver.Simplify("11/6","6/1");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_66.Gemini.Solver.Simplify("2/3","5/2");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_66.Gemini.Solver.Simplify("5/2","3/5");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_66.Gemini.Solver.Simplify("2/4","8/4");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_66.Gemini.Solver.Simplify("2/4","4/2");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_66.Gemini.Solver.Simplify("1/5","5/1");
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_66.Gemini.Solver.Simplify("1/5","1/5");
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
            var actual1 = Benchmarks.csharp_66.Claude.Solver.Simplify("1/5","5/1");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_66.Claude.Solver.Simplify("1/6","2/1");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_66.Claude.Solver.Simplify("5/1","3/1");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_66.Claude.Solver.Simplify("7/10","10/2");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_66.Claude.Solver.Simplify("2/10","50/10");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_66.Claude.Solver.Simplify("7/2","4/2");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_66.Claude.Solver.Simplify("11/6","6/1");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_66.Claude.Solver.Simplify("2/3","5/2");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_66.Claude.Solver.Simplify("5/2","3/5");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_66.Claude.Solver.Simplify("2/4","8/4");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_66.Claude.Solver.Simplify("2/4","4/2");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_66.Claude.Solver.Simplify("1/5","5/1");
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_66.Claude.Solver.Simplify("1/5","1/5");
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
            var actual1 = Benchmarks.csharp_66.Grok.Solver.Simplify("1/5","5/1");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_66.Grok.Solver.Simplify("1/6","2/1");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_66.Grok.Solver.Simplify("5/1","3/1");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_66.Grok.Solver.Simplify("7/10","10/2");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_66.Grok.Solver.Simplify("2/10","50/10");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_66.Grok.Solver.Simplify("7/2","4/2");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_66.Grok.Solver.Simplify("11/6","6/1");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_66.Grok.Solver.Simplify("2/3","5/2");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_66.Grok.Solver.Simplify("5/2","3/5");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_66.Grok.Solver.Simplify("2/4","8/4");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_66.Grok.Solver.Simplify("2/4","4/2");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_66.Grok.Solver.Simplify("1/5","5/1");
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_66.Grok.Solver.Simplify("1/5","1/5");
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
            var actual1 = Benchmarks.csharp_66.Mistral.Solver.Simplify("1/5","5/1");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_66.Mistral.Solver.Simplify("1/6","2/1");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_66.Mistral.Solver.Simplify("5/1","3/1");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_66.Mistral.Solver.Simplify("7/10","10/2");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_66.Mistral.Solver.Simplify("2/10","50/10");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_66.Mistral.Solver.Simplify("7/2","4/2");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_66.Mistral.Solver.Simplify("11/6","6/1");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_66.Mistral.Solver.Simplify("2/3","5/2");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_66.Mistral.Solver.Simplify("5/2","3/5");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_66.Mistral.Solver.Simplify("2/4","8/4");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_66.Mistral.Solver.Simplify("2/4","4/2");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_66.Mistral.Solver.Simplify("1/5","5/1");
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_66.Mistral.Solver.Simplify("1/5","1/5");
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
            var actual1 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("1/5","5/1");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("1/6","2/1");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("5/1","3/1");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("7/10","10/2");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("2/10","50/10");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("7/2","4/2");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("11/6","6/1");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("2/3","5/2");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("5/2","3/5");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("2/4","8/4");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("2/4","4/2");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("1/5","5/1");
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_66.DeepSeek.Solver.Simplify("1/5","1/5");
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
            var actual1 = Benchmarks.csharp_66.Llama.Solver.Simplify("1/5","5/1");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_66.Llama.Solver.Simplify("1/6","2/1");
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_66.Llama.Solver.Simplify("5/1","3/1");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_66.Llama.Solver.Simplify("7/10","10/2");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_66.Llama.Solver.Simplify("2/10","50/10");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_66.Llama.Solver.Simplify("7/2","4/2");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_66.Llama.Solver.Simplify("11/6","6/1");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_66.Llama.Solver.Simplify("2/3","5/2");
            var expected8 = false;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_66.Llama.Solver.Simplify("5/2","3/5");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_66.Llama.Solver.Simplify("2/4","8/4");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_66.Llama.Solver.Simplify("2/4","4/2");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_66.Llama.Solver.Simplify("1/5","5/1");
            var expected12 = true;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_66.Llama.Solver.Simplify("1/5","1/5");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
