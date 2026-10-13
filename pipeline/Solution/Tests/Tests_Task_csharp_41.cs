// Auto-generated Tests for Task: csharp_41
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_41
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_41.GPT.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"b", "banana"}});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_41.GPT.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"A", "banana"},{"B", "banana"}});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_41.GPT.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{5, "banana"},{"a", "apple"}});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_41.GPT.Solver.CheckDictCase(new Dictionary<object, string> {{"Name", "John"},{"Age", "36"},{"City", "Houston"}});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_41.GPT.Solver.CheckDictCase(new Dictionary<object, string> {{"STATE", "NC"},{"ZIP", "12345"}});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_41.GPT.Solver.CheckDictCase(new Dictionary<object, string> {{"fruit", "Orange"},{"taste", "Sweet"}});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_41.GPT.Solver.CheckDictCase(new Dictionary<object, string> {});
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_41.Gemini.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"b", "banana"}});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_41.Gemini.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"A", "banana"},{"B", "banana"}});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_41.Gemini.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{5, "banana"},{"a", "apple"}});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_41.Gemini.Solver.CheckDictCase(new Dictionary<object, string> {{"Name", "John"},{"Age", "36"},{"City", "Houston"}});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_41.Gemini.Solver.CheckDictCase(new Dictionary<object, string> {{"STATE", "NC"},{"ZIP", "12345"}});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_41.Gemini.Solver.CheckDictCase(new Dictionary<object, string> {{"fruit", "Orange"},{"taste", "Sweet"}});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_41.Gemini.Solver.CheckDictCase(new Dictionary<object, string> {});
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_41.Claude.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"b", "banana"}});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_41.Claude.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"A", "banana"},{"B", "banana"}});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_41.Claude.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{5, "banana"},{"a", "apple"}});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_41.Claude.Solver.CheckDictCase(new Dictionary<object, string> {{"Name", "John"},{"Age", "36"},{"City", "Houston"}});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_41.Claude.Solver.CheckDictCase(new Dictionary<object, string> {{"STATE", "NC"},{"ZIP", "12345"}});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_41.Claude.Solver.CheckDictCase(new Dictionary<object, string> {{"fruit", "Orange"},{"taste", "Sweet"}});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_41.Claude.Solver.CheckDictCase(new Dictionary<object, string> {});
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_41.Grok.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"b", "banana"}});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_41.Grok.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"A", "banana"},{"B", "banana"}});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_41.Grok.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{5, "banana"},{"a", "apple"}});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_41.Grok.Solver.CheckDictCase(new Dictionary<object, string> {{"Name", "John"},{"Age", "36"},{"City", "Houston"}});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_41.Grok.Solver.CheckDictCase(new Dictionary<object, string> {{"STATE", "NC"},{"ZIP", "12345"}});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_41.Grok.Solver.CheckDictCase(new Dictionary<object, string> {{"fruit", "Orange"},{"taste", "Sweet"}});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_41.Grok.Solver.CheckDictCase(new Dictionary<object, string> {});
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_41.Mistral.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"b", "banana"}});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_41.Mistral.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"A", "banana"},{"B", "banana"}});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_41.Mistral.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{5, "banana"},{"a", "apple"}});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_41.Mistral.Solver.CheckDictCase(new Dictionary<object, string> {{"Name", "John"},{"Age", "36"},{"City", "Houston"}});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_41.Mistral.Solver.CheckDictCase(new Dictionary<object, string> {{"STATE", "NC"},{"ZIP", "12345"}});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_41.Mistral.Solver.CheckDictCase(new Dictionary<object, string> {{"fruit", "Orange"},{"taste", "Sweet"}});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_41.Mistral.Solver.CheckDictCase(new Dictionary<object, string> {});
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_41.DeepSeek.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"b", "banana"}});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_41.DeepSeek.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"A", "banana"},{"B", "banana"}});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_41.DeepSeek.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{5, "banana"},{"a", "apple"}});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_41.DeepSeek.Solver.CheckDictCase(new Dictionary<object, string> {{"Name", "John"},{"Age", "36"},{"City", "Houston"}});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_41.DeepSeek.Solver.CheckDictCase(new Dictionary<object, string> {{"STATE", "NC"},{"ZIP", "12345"}});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_41.DeepSeek.Solver.CheckDictCase(new Dictionary<object, string> {{"fruit", "Orange"},{"taste", "Sweet"}});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_41.DeepSeek.Solver.CheckDictCase(new Dictionary<object, string> {});
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_41.Llama.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"b", "banana"}});
            var expected1 = true;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_41.Llama.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{"A", "banana"},{"B", "banana"}});
            var expected2 = false;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_41.Llama.Solver.CheckDictCase(new Dictionary<object, string> {{"p", "pineapple"},{5, "banana"},{"a", "apple"}});
            var expected3 = false;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_41.Llama.Solver.CheckDictCase(new Dictionary<object, string> {{"Name", "John"},{"Age", "36"},{"City", "Houston"}});
            var expected4 = false;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_41.Llama.Solver.CheckDictCase(new Dictionary<object, string> {{"STATE", "NC"},{"ZIP", "12345"}});
            var expected5 = true;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_41.Llama.Solver.CheckDictCase(new Dictionary<object, string> {{"fruit", "Orange"},{"taste", "Sweet"}});
            var expected6 = true;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_41.Llama.Solver.CheckDictCase(new Dictionary<object, string> {});
            var expected7 = false;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
