// Auto-generated Tests for Task: csharp_63
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_63
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7});
            var expected1 = new List<object> {null,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7,0});
            var expected2 = new List<object> {null,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {1,3,2,4,5,6,-2});
            var expected3 = new List<object> {-2,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {4,5,3,6,2,7,-7});
            var expected4 = new List<object> {-7,2};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {7,3,8,4,9,2,5,-9});
            var expected5 = new List<object> {-9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {});
            var expected6 = new List<object> {null,null};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {0});
            var expected7 = new List<object> {null,null};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6});
            var expected8 = new List<object> {-1,null};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6,0});
            var expected9 = new List<object> {-1,null};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,1});
            var expected10 = new List<object> {-3,1};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,-100,1});
            var expected11 = new List<object> {-3,1};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7});
            var expected1 = new List<object> {null,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7,0});
            var expected2 = new List<object> {null,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {1,3,2,4,5,6,-2});
            var expected3 = new List<object> {-2,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {4,5,3,6,2,7,-7});
            var expected4 = new List<object> {-7,2};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {7,3,8,4,9,2,5,-9});
            var expected5 = new List<object> {-9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {});
            var expected6 = new List<object> {null,null};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {0});
            var expected7 = new List<object> {null,null};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6});
            var expected8 = new List<object> {-1,null};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6,0});
            var expected9 = new List<object> {-1,null};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,1});
            var expected10 = new List<object> {-3,1};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,-100,1});
            var expected11 = new List<object> {-3,1};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7});
            var expected1 = new List<object> {null,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7,0});
            var expected2 = new List<object> {null,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {1,3,2,4,5,6,-2});
            var expected3 = new List<object> {-2,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {4,5,3,6,2,7,-7});
            var expected4 = new List<object> {-7,2};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {7,3,8,4,9,2,5,-9});
            var expected5 = new List<object> {-9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {});
            var expected6 = new List<object> {null,null};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {0});
            var expected7 = new List<object> {null,null};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6});
            var expected8 = new List<object> {-1,null};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6,0});
            var expected9 = new List<object> {-1,null};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,1});
            var expected10 = new List<object> {-3,1};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,-100,1});
            var expected11 = new List<object> {-3,1};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7});
            var expected1 = new List<object> {null,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7,0});
            var expected2 = new List<object> {null,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {1,3,2,4,5,6,-2});
            var expected3 = new List<object> {-2,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {4,5,3,6,2,7,-7});
            var expected4 = new List<object> {-7,2};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {7,3,8,4,9,2,5,-9});
            var expected5 = new List<object> {-9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {});
            var expected6 = new List<object> {null,null};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {0});
            var expected7 = new List<object> {null,null};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6});
            var expected8 = new List<object> {-1,null};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6,0});
            var expected9 = new List<object> {-1,null};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,1});
            var expected10 = new List<object> {-3,1};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,-100,1});
            var expected11 = new List<object> {-3,1};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7});
            var expected1 = new List<object> {null,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7,0});
            var expected2 = new List<object> {null,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {1,3,2,4,5,6,-2});
            var expected3 = new List<object> {-2,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {4,5,3,6,2,7,-7});
            var expected4 = new List<object> {-7,2};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {7,3,8,4,9,2,5,-9});
            var expected5 = new List<object> {-9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {});
            var expected6 = new List<object> {null,null};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {0});
            var expected7 = new List<object> {null,null};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6});
            var expected8 = new List<object> {-1,null};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6,0});
            var expected9 = new List<object> {-1,null};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,1});
            var expected10 = new List<object> {-3,1};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,-100,1});
            var expected11 = new List<object> {-3,1};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7});
            var expected1 = new List<object> {null,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7,0});
            var expected2 = new List<object> {null,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {1,3,2,4,5,6,-2});
            var expected3 = new List<object> {-2,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {4,5,3,6,2,7,-7});
            var expected4 = new List<object> {-7,2};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {7,3,8,4,9,2,5,-9});
            var expected5 = new List<object> {-9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {});
            var expected6 = new List<object> {null,null};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {0});
            var expected7 = new List<object> {null,null};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6});
            var expected8 = new List<object> {-1,null};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6,0});
            var expected9 = new List<object> {-1,null};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,1});
            var expected10 = new List<object> {-3,1};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,-100,1});
            var expected11 = new List<object> {-3,1};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7});
            var expected1 = new List<object> {null,1};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {2,4,1,3,5,7,0});
            var expected2 = new List<object> {null,1};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {1,3,2,4,5,6,-2});
            var expected3 = new List<object> {-2,1};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {4,5,3,6,2,7,-7});
            var expected4 = new List<object> {-7,2};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {7,3,8,4,9,2,5,-9});
            var expected5 = new List<object> {-9,2};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {});
            var expected6 = new List<object> {null,null};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {0});
            var expected7 = new List<object> {null,null};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6});
            var expected8 = new List<object> {-1,null};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {-1,-3,-5,-6,0});
            var expected9 = new List<object> {-1,null};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,1});
            var expected10 = new List<object> {-3,1};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(new List<int> {-6,-4,-4,-3,-100,1});
            var expected11 = new List<object> {-3,1};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
