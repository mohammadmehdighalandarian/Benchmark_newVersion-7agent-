// Auto-generated Tests for Task: csharp_51
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_51
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("abcde","ae");
            var expected1 = new List<object> {"bcd",false};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("abcdef","b");
            var expected2 = new List<object> {"acdef",false};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("abcdedcba","ab");
            var expected3 = new List<object> {"cdedc",true};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("dwik","w");
            var expected4 = new List<object> {"dik",false};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("a","a");
            var expected5 = new List<object> {"",true};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("abcdedcba","");
            var expected6 = new List<object> {"abcdedcba",true};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("abcdedcba","v");
            var expected7 = new List<object> {"abcdedcba",true};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("vabba","v");
            var expected8 = new List<object> {"abba",true};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_51.GPT.Solver.ReverseDelete("mamma","mia");
            var expected9 = new List<object> {"",true};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("abcde","ae");
            var expected1 = new List<object> {"bcd",false};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("abcdef","b");
            var expected2 = new List<object> {"acdef",false};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("abcdedcba","ab");
            var expected3 = new List<object> {"cdedc",true};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("dwik","w");
            var expected4 = new List<object> {"dik",false};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("a","a");
            var expected5 = new List<object> {"",true};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("abcdedcba","");
            var expected6 = new List<object> {"abcdedcba",true};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("abcdedcba","v");
            var expected7 = new List<object> {"abcdedcba",true};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("vabba","v");
            var expected8 = new List<object> {"abba",true};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_51.Gemini.Solver.ReverseDelete("mamma","mia");
            var expected9 = new List<object> {"",true};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("abcde","ae");
            var expected1 = new List<object> {"bcd",false};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("abcdef","b");
            var expected2 = new List<object> {"acdef",false};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("abcdedcba","ab");
            var expected3 = new List<object> {"cdedc",true};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("dwik","w");
            var expected4 = new List<object> {"dik",false};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("a","a");
            var expected5 = new List<object> {"",true};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("abcdedcba","");
            var expected6 = new List<object> {"abcdedcba",true};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("abcdedcba","v");
            var expected7 = new List<object> {"abcdedcba",true};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("vabba","v");
            var expected8 = new List<object> {"abba",true};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_51.Claude.Solver.ReverseDelete("mamma","mia");
            var expected9 = new List<object> {"",true};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("abcde","ae");
            var expected1 = new List<object> {"bcd",false};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("abcdef","b");
            var expected2 = new List<object> {"acdef",false};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("abcdedcba","ab");
            var expected3 = new List<object> {"cdedc",true};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("dwik","w");
            var expected4 = new List<object> {"dik",false};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("a","a");
            var expected5 = new List<object> {"",true};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("abcdedcba","");
            var expected6 = new List<object> {"abcdedcba",true};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("abcdedcba","v");
            var expected7 = new List<object> {"abcdedcba",true};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("vabba","v");
            var expected8 = new List<object> {"abba",true};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_51.Grok.Solver.ReverseDelete("mamma","mia");
            var expected9 = new List<object> {"",true};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("abcde","ae");
            var expected1 = new List<object> {"bcd",false};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("abcdef","b");
            var expected2 = new List<object> {"acdef",false};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("abcdedcba","ab");
            var expected3 = new List<object> {"cdedc",true};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("dwik","w");
            var expected4 = new List<object> {"dik",false};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("a","a");
            var expected5 = new List<object> {"",true};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("abcdedcba","");
            var expected6 = new List<object> {"abcdedcba",true};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("abcdedcba","v");
            var expected7 = new List<object> {"abcdedcba",true};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("vabba","v");
            var expected8 = new List<object> {"abba",true};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_51.Mistral.Solver.ReverseDelete("mamma","mia");
            var expected9 = new List<object> {"",true};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("abcde","ae");
            var expected1 = new List<object> {"bcd",false};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("abcdef","b");
            var expected2 = new List<object> {"acdef",false};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("abcdedcba","ab");
            var expected3 = new List<object> {"cdedc",true};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("dwik","w");
            var expected4 = new List<object> {"dik",false};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("a","a");
            var expected5 = new List<object> {"",true};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("abcdedcba","");
            var expected6 = new List<object> {"abcdedcba",true};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("abcdedcba","v");
            var expected7 = new List<object> {"abcdedcba",true};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("vabba","v");
            var expected8 = new List<object> {"abba",true};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete("mamma","mia");
            var expected9 = new List<object> {"",true};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("abcde","ae");
            var expected1 = new List<object> {"bcd",false};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("abcdef","b");
            var expected2 = new List<object> {"acdef",false};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("abcdedcba","ab");
            var expected3 = new List<object> {"cdedc",true};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("dwik","w");
            var expected4 = new List<object> {"dik",false};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("a","a");
            var expected5 = new List<object> {"",true};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("abcdedcba","");
            var expected6 = new List<object> {"abcdedcba",true};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("abcdedcba","v");
            var expected7 = new List<object> {"abcdedcba",true};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("vabba","v");
            var expected8 = new List<object> {"abba",true};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_51.Llama.Solver.ReverseDelete("mamma","mia");
            var expected9 = new List<object> {"",true};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
