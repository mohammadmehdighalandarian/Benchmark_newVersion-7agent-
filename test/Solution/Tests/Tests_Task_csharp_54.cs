// Auto-generated Tests for Task: csharp_54
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_54
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {-3,-4,5},3);
            var expected1 = new List<int> {-4,-3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {4,-4,4},2);
            var expected2 = new List<int> {4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {-3,2,1,2,-1,-2,1},1);
            var expected3 = new List<int> {2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {123,-123,20,0,1,2,-3},3);
            var expected4 = new List<int> {2,20,123};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {-123,20,0,1,2,-3},4);
            var expected5 = new List<int> {0,1,2,20};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {5,15,0,3,-13,-8,0},7);
            var expected6 = new List<int> {-13,-8,0,0,3,5,15};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {-1,0,2,5,3,-10},2);
            var expected7 = new List<int> {3,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {1,0,5,-7},1);
            var expected8 = new List<int> {5};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {4,-4},2);
            var expected9 = new List<int> {-4,4};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {-10,10},2);
            var expected10 = new List<int> {-10,10};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_54.GPT.Solver.Maximum(new List<int> {1,2,3,-23,243,-400,0},0);
            var expected11 = new List<int> {};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {-3,-4,5},3);
            var expected1 = new List<int> {-4,-3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {4,-4,4},2);
            var expected2 = new List<int> {4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {-3,2,1,2,-1,-2,1},1);
            var expected3 = new List<int> {2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {123,-123,20,0,1,2,-3},3);
            var expected4 = new List<int> {2,20,123};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {-123,20,0,1,2,-3},4);
            var expected5 = new List<int> {0,1,2,20};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {5,15,0,3,-13,-8,0},7);
            var expected6 = new List<int> {-13,-8,0,0,3,5,15};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {-1,0,2,5,3,-10},2);
            var expected7 = new List<int> {3,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {1,0,5,-7},1);
            var expected8 = new List<int> {5};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {4,-4},2);
            var expected9 = new List<int> {-4,4};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {-10,10},2);
            var expected10 = new List<int> {-10,10};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_54.Gemini.Solver.Maximum(new List<int> {1,2,3,-23,243,-400,0},0);
            var expected11 = new List<int> {};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {-3,-4,5},3);
            var expected1 = new List<int> {-4,-3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {4,-4,4},2);
            var expected2 = new List<int> {4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {-3,2,1,2,-1,-2,1},1);
            var expected3 = new List<int> {2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {123,-123,20,0,1,2,-3},3);
            var expected4 = new List<int> {2,20,123};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {-123,20,0,1,2,-3},4);
            var expected5 = new List<int> {0,1,2,20};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {5,15,0,3,-13,-8,0},7);
            var expected6 = new List<int> {-13,-8,0,0,3,5,15};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {-1,0,2,5,3,-10},2);
            var expected7 = new List<int> {3,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {1,0,5,-7},1);
            var expected8 = new List<int> {5};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {4,-4},2);
            var expected9 = new List<int> {-4,4};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {-10,10},2);
            var expected10 = new List<int> {-10,10};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_54.Claude.Solver.Maximum(new List<int> {1,2,3,-23,243,-400,0},0);
            var expected11 = new List<int> {};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {-3,-4,5},3);
            var expected1 = new List<int> {-4,-3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {4,-4,4},2);
            var expected2 = new List<int> {4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {-3,2,1,2,-1,-2,1},1);
            var expected3 = new List<int> {2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {123,-123,20,0,1,2,-3},3);
            var expected4 = new List<int> {2,20,123};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {-123,20,0,1,2,-3},4);
            var expected5 = new List<int> {0,1,2,20};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {5,15,0,3,-13,-8,0},7);
            var expected6 = new List<int> {-13,-8,0,0,3,5,15};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {-1,0,2,5,3,-10},2);
            var expected7 = new List<int> {3,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {1,0,5,-7},1);
            var expected8 = new List<int> {5};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {4,-4},2);
            var expected9 = new List<int> {-4,4};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {-10,10},2);
            var expected10 = new List<int> {-10,10};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_54.Grok.Solver.Maximum(new List<int> {1,2,3,-23,243,-400,0},0);
            var expected11 = new List<int> {};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {-3,-4,5},3);
            var expected1 = new List<int> {-4,-3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {4,-4,4},2);
            var expected2 = new List<int> {4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {-3,2,1,2,-1,-2,1},1);
            var expected3 = new List<int> {2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {123,-123,20,0,1,2,-3},3);
            var expected4 = new List<int> {2,20,123};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {-123,20,0,1,2,-3},4);
            var expected5 = new List<int> {0,1,2,20};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {5,15,0,3,-13,-8,0},7);
            var expected6 = new List<int> {-13,-8,0,0,3,5,15};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {-1,0,2,5,3,-10},2);
            var expected7 = new List<int> {3,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {1,0,5,-7},1);
            var expected8 = new List<int> {5};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {4,-4},2);
            var expected9 = new List<int> {-4,4};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {-10,10},2);
            var expected10 = new List<int> {-10,10};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_54.Mistral.Solver.Maximum(new List<int> {1,2,3,-23,243,-400,0},0);
            var expected11 = new List<int> {};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {-3,-4,5},3);
            var expected1 = new List<int> {-4,-3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {4,-4,4},2);
            var expected2 = new List<int> {4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {-3,2,1,2,-1,-2,1},1);
            var expected3 = new List<int> {2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {123,-123,20,0,1,2,-3},3);
            var expected4 = new List<int> {2,20,123};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {-123,20,0,1,2,-3},4);
            var expected5 = new List<int> {0,1,2,20};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {5,15,0,3,-13,-8,0},7);
            var expected6 = new List<int> {-13,-8,0,0,3,5,15};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {-1,0,2,5,3,-10},2);
            var expected7 = new List<int> {3,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {1,0,5,-7},1);
            var expected8 = new List<int> {5};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {4,-4},2);
            var expected9 = new List<int> {-4,4};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {-10,10},2);
            var expected10 = new List<int> {-10,10};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_54.DeepSeek.Solver.Maximum(new List<int> {1,2,3,-23,243,-400,0},0);
            var expected11 = new List<int> {};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {-3,-4,5},3);
            var expected1 = new List<int> {-4,-3,5};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {4,-4,4},2);
            var expected2 = new List<int> {4,4};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {-3,2,1,2,-1,-2,1},1);
            var expected3 = new List<int> {2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {123,-123,20,0,1,2,-3},3);
            var expected4 = new List<int> {2,20,123};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {-123,20,0,1,2,-3},4);
            var expected5 = new List<int> {0,1,2,20};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {5,15,0,3,-13,-8,0},7);
            var expected6 = new List<int> {-13,-8,0,0,3,5,15};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {-1,0,2,5,3,-10},2);
            var expected7 = new List<int> {3,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {1,0,5,-7},1);
            var expected8 = new List<int> {5};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {4,-4},2);
            var expected9 = new List<int> {-4,4};
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {-10,10},2);
            var expected10 = new List<int> {-10,10};
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_54.Llama.Solver.Maximum(new List<int> {1,2,3,-23,243,-400,0},0);
            var expected11 = new List<int> {};
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
