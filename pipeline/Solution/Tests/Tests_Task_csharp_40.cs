// Auto-generated Tests for Task: csharp_40
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_40
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3});
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3});
            var expected3 = 13;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {0,724,32,71,99,32,6,0,5,91,83,0,5,6});
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {0,81,12,3,1,21});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {0,8,1,2,1,7});
            var expected6 = 7;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {8191});
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {8191,123456,127,7});
            var expected8 = 19;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(new List<int> {127,97,8192});
            var expected9 = 10;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3});
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3});
            var expected3 = 13;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {0,724,32,71,99,32,6,0,5,91,83,0,5,6});
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {0,81,12,3,1,21});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {0,8,1,2,1,7});
            var expected6 = 7;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {8191});
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {8191,123456,127,7});
            var expected8 = 19;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(new List<int> {127,97,8192});
            var expected9 = 10;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3});
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3});
            var expected3 = 13;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {0,724,32,71,99,32,6,0,5,91,83,0,5,6});
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {0,81,12,3,1,21});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {0,8,1,2,1,7});
            var expected6 = 7;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {8191});
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {8191,123456,127,7});
            var expected8 = 19;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(new List<int> {127,97,8192});
            var expected9 = 10;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3});
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3});
            var expected3 = 13;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {0,724,32,71,99,32,6,0,5,91,83,0,5,6});
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {0,81,12,3,1,21});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {0,8,1,2,1,7});
            var expected6 = 7;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {8191});
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {8191,123456,127,7});
            var expected8 = 19;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(new List<int> {127,97,8192});
            var expected9 = 10;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3});
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3});
            var expected3 = 13;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {0,724,32,71,99,32,6,0,5,91,83,0,5,6});
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {0,81,12,3,1,21});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {0,8,1,2,1,7});
            var expected6 = 7;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {8191});
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {8191,123456,127,7});
            var expected8 = 19;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(new List<int> {127,97,8192});
            var expected9 = 10;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3});
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3});
            var expected3 = 13;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {0,724,32,71,99,32,6,0,5,91,83,0,5,6});
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {0,81,12,3,1,21});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {0,8,1,2,1,7});
            var expected6 = 7;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {8191});
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {8191,123456,127,7});
            var expected8 = 19;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(new List<int> {127,97,8192});
            var expected9 = 10;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {0,3,2,1,3,5,7,4,5,5,5,2,181,32,4,32,3,2,32,324,4,3});
            var expected1 = 10;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {1,0,1,8,2,4597,2,1,3,40,1,2,1,2,4,2,5,1});
            var expected2 = 25;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {1,3,1,32,5107,34,83278,109,163,23,2323,32,30,1,9,3});
            var expected3 = 13;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {0,724,32,71,99,32,6,0,5,91,83,0,5,6});
            var expected4 = 11;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {0,81,12,3,1,21});
            var expected5 = 3;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {0,8,1,2,1,7});
            var expected6 = 7;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {8191});
            var expected7 = 19;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {8191,123456,127,7});
            var expected8 = 19;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(new List<int> {127,97,8192});
            var expected9 = 10;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
