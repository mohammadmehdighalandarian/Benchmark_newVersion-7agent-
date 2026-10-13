// Auto-generated Tests for Task: csharp_70
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_70
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_70.GPT.Solver.Bf("Jupiter","Neptune");
            var expected1 = new List<string> {"Saturn","Uranus"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_70.GPT.Solver.Bf("Earth","Mercury");
            var expected2 = new List<string> {"Venus"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_70.GPT.Solver.Bf("Mercury","Uranus");
            var expected3 = new List<string> {"Venus","Earth","Mars","Jupiter","Saturn"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_70.GPT.Solver.Bf("Neptune","Venus");
            var expected4 = new List<string> {"Earth","Mars","Jupiter","Saturn","Uranus"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_70.GPT.Solver.Bf("Earth","Earth");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_70.GPT.Solver.Bf("Mars","Earth");
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_70.GPT.Solver.Bf("Jupiter","Makemake");
            var expected7 = new List<string> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_70.Gemini.Solver.Bf("Jupiter","Neptune");
            var expected1 = new List<string> {"Saturn","Uranus"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_70.Gemini.Solver.Bf("Earth","Mercury");
            var expected2 = new List<string> {"Venus"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_70.Gemini.Solver.Bf("Mercury","Uranus");
            var expected3 = new List<string> {"Venus","Earth","Mars","Jupiter","Saturn"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_70.Gemini.Solver.Bf("Neptune","Venus");
            var expected4 = new List<string> {"Earth","Mars","Jupiter","Saturn","Uranus"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_70.Gemini.Solver.Bf("Earth","Earth");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_70.Gemini.Solver.Bf("Mars","Earth");
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_70.Gemini.Solver.Bf("Jupiter","Makemake");
            var expected7 = new List<string> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_70.Claude.Solver.Bf("Jupiter","Neptune");
            var expected1 = new List<string> {"Saturn","Uranus"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_70.Claude.Solver.Bf("Earth","Mercury");
            var expected2 = new List<string> {"Venus"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_70.Claude.Solver.Bf("Mercury","Uranus");
            var expected3 = new List<string> {"Venus","Earth","Mars","Jupiter","Saturn"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_70.Claude.Solver.Bf("Neptune","Venus");
            var expected4 = new List<string> {"Earth","Mars","Jupiter","Saturn","Uranus"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_70.Claude.Solver.Bf("Earth","Earth");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_70.Claude.Solver.Bf("Mars","Earth");
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_70.Claude.Solver.Bf("Jupiter","Makemake");
            var expected7 = new List<string> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_70.Grok.Solver.Bf("Jupiter","Neptune");
            var expected1 = new List<string> {"Saturn","Uranus"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_70.Grok.Solver.Bf("Earth","Mercury");
            var expected2 = new List<string> {"Venus"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_70.Grok.Solver.Bf("Mercury","Uranus");
            var expected3 = new List<string> {"Venus","Earth","Mars","Jupiter","Saturn"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_70.Grok.Solver.Bf("Neptune","Venus");
            var expected4 = new List<string> {"Earth","Mars","Jupiter","Saturn","Uranus"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_70.Grok.Solver.Bf("Earth","Earth");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_70.Grok.Solver.Bf("Mars","Earth");
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_70.Grok.Solver.Bf("Jupiter","Makemake");
            var expected7 = new List<string> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_70.Mistral.Solver.Bf("Jupiter","Neptune");
            var expected1 = new List<string> {"Saturn","Uranus"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_70.Mistral.Solver.Bf("Earth","Mercury");
            var expected2 = new List<string> {"Venus"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_70.Mistral.Solver.Bf("Mercury","Uranus");
            var expected3 = new List<string> {"Venus","Earth","Mars","Jupiter","Saturn"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_70.Mistral.Solver.Bf("Neptune","Venus");
            var expected4 = new List<string> {"Earth","Mars","Jupiter","Saturn","Uranus"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_70.Mistral.Solver.Bf("Earth","Earth");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_70.Mistral.Solver.Bf("Mars","Earth");
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_70.Mistral.Solver.Bf("Jupiter","Makemake");
            var expected7 = new List<string> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_70.DeepSeek.Solver.Bf("Jupiter","Neptune");
            var expected1 = new List<string> {"Saturn","Uranus"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_70.DeepSeek.Solver.Bf("Earth","Mercury");
            var expected2 = new List<string> {"Venus"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_70.DeepSeek.Solver.Bf("Mercury","Uranus");
            var expected3 = new List<string> {"Venus","Earth","Mars","Jupiter","Saturn"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_70.DeepSeek.Solver.Bf("Neptune","Venus");
            var expected4 = new List<string> {"Earth","Mars","Jupiter","Saturn","Uranus"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_70.DeepSeek.Solver.Bf("Earth","Earth");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_70.DeepSeek.Solver.Bf("Mars","Earth");
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_70.DeepSeek.Solver.Bf("Jupiter","Makemake");
            var expected7 = new List<string> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_70.Llama.Solver.Bf("Jupiter","Neptune");
            var expected1 = new List<string> {"Saturn","Uranus"};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_70.Llama.Solver.Bf("Earth","Mercury");
            var expected2 = new List<string> {"Venus"};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_70.Llama.Solver.Bf("Mercury","Uranus");
            var expected3 = new List<string> {"Venus","Earth","Mars","Jupiter","Saturn"};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_70.Llama.Solver.Bf("Neptune","Venus");
            var expected4 = new List<string> {"Earth","Mars","Jupiter","Saturn","Uranus"};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_70.Llama.Solver.Bf("Earth","Earth");
            var expected5 = new List<string> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_70.Llama.Solver.Bf("Mars","Earth");
            var expected6 = new List<string> {};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_70.Llama.Solver.Bf("Jupiter","Makemake");
            var expected7 = new List<string> {};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
