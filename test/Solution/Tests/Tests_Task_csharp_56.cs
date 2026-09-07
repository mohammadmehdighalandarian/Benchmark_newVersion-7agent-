// Auto-generated Tests for Task: csharp_56
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_56
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_56.GPT.Solver.Intersection(new List<int> {1,2},new List<int> {2,3});
            var expected1 = "NO";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_56.GPT.Solver.Intersection(new List<int> {-1,1},new List<int> {0,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_56.GPT.Solver.Intersection(new List<int> {-3,-1},new List<int> {-5,5});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_56.GPT.Solver.Intersection(new List<int> {-2,2},new List<int> {-4,0});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_56.GPT.Solver.Intersection(new List<int> {-11,2},new List<int> {-1,-1});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_56.GPT.Solver.Intersection(new List<int> {1,2},new List<int> {3,5});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_56.GPT.Solver.Intersection(new List<int> {1,2},new List<int> {1,2});
            var expected7 = "NO";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_56.GPT.Solver.Intersection(new List<int> {-2,-2},new List<int> {-3,-2});
            var expected8 = "NO";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_56.Gemini.Solver.Intersection(new List<int> {1,2},new List<int> {2,3});
            var expected1 = "NO";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_56.Gemini.Solver.Intersection(new List<int> {-1,1},new List<int> {0,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_56.Gemini.Solver.Intersection(new List<int> {-3,-1},new List<int> {-5,5});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_56.Gemini.Solver.Intersection(new List<int> {-2,2},new List<int> {-4,0});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_56.Gemini.Solver.Intersection(new List<int> {-11,2},new List<int> {-1,-1});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_56.Gemini.Solver.Intersection(new List<int> {1,2},new List<int> {3,5});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_56.Gemini.Solver.Intersection(new List<int> {1,2},new List<int> {1,2});
            var expected7 = "NO";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_56.Gemini.Solver.Intersection(new List<int> {-2,-2},new List<int> {-3,-2});
            var expected8 = "NO";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_56.Claude.Solver.Intersection(new List<int> {1,2},new List<int> {2,3});
            var expected1 = "NO";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_56.Claude.Solver.Intersection(new List<int> {-1,1},new List<int> {0,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_56.Claude.Solver.Intersection(new List<int> {-3,-1},new List<int> {-5,5});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_56.Claude.Solver.Intersection(new List<int> {-2,2},new List<int> {-4,0});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_56.Claude.Solver.Intersection(new List<int> {-11,2},new List<int> {-1,-1});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_56.Claude.Solver.Intersection(new List<int> {1,2},new List<int> {3,5});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_56.Claude.Solver.Intersection(new List<int> {1,2},new List<int> {1,2});
            var expected7 = "NO";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_56.Claude.Solver.Intersection(new List<int> {-2,-2},new List<int> {-3,-2});
            var expected8 = "NO";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_56.Grok.Solver.Intersection(new List<int> {1,2},new List<int> {2,3});
            var expected1 = "NO";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_56.Grok.Solver.Intersection(new List<int> {-1,1},new List<int> {0,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_56.Grok.Solver.Intersection(new List<int> {-3,-1},new List<int> {-5,5});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_56.Grok.Solver.Intersection(new List<int> {-2,2},new List<int> {-4,0});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_56.Grok.Solver.Intersection(new List<int> {-11,2},new List<int> {-1,-1});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_56.Grok.Solver.Intersection(new List<int> {1,2},new List<int> {3,5});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_56.Grok.Solver.Intersection(new List<int> {1,2},new List<int> {1,2});
            var expected7 = "NO";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_56.Grok.Solver.Intersection(new List<int> {-2,-2},new List<int> {-3,-2});
            var expected8 = "NO";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_56.Mistral.Solver.Intersection(new List<int> {1,2},new List<int> {2,3});
            var expected1 = "NO";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_56.Mistral.Solver.Intersection(new List<int> {-1,1},new List<int> {0,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_56.Mistral.Solver.Intersection(new List<int> {-3,-1},new List<int> {-5,5});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_56.Mistral.Solver.Intersection(new List<int> {-2,2},new List<int> {-4,0});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_56.Mistral.Solver.Intersection(new List<int> {-11,2},new List<int> {-1,-1});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_56.Mistral.Solver.Intersection(new List<int> {1,2},new List<int> {3,5});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_56.Mistral.Solver.Intersection(new List<int> {1,2},new List<int> {1,2});
            var expected7 = "NO";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_56.Mistral.Solver.Intersection(new List<int> {-2,-2},new List<int> {-3,-2});
            var expected8 = "NO";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(new List<int> {1,2},new List<int> {2,3});
            var expected1 = "NO";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(new List<int> {-1,1},new List<int> {0,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(new List<int> {-3,-1},new List<int> {-5,5});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(new List<int> {-2,2},new List<int> {-4,0});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(new List<int> {-11,2},new List<int> {-1,-1});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(new List<int> {1,2},new List<int> {3,5});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(new List<int> {1,2},new List<int> {1,2});
            var expected7 = "NO";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(new List<int> {-2,-2},new List<int> {-3,-2});
            var expected8 = "NO";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_56.Llama.Solver.Intersection(new List<int> {1,2},new List<int> {2,3});
            var expected1 = "NO";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_56.Llama.Solver.Intersection(new List<int> {-1,1},new List<int> {0,4});
            var expected2 = "NO";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_56.Llama.Solver.Intersection(new List<int> {-3,-1},new List<int> {-5,5});
            var expected3 = "YES";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_56.Llama.Solver.Intersection(new List<int> {-2,2},new List<int> {-4,0});
            var expected4 = "YES";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_56.Llama.Solver.Intersection(new List<int> {-11,2},new List<int> {-1,-1});
            var expected5 = "NO";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_56.Llama.Solver.Intersection(new List<int> {1,2},new List<int> {3,5});
            var expected6 = "NO";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_56.Llama.Solver.Intersection(new List<int> {1,2},new List<int> {1,2});
            var expected7 = "NO";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_56.Llama.Solver.Intersection(new List<int> {-2,-2},new List<int> {-3,-2});
            var expected8 = "NO";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
