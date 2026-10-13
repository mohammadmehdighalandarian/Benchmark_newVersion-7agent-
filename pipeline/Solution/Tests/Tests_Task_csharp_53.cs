// Auto-generated Tests for Task: csharp_53
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_53
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_53.GPT.Solver.SelectWords("Mary had a little lamb",4);
            var expected1 = new List<string> {"little"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_53.GPT.Solver.SelectWords("Mary had a little lamb",3);
            var expected2 = new List<string> {"Mary","lamb"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_53.GPT.Solver.SelectWords("simple white space",2);
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_53.GPT.Solver.SelectWords("Hello world",4);
            var expected4 = new List<string> {"world"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_53.GPT.Solver.SelectWords("Uncle sam",3);
            var expected5 = new List<string> {"Uncle"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_53.GPT.Solver.SelectWords("",4);
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_53.GPT.Solver.SelectWords("a b c d e f",1);
            var expected7 = new List<string> {"b","c","d","f"};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_53.Gemini.Solver.SelectWords("Mary had a little lamb",4);
            var expected1 = new List<string> {"little"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_53.Gemini.Solver.SelectWords("Mary had a little lamb",3);
            var expected2 = new List<string> {"Mary","lamb"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_53.Gemini.Solver.SelectWords("simple white space",2);
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_53.Gemini.Solver.SelectWords("Hello world",4);
            var expected4 = new List<string> {"world"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_53.Gemini.Solver.SelectWords("Uncle sam",3);
            var expected5 = new List<string> {"Uncle"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_53.Gemini.Solver.SelectWords("",4);
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_53.Gemini.Solver.SelectWords("a b c d e f",1);
            var expected7 = new List<string> {"b","c","d","f"};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_53.Claude.Solver.SelectWords("Mary had a little lamb",4);
            var expected1 = new List<string> {"little"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_53.Claude.Solver.SelectWords("Mary had a little lamb",3);
            var expected2 = new List<string> {"Mary","lamb"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_53.Claude.Solver.SelectWords("simple white space",2);
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_53.Claude.Solver.SelectWords("Hello world",4);
            var expected4 = new List<string> {"world"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_53.Claude.Solver.SelectWords("Uncle sam",3);
            var expected5 = new List<string> {"Uncle"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_53.Claude.Solver.SelectWords("",4);
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_53.Claude.Solver.SelectWords("a b c d e f",1);
            var expected7 = new List<string> {"b","c","d","f"};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_53.Grok.Solver.SelectWords("Mary had a little lamb",4);
            var expected1 = new List<string> {"little"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_53.Grok.Solver.SelectWords("Mary had a little lamb",3);
            var expected2 = new List<string> {"Mary","lamb"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_53.Grok.Solver.SelectWords("simple white space",2);
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_53.Grok.Solver.SelectWords("Hello world",4);
            var expected4 = new List<string> {"world"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_53.Grok.Solver.SelectWords("Uncle sam",3);
            var expected5 = new List<string> {"Uncle"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_53.Grok.Solver.SelectWords("",4);
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_53.Grok.Solver.SelectWords("a b c d e f",1);
            var expected7 = new List<string> {"b","c","d","f"};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_53.Mistral.Solver.SelectWords("Mary had a little lamb",4);
            var expected1 = new List<string> {"little"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_53.Mistral.Solver.SelectWords("Mary had a little lamb",3);
            var expected2 = new List<string> {"Mary","lamb"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_53.Mistral.Solver.SelectWords("simple white space",2);
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_53.Mistral.Solver.SelectWords("Hello world",4);
            var expected4 = new List<string> {"world"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_53.Mistral.Solver.SelectWords("Uncle sam",3);
            var expected5 = new List<string> {"Uncle"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_53.Mistral.Solver.SelectWords("",4);
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_53.Mistral.Solver.SelectWords("a b c d e f",1);
            var expected7 = new List<string> {"b","c","d","f"};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_53.DeepSeek.Solver.SelectWords("Mary had a little lamb",4);
            var expected1 = new List<string> {"little"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_53.DeepSeek.Solver.SelectWords("Mary had a little lamb",3);
            var expected2 = new List<string> {"Mary","lamb"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_53.DeepSeek.Solver.SelectWords("simple white space",2);
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_53.DeepSeek.Solver.SelectWords("Hello world",4);
            var expected4 = new List<string> {"world"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_53.DeepSeek.Solver.SelectWords("Uncle sam",3);
            var expected5 = new List<string> {"Uncle"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_53.DeepSeek.Solver.SelectWords("",4);
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_53.DeepSeek.Solver.SelectWords("a b c d e f",1);
            var expected7 = new List<string> {"b","c","d","f"};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_53.Llama.Solver.SelectWords("Mary had a little lamb",4);
            var expected1 = new List<string> {"little"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_53.Llama.Solver.SelectWords("Mary had a little lamb",3);
            var expected2 = new List<string> {"Mary","lamb"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_53.Llama.Solver.SelectWords("simple white space",2);
            var expected3 = new List<string> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_53.Llama.Solver.SelectWords("Hello world",4);
            var expected4 = new List<string> {"world"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_53.Llama.Solver.SelectWords("Uncle sam",3);
            var expected5 = new List<string> {"Uncle"};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_53.Llama.Solver.SelectWords("",4);
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_53.Llama.Solver.SelectWords("a b c d e f",1);
            var expected7 = new List<string> {"b","c","d","f"};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
