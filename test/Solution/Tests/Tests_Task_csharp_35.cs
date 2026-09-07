// Auto-generated Tests for Task: csharp_35
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_35
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("Hello");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("abcdcba");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("kittens");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("orange");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("wow");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("world");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("MadaM");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("Wow");
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("HI");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("go");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("gogo");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("aaaaaaaaaaaaaaa");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("Madam");
            var expected14 = true;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("M");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_35.GPT.Solver.PrimeLength("0");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("Hello");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("abcdcba");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("kittens");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("orange");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("wow");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("world");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("MadaM");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("Wow");
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("HI");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("go");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("gogo");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("aaaaaaaaaaaaaaa");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("Madam");
            var expected14 = true;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("M");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_35.Gemini.Solver.PrimeLength("0");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("Hello");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("abcdcba");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("kittens");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("orange");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("wow");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("world");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("MadaM");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("Wow");
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("HI");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("go");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("gogo");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("aaaaaaaaaaaaaaa");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("Madam");
            var expected14 = true;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("M");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_35.Claude.Solver.PrimeLength("0");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("Hello");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("abcdcba");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("kittens");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("orange");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("wow");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("world");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("MadaM");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("Wow");
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("HI");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("go");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("gogo");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("aaaaaaaaaaaaaaa");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("Madam");
            var expected14 = true;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("M");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_35.Grok.Solver.PrimeLength("0");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("Hello");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("abcdcba");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("kittens");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("orange");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("wow");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("world");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("MadaM");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("Wow");
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("HI");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("go");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("gogo");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("aaaaaaaaaaaaaaa");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("Madam");
            var expected14 = true;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("M");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_35.Mistral.Solver.PrimeLength("0");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("Hello");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("abcdcba");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("kittens");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("orange");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("wow");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("world");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("MadaM");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("Wow");
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("HI");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("go");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("gogo");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("aaaaaaaaaaaaaaa");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("Madam");
            var expected14 = true;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("M");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength("0");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("Hello");
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("abcdcba");
            var expected2 = true;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("kittens");
            var expected3 = true;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("orange");
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("wow");
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("world");
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("MadaM");
            var expected7 = true;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("Wow");
            var expected8 = true;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("");
            var expected9 = false;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("HI");
            var expected10 = true;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("go");
            var expected11 = true;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("gogo");
            var expected12 = false;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("aaaaaaaaaaaaaaa");
            var expected13 = false;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("Madam");
            var expected14 = true;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("M");
            var expected15 = false;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_35.Llama.Solver.PrimeLength("0");
            var expected16 = false;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
