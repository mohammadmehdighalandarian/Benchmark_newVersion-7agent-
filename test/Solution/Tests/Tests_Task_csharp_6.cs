// Auto-generated Tests for Task: csharp_6
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_6
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_6.GPT.Solver.RescaleToUnit(new List<double> {2.0,49.9});
            var expected1 = new List<double> {0.0,1.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_6.GPT.Solver.RescaleToUnit(new List<double> {100.0,49.9});
            var expected2 = new List<double> {1.0,0.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_6.GPT.Solver.RescaleToUnit(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = new List<double> {0.0,0.25,0.5,0.75,1.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_6.GPT.Solver.RescaleToUnit(new List<double> {2.0,1.0,5.0,3.0,4.0});
            var expected4 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_6.GPT.Solver.RescaleToUnit(new List<double> {12.0,11.0,15.0,13.0,14.0});
            var expected5 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_6.Gemini.Solver.RescaleToUnit(new List<double> {2.0,49.9});
            var expected1 = new List<double> {0.0,1.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_6.Gemini.Solver.RescaleToUnit(new List<double> {100.0,49.9});
            var expected2 = new List<double> {1.0,0.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_6.Gemini.Solver.RescaleToUnit(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = new List<double> {0.0,0.25,0.5,0.75,1.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_6.Gemini.Solver.RescaleToUnit(new List<double> {2.0,1.0,5.0,3.0,4.0});
            var expected4 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_6.Gemini.Solver.RescaleToUnit(new List<double> {12.0,11.0,15.0,13.0,14.0});
            var expected5 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_6.Claude.Solver.RescaleToUnit(new List<double> {2.0,49.9});
            var expected1 = new List<double> {0.0,1.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_6.Claude.Solver.RescaleToUnit(new List<double> {100.0,49.9});
            var expected2 = new List<double> {1.0,0.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_6.Claude.Solver.RescaleToUnit(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = new List<double> {0.0,0.25,0.5,0.75,1.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_6.Claude.Solver.RescaleToUnit(new List<double> {2.0,1.0,5.0,3.0,4.0});
            var expected4 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_6.Claude.Solver.RescaleToUnit(new List<double> {12.0,11.0,15.0,13.0,14.0});
            var expected5 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_6.Grok.Solver.RescaleToUnit(new List<double> {2.0,49.9});
            var expected1 = new List<double> {0.0,1.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_6.Grok.Solver.RescaleToUnit(new List<double> {100.0,49.9});
            var expected2 = new List<double> {1.0,0.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_6.Grok.Solver.RescaleToUnit(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = new List<double> {0.0,0.25,0.5,0.75,1.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_6.Grok.Solver.RescaleToUnit(new List<double> {2.0,1.0,5.0,3.0,4.0});
            var expected4 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_6.Grok.Solver.RescaleToUnit(new List<double> {12.0,11.0,15.0,13.0,14.0});
            var expected5 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_6.Mistral.Solver.RescaleToUnit(new List<double> {2.0,49.9});
            var expected1 = new List<double> {0.0,1.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_6.Mistral.Solver.RescaleToUnit(new List<double> {100.0,49.9});
            var expected2 = new List<double> {1.0,0.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_6.Mistral.Solver.RescaleToUnit(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = new List<double> {0.0,0.25,0.5,0.75,1.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_6.Mistral.Solver.RescaleToUnit(new List<double> {2.0,1.0,5.0,3.0,4.0});
            var expected4 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_6.Mistral.Solver.RescaleToUnit(new List<double> {12.0,11.0,15.0,13.0,14.0});
            var expected5 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_6.DeepSeek.Solver.RescaleToUnit(new List<double> {2.0,49.9});
            var expected1 = new List<double> {0.0,1.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_6.DeepSeek.Solver.RescaleToUnit(new List<double> {100.0,49.9});
            var expected2 = new List<double> {1.0,0.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_6.DeepSeek.Solver.RescaleToUnit(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = new List<double> {0.0,0.25,0.5,0.75,1.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_6.DeepSeek.Solver.RescaleToUnit(new List<double> {2.0,1.0,5.0,3.0,4.0});
            var expected4 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_6.DeepSeek.Solver.RescaleToUnit(new List<double> {12.0,11.0,15.0,13.0,14.0});
            var expected5 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_6.Llama.Solver.RescaleToUnit(new List<double> {2.0,49.9});
            var expected1 = new List<double> {0.0,1.0};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_6.Llama.Solver.RescaleToUnit(new List<double> {100.0,49.9});
            var expected2 = new List<double> {1.0,0.0};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_6.Llama.Solver.RescaleToUnit(new List<double> {1.0,2.0,3.0,4.0,5.0});
            var expected3 = new List<double> {0.0,0.25,0.5,0.75,1.0};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_6.Llama.Solver.RescaleToUnit(new List<double> {2.0,1.0,5.0,3.0,4.0});
            var expected4 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_6.Llama.Solver.RescaleToUnit(new List<double> {12.0,11.0,15.0,13.0,14.0});
            var expected5 = new List<double> {0.25,0.0,1.0,0.5,0.75};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
