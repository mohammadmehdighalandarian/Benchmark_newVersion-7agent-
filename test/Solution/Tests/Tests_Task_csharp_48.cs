// Auto-generated Tests for Task: csharp_48
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_48
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(123);
            var expected1 = new List<int> {8,13};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(12);
            var expected2 = new List<int> {4,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(3);
            var expected3 = new List<int> {1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(63);
            var expected4 = new List<int> {6,8};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(25);
            var expected5 = new List<int> {5,6};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(19);
            var expected6 = new List<int> {4,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(9);
            var expected7 = new List<int> {4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(1);
            var expected8 = new List<int> {0,1};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(123);
            var expected1 = new List<int> {8,13};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(12);
            var expected2 = new List<int> {4,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(3);
            var expected3 = new List<int> {1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(63);
            var expected4 = new List<int> {6,8};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(25);
            var expected5 = new List<int> {5,6};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(19);
            var expected6 = new List<int> {4,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(9);
            var expected7 = new List<int> {4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(1);
            var expected8 = new List<int> {0,1};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(123);
            var expected1 = new List<int> {8,13};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(12);
            var expected2 = new List<int> {4,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(3);
            var expected3 = new List<int> {1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(63);
            var expected4 = new List<int> {6,8};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(25);
            var expected5 = new List<int> {5,6};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(19);
            var expected6 = new List<int> {4,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(9);
            var expected7 = new List<int> {4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(1);
            var expected8 = new List<int> {0,1};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(123);
            var expected1 = new List<int> {8,13};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(12);
            var expected2 = new List<int> {4,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(3);
            var expected3 = new List<int> {1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(63);
            var expected4 = new List<int> {6,8};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(25);
            var expected5 = new List<int> {5,6};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(19);
            var expected6 = new List<int> {4,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(9);
            var expected7 = new List<int> {4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(1);
            var expected8 = new List<int> {0,1};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(123);
            var expected1 = new List<int> {8,13};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(12);
            var expected2 = new List<int> {4,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(3);
            var expected3 = new List<int> {1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(63);
            var expected4 = new List<int> {6,8};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(25);
            var expected5 = new List<int> {5,6};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(19);
            var expected6 = new List<int> {4,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(9);
            var expected7 = new List<int> {4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(1);
            var expected8 = new List<int> {0,1};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(123);
            var expected1 = new List<int> {8,13};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(12);
            var expected2 = new List<int> {4,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(3);
            var expected3 = new List<int> {1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(63);
            var expected4 = new List<int> {6,8};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(25);
            var expected5 = new List<int> {5,6};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(19);
            var expected6 = new List<int> {4,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(9);
            var expected7 = new List<int> {4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(1);
            var expected8 = new List<int> {0,1};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(123);
            var expected1 = new List<int> {8,13};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(12);
            var expected2 = new List<int> {4,6};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(3);
            var expected3 = new List<int> {1,2};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(63);
            var expected4 = new List<int> {6,8};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(25);
            var expected5 = new List<int> {5,6};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(19);
            var expected6 = new List<int> {4,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(9);
            var expected7 = new List<int> {4,5};
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(1);
            var expected8 = new List<int> {0,1};
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
