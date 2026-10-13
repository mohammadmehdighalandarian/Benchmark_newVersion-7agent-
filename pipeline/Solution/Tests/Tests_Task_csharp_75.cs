// Auto-generated Tests for Task: csharp_75
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_75
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(19);
            var expected1 = "xix";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(152);
            var expected2 = "clii";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(251);
            var expected3 = "ccli";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(426);
            var expected4 = "cdxxvi";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(500);
            var expected5 = "d";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(1);
            var expected6 = "i";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(4);
            var expected7 = "iv";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(43);
            var expected8 = "xliii";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(90);
            var expected9 = "xc";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(94);
            var expected10 = "xciv";
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(532);
            var expected11 = "dxxxii";
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(900);
            var expected12 = "cm";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(994);
            var expected13 = "cmxciv";
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(1000);
            var expected14 = "m";
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(19);
            var expected1 = "xix";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(152);
            var expected2 = "clii";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(251);
            var expected3 = "ccli";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(426);
            var expected4 = "cdxxvi";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(500);
            var expected5 = "d";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(1);
            var expected6 = "i";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(4);
            var expected7 = "iv";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(43);
            var expected8 = "xliii";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(90);
            var expected9 = "xc";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(94);
            var expected10 = "xciv";
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(532);
            var expected11 = "dxxxii";
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(900);
            var expected12 = "cm";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(994);
            var expected13 = "cmxciv";
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(1000);
            var expected14 = "m";
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(19);
            var expected1 = "xix";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(152);
            var expected2 = "clii";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(251);
            var expected3 = "ccli";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(426);
            var expected4 = "cdxxvi";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(500);
            var expected5 = "d";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(1);
            var expected6 = "i";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(4);
            var expected7 = "iv";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(43);
            var expected8 = "xliii";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(90);
            var expected9 = "xc";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(94);
            var expected10 = "xciv";
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(532);
            var expected11 = "dxxxii";
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(900);
            var expected12 = "cm";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(994);
            var expected13 = "cmxciv";
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(1000);
            var expected14 = "m";
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(19);
            var expected1 = "xix";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(152);
            var expected2 = "clii";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(251);
            var expected3 = "ccli";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(426);
            var expected4 = "cdxxvi";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(500);
            var expected5 = "d";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(1);
            var expected6 = "i";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(4);
            var expected7 = "iv";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(43);
            var expected8 = "xliii";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(90);
            var expected9 = "xc";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(94);
            var expected10 = "xciv";
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(532);
            var expected11 = "dxxxii";
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(900);
            var expected12 = "cm";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(994);
            var expected13 = "cmxciv";
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(1000);
            var expected14 = "m";
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(19);
            var expected1 = "xix";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(152);
            var expected2 = "clii";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(251);
            var expected3 = "ccli";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(426);
            var expected4 = "cdxxvi";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(500);
            var expected5 = "d";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(1);
            var expected6 = "i";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(4);
            var expected7 = "iv";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(43);
            var expected8 = "xliii";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(90);
            var expected9 = "xc";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(94);
            var expected10 = "xciv";
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(532);
            var expected11 = "dxxxii";
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(900);
            var expected12 = "cm";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(994);
            var expected13 = "cmxciv";
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(1000);
            var expected14 = "m";
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(19);
            var expected1 = "xix";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(152);
            var expected2 = "clii";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(251);
            var expected3 = "ccli";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(426);
            var expected4 = "cdxxvi";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(500);
            var expected5 = "d";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(1);
            var expected6 = "i";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(4);
            var expected7 = "iv";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(43);
            var expected8 = "xliii";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(90);
            var expected9 = "xc";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(94);
            var expected10 = "xciv";
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(532);
            var expected11 = "dxxxii";
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(900);
            var expected12 = "cm";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(994);
            var expected13 = "cmxciv";
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(1000);
            var expected14 = "m";
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(19);
            var expected1 = "xix";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(152);
            var expected2 = "clii";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(251);
            var expected3 = "ccli";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(426);
            var expected4 = "cdxxvi";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(500);
            var expected5 = "d";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(1);
            var expected6 = "i";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(4);
            var expected7 = "iv";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(43);
            var expected8 = "xliii";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(90);
            var expected9 = "xc";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(94);
            var expected10 = "xciv";
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(532);
            var expected11 = "dxxxii";
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(900);
            var expected12 = "cm";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(994);
            var expected13 = "cmxciv";
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(1000);
            var expected14 = "m";
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
