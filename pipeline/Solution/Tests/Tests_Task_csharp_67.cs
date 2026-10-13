// Auto-generated Tests for Task: csharp_67
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_67
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_67.GPT.Solver.OrderByPoints(new List<int> {1,11,-1,-11,-12});
            var expected1 = new List<int> {-1,-11,1,-12,11};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_67.GPT.Solver.OrderByPoints(new List<int> {1234,423,463,145,2,423,423,53,6,37,3457,3,56,0,46});
            var expected2 = new List<int> {0,2,3,6,53,423,423,423,1234,145,37,46,56,463,3457};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_67.GPT.Solver.OrderByPoints(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_67.GPT.Solver.OrderByPoints(new List<int> {1,-11,-32,43,54,-98,2,-3});
            var expected4 = new List<int> {-3,-32,-98,-11,1,2,43,54};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_67.GPT.Solver.OrderByPoints(new List<int> {1,2,3,4,5,6,7,8,9,10,11});
            var expected5 = new List<int> {1,10,2,11,3,4,5,6,7,8,9};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_67.GPT.Solver.OrderByPoints(new List<int> {0,6,6,-76,-21,23,4});
            var expected6 = new List<int> {-76,-21,0,4,23,6,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_67.Gemini.Solver.OrderByPoints(new List<int> {1,11,-1,-11,-12});
            var expected1 = new List<int> {-1,-11,1,-12,11};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_67.Gemini.Solver.OrderByPoints(new List<int> {1234,423,463,145,2,423,423,53,6,37,3457,3,56,0,46});
            var expected2 = new List<int> {0,2,3,6,53,423,423,423,1234,145,37,46,56,463,3457};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_67.Gemini.Solver.OrderByPoints(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_67.Gemini.Solver.OrderByPoints(new List<int> {1,-11,-32,43,54,-98,2,-3});
            var expected4 = new List<int> {-3,-32,-98,-11,1,2,43,54};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_67.Gemini.Solver.OrderByPoints(new List<int> {1,2,3,4,5,6,7,8,9,10,11});
            var expected5 = new List<int> {1,10,2,11,3,4,5,6,7,8,9};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_67.Gemini.Solver.OrderByPoints(new List<int> {0,6,6,-76,-21,23,4});
            var expected6 = new List<int> {-76,-21,0,4,23,6,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_67.Claude.Solver.OrderByPoints(new List<int> {1,11,-1,-11,-12});
            var expected1 = new List<int> {-1,-11,1,-12,11};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_67.Claude.Solver.OrderByPoints(new List<int> {1234,423,463,145,2,423,423,53,6,37,3457,3,56,0,46});
            var expected2 = new List<int> {0,2,3,6,53,423,423,423,1234,145,37,46,56,463,3457};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_67.Claude.Solver.OrderByPoints(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_67.Claude.Solver.OrderByPoints(new List<int> {1,-11,-32,43,54,-98,2,-3});
            var expected4 = new List<int> {-3,-32,-98,-11,1,2,43,54};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_67.Claude.Solver.OrderByPoints(new List<int> {1,2,3,4,5,6,7,8,9,10,11});
            var expected5 = new List<int> {1,10,2,11,3,4,5,6,7,8,9};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_67.Claude.Solver.OrderByPoints(new List<int> {0,6,6,-76,-21,23,4});
            var expected6 = new List<int> {-76,-21,0,4,23,6,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_67.Grok.Solver.OrderByPoints(new List<int> {1,11,-1,-11,-12});
            var expected1 = new List<int> {-1,-11,1,-12,11};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_67.Grok.Solver.OrderByPoints(new List<int> {1234,423,463,145,2,423,423,53,6,37,3457,3,56,0,46});
            var expected2 = new List<int> {0,2,3,6,53,423,423,423,1234,145,37,46,56,463,3457};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_67.Grok.Solver.OrderByPoints(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_67.Grok.Solver.OrderByPoints(new List<int> {1,-11,-32,43,54,-98,2,-3});
            var expected4 = new List<int> {-3,-32,-98,-11,1,2,43,54};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_67.Grok.Solver.OrderByPoints(new List<int> {1,2,3,4,5,6,7,8,9,10,11});
            var expected5 = new List<int> {1,10,2,11,3,4,5,6,7,8,9};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_67.Grok.Solver.OrderByPoints(new List<int> {0,6,6,-76,-21,23,4});
            var expected6 = new List<int> {-76,-21,0,4,23,6,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_67.Mistral.Solver.OrderByPoints(new List<int> {1,11,-1,-11,-12});
            var expected1 = new List<int> {-1,-11,1,-12,11};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_67.Mistral.Solver.OrderByPoints(new List<int> {1234,423,463,145,2,423,423,53,6,37,3457,3,56,0,46});
            var expected2 = new List<int> {0,2,3,6,53,423,423,423,1234,145,37,46,56,463,3457};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_67.Mistral.Solver.OrderByPoints(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_67.Mistral.Solver.OrderByPoints(new List<int> {1,-11,-32,43,54,-98,2,-3});
            var expected4 = new List<int> {-3,-32,-98,-11,1,2,43,54};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_67.Mistral.Solver.OrderByPoints(new List<int> {1,2,3,4,5,6,7,8,9,10,11});
            var expected5 = new List<int> {1,10,2,11,3,4,5,6,7,8,9};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_67.Mistral.Solver.OrderByPoints(new List<int> {0,6,6,-76,-21,23,4});
            var expected6 = new List<int> {-76,-21,0,4,23,6,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_67.DeepSeek.Solver.OrderByPoints(new List<int> {1,11,-1,-11,-12});
            var expected1 = new List<int> {-1,-11,1,-12,11};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_67.DeepSeek.Solver.OrderByPoints(new List<int> {1234,423,463,145,2,423,423,53,6,37,3457,3,56,0,46});
            var expected2 = new List<int> {0,2,3,6,53,423,423,423,1234,145,37,46,56,463,3457};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_67.DeepSeek.Solver.OrderByPoints(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_67.DeepSeek.Solver.OrderByPoints(new List<int> {1,-11,-32,43,54,-98,2,-3});
            var expected4 = new List<int> {-3,-32,-98,-11,1,2,43,54};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_67.DeepSeek.Solver.OrderByPoints(new List<int> {1,2,3,4,5,6,7,8,9,10,11});
            var expected5 = new List<int> {1,10,2,11,3,4,5,6,7,8,9};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_67.DeepSeek.Solver.OrderByPoints(new List<int> {0,6,6,-76,-21,23,4});
            var expected6 = new List<int> {-76,-21,0,4,23,6,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_67.Llama.Solver.OrderByPoints(new List<int> {1,11,-1,-11,-12});
            var expected1 = new List<int> {-1,-11,1,-12,11};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_67.Llama.Solver.OrderByPoints(new List<int> {1234,423,463,145,2,423,423,53,6,37,3457,3,56,0,46});
            var expected2 = new List<int> {0,2,3,6,53,423,423,423,1234,145,37,46,56,463,3457};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_67.Llama.Solver.OrderByPoints(new List<int> {});
            var expected3 = new List<int> {};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_67.Llama.Solver.OrderByPoints(new List<int> {1,-11,-32,43,54,-98,2,-3});
            var expected4 = new List<int> {-3,-32,-98,-11,1,2,43,54};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_67.Llama.Solver.OrderByPoints(new List<int> {1,2,3,4,5,6,7,8,9,10,11});
            var expected5 = new List<int> {1,10,2,11,3,4,5,6,7,8,9};
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_67.Llama.Solver.OrderByPoints(new List<int> {0,6,6,-76,-21,23,4});
            var expected6 = new List<int> {-76,-21,0,4,23,6,6};
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
