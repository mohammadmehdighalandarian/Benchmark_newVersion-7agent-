// Auto-generated Tests for Task: csharp_37
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_37
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_37.GPT.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected1 = new List<List<int>> {new List<int> {0,0},new List<int> {1,4},new List<int> {1,0},new List<int> {2,5},new List<int> {2,0}};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_37.GPT.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6}},2);
            var expected2 = new List<List<int>> {new List<int> {0,1},new List<int> {1,1},new List<int> {2,1},new List<int> {3,1},new List<int> {4,1},new List<int> {5,1}};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_37.GPT.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,1,3,4,5,6},new List<int> {1,2,1,4,5,6},new List<int> {1,2,3,1,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected3 = new List<List<int>> {new List<int> {0,0},new List<int> {1,0},new List<int> {2,1},new List<int> {2,0},new List<int> {3,2},new List<int> {3,0},new List<int> {4,3},new List<int> {4,0},new List<int> {5,4},new List<int> {5,0},new List<int> {6,5},new List<int> {6,0}};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_37.GPT.Solver.GetRow(new List<List<int>> {},1);
            var expected4 = new List<List<int>> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_37.GPT.Solver.GetRow(new List<List<int>> {new List<int> {1}},2);
            var expected5 = new List<List<int>> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_37.GPT.Solver.GetRow(new List<List<int>> {new List<int> {},new List<int> {1},new List<int> {1,2,3}},3);
            var expected6 = new List<List<int>> {new List<int> {2,2}};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_37.Gemini.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected1 = new List<List<int>> {new List<int> {0,0},new List<int> {1,4},new List<int> {1,0},new List<int> {2,5},new List<int> {2,0}};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_37.Gemini.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6}},2);
            var expected2 = new List<List<int>> {new List<int> {0,1},new List<int> {1,1},new List<int> {2,1},new List<int> {3,1},new List<int> {4,1},new List<int> {5,1}};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_37.Gemini.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,1,3,4,5,6},new List<int> {1,2,1,4,5,6},new List<int> {1,2,3,1,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected3 = new List<List<int>> {new List<int> {0,0},new List<int> {1,0},new List<int> {2,1},new List<int> {2,0},new List<int> {3,2},new List<int> {3,0},new List<int> {4,3},new List<int> {4,0},new List<int> {5,4},new List<int> {5,0},new List<int> {6,5},new List<int> {6,0}};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_37.Gemini.Solver.GetRow(new List<List<int>> {},1);
            var expected4 = new List<List<int>> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_37.Gemini.Solver.GetRow(new List<List<int>> {new List<int> {1}},2);
            var expected5 = new List<List<int>> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_37.Gemini.Solver.GetRow(new List<List<int>> {new List<int> {},new List<int> {1},new List<int> {1,2,3}},3);
            var expected6 = new List<List<int>> {new List<int> {2,2}};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_37.Claude.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected1 = new List<List<int>> {new List<int> {0,0},new List<int> {1,4},new List<int> {1,0},new List<int> {2,5},new List<int> {2,0}};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_37.Claude.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6}},2);
            var expected2 = new List<List<int>> {new List<int> {0,1},new List<int> {1,1},new List<int> {2,1},new List<int> {3,1},new List<int> {4,1},new List<int> {5,1}};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_37.Claude.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,1,3,4,5,6},new List<int> {1,2,1,4,5,6},new List<int> {1,2,3,1,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected3 = new List<List<int>> {new List<int> {0,0},new List<int> {1,0},new List<int> {2,1},new List<int> {2,0},new List<int> {3,2},new List<int> {3,0},new List<int> {4,3},new List<int> {4,0},new List<int> {5,4},new List<int> {5,0},new List<int> {6,5},new List<int> {6,0}};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_37.Claude.Solver.GetRow(new List<List<int>> {},1);
            var expected4 = new List<List<int>> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_37.Claude.Solver.GetRow(new List<List<int>> {new List<int> {1}},2);
            var expected5 = new List<List<int>> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_37.Claude.Solver.GetRow(new List<List<int>> {new List<int> {},new List<int> {1},new List<int> {1,2,3}},3);
            var expected6 = new List<List<int>> {new List<int> {2,2}};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_37.Grok.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected1 = new List<List<int>> {new List<int> {0,0},new List<int> {1,4},new List<int> {1,0},new List<int> {2,5},new List<int> {2,0}};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_37.Grok.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6}},2);
            var expected2 = new List<List<int>> {new List<int> {0,1},new List<int> {1,1},new List<int> {2,1},new List<int> {3,1},new List<int> {4,1},new List<int> {5,1}};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_37.Grok.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,1,3,4,5,6},new List<int> {1,2,1,4,5,6},new List<int> {1,2,3,1,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected3 = new List<List<int>> {new List<int> {0,0},new List<int> {1,0},new List<int> {2,1},new List<int> {2,0},new List<int> {3,2},new List<int> {3,0},new List<int> {4,3},new List<int> {4,0},new List<int> {5,4},new List<int> {5,0},new List<int> {6,5},new List<int> {6,0}};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_37.Grok.Solver.GetRow(new List<List<int>> {},1);
            var expected4 = new List<List<int>> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_37.Grok.Solver.GetRow(new List<List<int>> {new List<int> {1}},2);
            var expected5 = new List<List<int>> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_37.Grok.Solver.GetRow(new List<List<int>> {new List<int> {},new List<int> {1},new List<int> {1,2,3}},3);
            var expected6 = new List<List<int>> {new List<int> {2,2}};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_37.Mistral.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected1 = new List<List<int>> {new List<int> {0,0},new List<int> {1,4},new List<int> {1,0},new List<int> {2,5},new List<int> {2,0}};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_37.Mistral.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6}},2);
            var expected2 = new List<List<int>> {new List<int> {0,1},new List<int> {1,1},new List<int> {2,1},new List<int> {3,1},new List<int> {4,1},new List<int> {5,1}};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_37.Mistral.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,1,3,4,5,6},new List<int> {1,2,1,4,5,6},new List<int> {1,2,3,1,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected3 = new List<List<int>> {new List<int> {0,0},new List<int> {1,0},new List<int> {2,1},new List<int> {2,0},new List<int> {3,2},new List<int> {3,0},new List<int> {4,3},new List<int> {4,0},new List<int> {5,4},new List<int> {5,0},new List<int> {6,5},new List<int> {6,0}};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_37.Mistral.Solver.GetRow(new List<List<int>> {},1);
            var expected4 = new List<List<int>> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_37.Mistral.Solver.GetRow(new List<List<int>> {new List<int> {1}},2);
            var expected5 = new List<List<int>> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_37.Mistral.Solver.GetRow(new List<List<int>> {new List<int> {},new List<int> {1},new List<int> {1,2,3}},3);
            var expected6 = new List<List<int>> {new List<int> {2,2}};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_37.DeepSeek.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected1 = new List<List<int>> {new List<int> {0,0},new List<int> {1,4},new List<int> {1,0},new List<int> {2,5},new List<int> {2,0}};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_37.DeepSeek.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6}},2);
            var expected2 = new List<List<int>> {new List<int> {0,1},new List<int> {1,1},new List<int> {2,1},new List<int> {3,1},new List<int> {4,1},new List<int> {5,1}};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_37.DeepSeek.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,1,3,4,5,6},new List<int> {1,2,1,4,5,6},new List<int> {1,2,3,1,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected3 = new List<List<int>> {new List<int> {0,0},new List<int> {1,0},new List<int> {2,1},new List<int> {2,0},new List<int> {3,2},new List<int> {3,0},new List<int> {4,3},new List<int> {4,0},new List<int> {5,4},new List<int> {5,0},new List<int> {6,5},new List<int> {6,0}};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_37.DeepSeek.Solver.GetRow(new List<List<int>> {},1);
            var expected4 = new List<List<int>> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_37.DeepSeek.Solver.GetRow(new List<List<int>> {new List<int> {1}},2);
            var expected5 = new List<List<int>> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_37.DeepSeek.Solver.GetRow(new List<List<int>> {new List<int> {},new List<int> {1},new List<int> {1,2,3}},3);
            var expected6 = new List<List<int>> {new List<int> {2,2}};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_37.Llama.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected1 = new List<List<int>> {new List<int> {0,0},new List<int> {1,4},new List<int> {1,0},new List<int> {2,5},new List<int> {2,0}};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_37.Llama.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6}},2);
            var expected2 = new List<List<int>> {new List<int> {0,1},new List<int> {1,1},new List<int> {2,1},new List<int> {3,1},new List<int> {4,1},new List<int> {5,1}};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_37.Llama.Solver.GetRow(new List<List<int>> {new List<int> {1,2,3,4,5,6},new List<int> {1,2,3,4,5,6},new List<int> {1,1,3,4,5,6},new List<int> {1,2,1,4,5,6},new List<int> {1,2,3,1,5,6},new List<int> {1,2,3,4,1,6},new List<int> {1,2,3,4,5,1}},1);
            var expected3 = new List<List<int>> {new List<int> {0,0},new List<int> {1,0},new List<int> {2,1},new List<int> {2,0},new List<int> {3,2},new List<int> {3,0},new List<int> {4,3},new List<int> {4,0},new List<int> {5,4},new List<int> {5,0},new List<int> {6,5},new List<int> {6,0}};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_37.Llama.Solver.GetRow(new List<List<int>> {},1);
            var expected4 = new List<List<int>> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_37.Llama.Solver.GetRow(new List<List<int>> {new List<int> {1}},2);
            var expected5 = new List<List<int>> {};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_37.Llama.Solver.GetRow(new List<List<int>> {new List<int> {},new List<int> {1},new List<int> {1,2,3}},3);
            var expected6 = new List<List<int>> {new List<int> {2,2}};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
