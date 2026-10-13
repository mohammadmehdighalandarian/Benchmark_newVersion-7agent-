// Auto-generated Tests for Task: csharp_22
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_22
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_22.GPT.Solver.Common(new List<int> {1,4,3,34,653,2,5},new List<int> {5,7,1,5,9,653,121});
            var expected1 = new List<int> {1,5,653};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_22.GPT.Solver.Common(new List<int> {5,3,2,8},new List<int> {3,2});
            var expected2 = new List<int> {2,3};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_22.GPT.Solver.Common(new List<int> {4,3,2,8},new List<int> {3,2,4});
            var expected3 = new List<int> {2,3,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_22.GPT.Solver.Common(new List<int> {4,3,2,8},new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_22.Gemini.Solver.Common(new List<int> {1,4,3,34,653,2,5},new List<int> {5,7,1,5,9,653,121});
            var expected1 = new List<int> {1,5,653};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_22.Gemini.Solver.Common(new List<int> {5,3,2,8},new List<int> {3,2});
            var expected2 = new List<int> {2,3};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_22.Gemini.Solver.Common(new List<int> {4,3,2,8},new List<int> {3,2,4});
            var expected3 = new List<int> {2,3,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_22.Gemini.Solver.Common(new List<int> {4,3,2,8},new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_22.Claude.Solver.Common(new List<int> {1,4,3,34,653,2,5},new List<int> {5,7,1,5,9,653,121});
            var expected1 = new List<int> {1,5,653};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_22.Claude.Solver.Common(new List<int> {5,3,2,8},new List<int> {3,2});
            var expected2 = new List<int> {2,3};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_22.Claude.Solver.Common(new List<int> {4,3,2,8},new List<int> {3,2,4});
            var expected3 = new List<int> {2,3,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_22.Claude.Solver.Common(new List<int> {4,3,2,8},new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_22.Grok.Solver.Common(new List<int> {1,4,3,34,653,2,5},new List<int> {5,7,1,5,9,653,121});
            var expected1 = new List<int> {1,5,653};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_22.Grok.Solver.Common(new List<int> {5,3,2,8},new List<int> {3,2});
            var expected2 = new List<int> {2,3};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_22.Grok.Solver.Common(new List<int> {4,3,2,8},new List<int> {3,2,4});
            var expected3 = new List<int> {2,3,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_22.Grok.Solver.Common(new List<int> {4,3,2,8},new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_22.Mistral.Solver.Common(new List<int> {1,4,3,34,653,2,5},new List<int> {5,7,1,5,9,653,121});
            var expected1 = new List<int> {1,5,653};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_22.Mistral.Solver.Common(new List<int> {5,3,2,8},new List<int> {3,2});
            var expected2 = new List<int> {2,3};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_22.Mistral.Solver.Common(new List<int> {4,3,2,8},new List<int> {3,2,4});
            var expected3 = new List<int> {2,3,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_22.Mistral.Solver.Common(new List<int> {4,3,2,8},new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_22.DeepSeek.Solver.Common(new List<int> {1,4,3,34,653,2,5},new List<int> {5,7,1,5,9,653,121});
            var expected1 = new List<int> {1,5,653};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_22.DeepSeek.Solver.Common(new List<int> {5,3,2,8},new List<int> {3,2});
            var expected2 = new List<int> {2,3};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_22.DeepSeek.Solver.Common(new List<int> {4,3,2,8},new List<int> {3,2,4});
            var expected3 = new List<int> {2,3,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_22.DeepSeek.Solver.Common(new List<int> {4,3,2,8},new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_22.Llama.Solver.Common(new List<int> {1,4,3,34,653,2,5},new List<int> {5,7,1,5,9,653,121});
            var expected1 = new List<int> {1,5,653};
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_22.Llama.Solver.Common(new List<int> {5,3,2,8},new List<int> {3,2});
            var expected2 = new List<int> {2,3};
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_22.Llama.Solver.Common(new List<int> {4,3,2,8},new List<int> {3,2,4});
            var expected3 = new List<int> {2,3,4};
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_22.Llama.Solver.Common(new List<int> {4,3,2,8},new List<int> {});
            var expected4 = new List<int> {};
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
