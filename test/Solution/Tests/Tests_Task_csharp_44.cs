// Auto-generated Tests for Task: csharp_44
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_44
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_44.GPT.Solver.WordsString("Hi, my name is John");
            var expected1 = new List<string> {"Hi","my","name","is","John"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_44.GPT.Solver.WordsString("One, two, three, four, five, six");
            var expected2 = new List<string> {"One","two","three","four","five","six"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_44.GPT.Solver.WordsString("Hi, my name");
            var expected3 = new List<string> {"Hi","my","name"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_44.GPT.Solver.WordsString("One,, two, three, four, five, six,");
            var expected4 = new List<string> {"One","two","three","four","five","six"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_44.GPT.Solver.WordsString("");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_44.GPT.Solver.WordsString("ahmed     , gamal");
            var expected6 = new List<string> {"ahmed","gamal"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_44.Gemini.Solver.WordsString("Hi, my name is John");
            var expected1 = new List<string> {"Hi","my","name","is","John"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_44.Gemini.Solver.WordsString("One, two, three, four, five, six");
            var expected2 = new List<string> {"One","two","three","four","five","six"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_44.Gemini.Solver.WordsString("Hi, my name");
            var expected3 = new List<string> {"Hi","my","name"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_44.Gemini.Solver.WordsString("One,, two, three, four, five, six,");
            var expected4 = new List<string> {"One","two","three","four","five","six"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_44.Gemini.Solver.WordsString("");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_44.Gemini.Solver.WordsString("ahmed     , gamal");
            var expected6 = new List<string> {"ahmed","gamal"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_44.Claude.Solver.WordsString("Hi, my name is John");
            var expected1 = new List<string> {"Hi","my","name","is","John"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_44.Claude.Solver.WordsString("One, two, three, four, five, six");
            var expected2 = new List<string> {"One","two","three","four","five","six"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_44.Claude.Solver.WordsString("Hi, my name");
            var expected3 = new List<string> {"Hi","my","name"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_44.Claude.Solver.WordsString("One,, two, three, four, five, six,");
            var expected4 = new List<string> {"One","two","three","four","five","six"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_44.Claude.Solver.WordsString("");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_44.Claude.Solver.WordsString("ahmed     , gamal");
            var expected6 = new List<string> {"ahmed","gamal"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_44.Grok.Solver.WordsString("Hi, my name is John");
            var expected1 = new List<string> {"Hi","my","name","is","John"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_44.Grok.Solver.WordsString("One, two, three, four, five, six");
            var expected2 = new List<string> {"One","two","three","four","five","six"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_44.Grok.Solver.WordsString("Hi, my name");
            var expected3 = new List<string> {"Hi","my","name"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_44.Grok.Solver.WordsString("One,, two, three, four, five, six,");
            var expected4 = new List<string> {"One","two","three","four","five","six"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_44.Grok.Solver.WordsString("");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_44.Grok.Solver.WordsString("ahmed     , gamal");
            var expected6 = new List<string> {"ahmed","gamal"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_44.Mistral.Solver.WordsString("Hi, my name is John");
            var expected1 = new List<string> {"Hi","my","name","is","John"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_44.Mistral.Solver.WordsString("One, two, three, four, five, six");
            var expected2 = new List<string> {"One","two","three","four","five","six"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_44.Mistral.Solver.WordsString("Hi, my name");
            var expected3 = new List<string> {"Hi","my","name"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_44.Mistral.Solver.WordsString("One,, two, three, four, five, six,");
            var expected4 = new List<string> {"One","two","three","four","five","six"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_44.Mistral.Solver.WordsString("");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_44.Mistral.Solver.WordsString("ahmed     , gamal");
            var expected6 = new List<string> {"ahmed","gamal"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_44.DeepSeek.Solver.WordsString("Hi, my name is John");
            var expected1 = new List<string> {"Hi","my","name","is","John"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_44.DeepSeek.Solver.WordsString("One, two, three, four, five, six");
            var expected2 = new List<string> {"One","two","three","four","five","six"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_44.DeepSeek.Solver.WordsString("Hi, my name");
            var expected3 = new List<string> {"Hi","my","name"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_44.DeepSeek.Solver.WordsString("One,, two, three, four, five, six,");
            var expected4 = new List<string> {"One","two","three","four","five","six"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_44.DeepSeek.Solver.WordsString("");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_44.DeepSeek.Solver.WordsString("ahmed     , gamal");
            var expected6 = new List<string> {"ahmed","gamal"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_44.Llama.Solver.WordsString("Hi, my name is John");
            var expected1 = new List<string> {"Hi","my","name","is","John"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_44.Llama.Solver.WordsString("One, two, three, four, five, six");
            var expected2 = new List<string> {"One","two","three","four","five","six"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_44.Llama.Solver.WordsString("Hi, my name");
            var expected3 = new List<string> {"Hi","my","name"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_44.Llama.Solver.WordsString("One,, two, three, four, five, six,");
            var expected4 = new List<string> {"One","two","three","four","five","six"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_44.Llama.Solver.WordsString("");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_44.Llama.Solver.WordsString("ahmed     , gamal");
            var expected6 = new List<string> {"ahmed","gamal"};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
