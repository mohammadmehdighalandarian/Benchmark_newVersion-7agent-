// Auto-generated Tests for Task: csharp_46
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_46
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(1,5);
            var expected1 = "0b11";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(7,13);
            var expected2 = "0b1010";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(964,977);
            var expected3 = "0b1111001010";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(996,997);
            var expected4 = "0b1111100100";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(560,851);
            var expected5 = "0b1011000010";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(185,546);
            var expected6 = "0b101101110";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(362,496);
            var expected7 = "0b110101101";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(350,902);
            var expected8 = "0b1001110010";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(197,233);
            var expected9 = "0b11010111";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(7,5);
            var expected10 = -1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(5,1);
            var expected11 = -1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_46.GPT.Solver.RoundedAvg(5,5);
            var expected12 = "0b101";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(1,5);
            var expected1 = "0b11";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(7,13);
            var expected2 = "0b1010";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(964,977);
            var expected3 = "0b1111001010";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(996,997);
            var expected4 = "0b1111100100";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(560,851);
            var expected5 = "0b1011000010";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(185,546);
            var expected6 = "0b101101110";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(362,496);
            var expected7 = "0b110101101";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(350,902);
            var expected8 = "0b1001110010";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(197,233);
            var expected9 = "0b11010111";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(7,5);
            var expected10 = -1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(5,1);
            var expected11 = -1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(5,5);
            var expected12 = "0b101";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(1,5);
            var expected1 = "0b11";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(7,13);
            var expected2 = "0b1010";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(964,977);
            var expected3 = "0b1111001010";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(996,997);
            var expected4 = "0b1111100100";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(560,851);
            var expected5 = "0b1011000010";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(185,546);
            var expected6 = "0b101101110";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(362,496);
            var expected7 = "0b110101101";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(350,902);
            var expected8 = "0b1001110010";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(197,233);
            var expected9 = "0b11010111";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(7,5);
            var expected10 = -1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(5,1);
            var expected11 = -1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_46.Claude.Solver.RoundedAvg(5,5);
            var expected12 = "0b101";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(1,5);
            var expected1 = "0b11";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(7,13);
            var expected2 = "0b1010";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(964,977);
            var expected3 = "0b1111001010";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(996,997);
            var expected4 = "0b1111100100";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(560,851);
            var expected5 = "0b1011000010";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(185,546);
            var expected6 = "0b101101110";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(362,496);
            var expected7 = "0b110101101";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(350,902);
            var expected8 = "0b1001110010";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(197,233);
            var expected9 = "0b11010111";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(7,5);
            var expected10 = -1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(5,1);
            var expected11 = -1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_46.Grok.Solver.RoundedAvg(5,5);
            var expected12 = "0b101";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(1,5);
            var expected1 = "0b11";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(7,13);
            var expected2 = "0b1010";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(964,977);
            var expected3 = "0b1111001010";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(996,997);
            var expected4 = "0b1111100100";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(560,851);
            var expected5 = "0b1011000010";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(185,546);
            var expected6 = "0b101101110";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(362,496);
            var expected7 = "0b110101101";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(350,902);
            var expected8 = "0b1001110010";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(197,233);
            var expected9 = "0b11010111";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(7,5);
            var expected10 = -1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(5,1);
            var expected11 = -1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(5,5);
            var expected12 = "0b101";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(1,5);
            var expected1 = "0b11";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(7,13);
            var expected2 = "0b1010";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(964,977);
            var expected3 = "0b1111001010";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(996,997);
            var expected4 = "0b1111100100";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(560,851);
            var expected5 = "0b1011000010";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(185,546);
            var expected6 = "0b101101110";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(362,496);
            var expected7 = "0b110101101";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(350,902);
            var expected8 = "0b1001110010";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(197,233);
            var expected9 = "0b11010111";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(7,5);
            var expected10 = -1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(5,1);
            var expected11 = -1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(5,5);
            var expected12 = "0b101";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(1,5);
            var expected1 = "0b11";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(7,13);
            var expected2 = "0b1010";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(964,977);
            var expected3 = "0b1111001010";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(996,997);
            var expected4 = "0b1111100100";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(560,851);
            var expected5 = "0b1011000010";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(185,546);
            var expected6 = "0b101101110";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(362,496);
            var expected7 = "0b110101101";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(350,902);
            var expected8 = "0b1001110010";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(197,233);
            var expected9 = "0b11010111";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(7,5);
            var expected10 = -1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(5,1);
            var expected11 = -1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_46.Llama.Solver.RoundedAvg(5,5);
            var expected12 = "0b101";
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
