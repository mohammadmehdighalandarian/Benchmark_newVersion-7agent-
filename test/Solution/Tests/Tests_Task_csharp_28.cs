// Auto-generated Tests for Task: csharp_28
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_28
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {5,5,5,5,1});
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {4,1,4,1,4,4});
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {3,3});
            var expected3 = -1;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {8,8,8,8,8,8,8,8});
            var expected4 = 8;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {2,3,3,2,2});
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {2,7,8,8,4,8,7,3,9,6,5,10,4,3,6,7,1,7,4,10,8,1});
            var expected6 = 1;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {3,2,8,2});
            var expected7 = 2;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {6,7,1,8,8,10,5,8,5,3,10});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {8,8,3,6,5,6,4});
            var expected9 = -1;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {6,9,6,7,1,4,7,1,8,8,9,8,10,10,8,4,10,4,10,1,2,9,5,7,9});
            var expected10 = 1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {1,9,10,1,3});
            var expected11 = 1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {6,9,7,5,8,7,5,3,7,5,10,10,3,6,10,2,8,6,5,4,9,5,3,10});
            var expected12 = 5;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {1});
            var expected13 = 1;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {8,8,10,6,4,3,5,8,2,4,2,8,4,6,10,4,2,1,10,2,1,1,5});
            var expected14 = 4;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {2,10,4,8,2,10,5,1,2,9,5,5,6,3,8,6,4,10});
            var expected15 = 2;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {1,6,10,1,6,9,10,8,6,8,7,3});
            var expected16 = 1;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");

            var actual17 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {9,2,4,1,5,1,5,2,5,7,7,7,3,10,1,5,4,2,8,4,1,9,10,7,10,2,8,10,9,4});
            var expected17 = 4;
            var result17 = compareLogic.Compare(actual17, expected17);
            TestUtils.Check(result17, "Exception --- test case 16 failed to pass");

            var actual18 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {2,6,4,2,8,7,5,6,4,10,4,6,3,7,8,8,3,1,4,2,2,10,7});
            var expected18 = 4;
            var result18 = compareLogic.Compare(actual18, expected18);
            TestUtils.Check(result18, "Exception --- test case 17 failed to pass");

            var actual19 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {9,8,6,10,2,6,10,2,7,8,10,3,8,2,6,2,3,1});
            var expected19 = 2;
            var result19 = compareLogic.Compare(actual19, expected19);
            TestUtils.Check(result19, "Exception --- test case 18 failed to pass");

            var actual20 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {5,5,3,9,5,6,3,2,8,5,6,10,10,6,8,4,10,7,7,10,8});
            var expected20 = -1;
            var result20 = compareLogic.Compare(actual20, expected20);
            TestUtils.Check(result20, "Exception --- test case 19 failed to pass");

            var actual21 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {10});
            var expected21 = -1;
            var result21 = compareLogic.Compare(actual21, expected21);
            TestUtils.Check(result21, "Exception --- test case 20 failed to pass");

            var actual22 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {9,7,7,2,4,7,2,10,9,7,5,7,2});
            var expected22 = 2;
            var result22 = compareLogic.Compare(actual22, expected22);
            TestUtils.Check(result22, "Exception --- test case 21 failed to pass");

            var actual23 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {5,4,10,2,1,1,10,3,6,1,8});
            var expected23 = 1;
            var result23 = compareLogic.Compare(actual23, expected23);
            TestUtils.Check(result23, "Exception --- test case 22 failed to pass");

            var actual24 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {7,9,9,9,3,4,1,5,9,1,2,1,1,10,7,5,6,7,6,7,7,6});
            var expected24 = 1;
            var result24 = compareLogic.Compare(actual24, expected24);
            TestUtils.Check(result24, "Exception --- test case 23 failed to pass");

            var actual25 = Benchmarks.csharp_28.GPT.Solver.Search(new List<int> {3,10,10,9,2});
            var expected25 = -1;
            var result25 = compareLogic.Compare(actual25, expected25);
            TestUtils.Check(result25, "Exception --- test case 24 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {5,5,5,5,1});
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {4,1,4,1,4,4});
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {3,3});
            var expected3 = -1;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {8,8,8,8,8,8,8,8});
            var expected4 = 8;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {2,3,3,2,2});
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {2,7,8,8,4,8,7,3,9,6,5,10,4,3,6,7,1,7,4,10,8,1});
            var expected6 = 1;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {3,2,8,2});
            var expected7 = 2;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {6,7,1,8,8,10,5,8,5,3,10});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {8,8,3,6,5,6,4});
            var expected9 = -1;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {6,9,6,7,1,4,7,1,8,8,9,8,10,10,8,4,10,4,10,1,2,9,5,7,9});
            var expected10 = 1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {1,9,10,1,3});
            var expected11 = 1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {6,9,7,5,8,7,5,3,7,5,10,10,3,6,10,2,8,6,5,4,9,5,3,10});
            var expected12 = 5;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {1});
            var expected13 = 1;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {8,8,10,6,4,3,5,8,2,4,2,8,4,6,10,4,2,1,10,2,1,1,5});
            var expected14 = 4;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {2,10,4,8,2,10,5,1,2,9,5,5,6,3,8,6,4,10});
            var expected15 = 2;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {1,6,10,1,6,9,10,8,6,8,7,3});
            var expected16 = 1;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");

            var actual17 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {9,2,4,1,5,1,5,2,5,7,7,7,3,10,1,5,4,2,8,4,1,9,10,7,10,2,8,10,9,4});
            var expected17 = 4;
            var result17 = compareLogic.Compare(actual17, expected17);
            TestUtils.Check(result17, "Exception --- test case 16 failed to pass");

            var actual18 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {2,6,4,2,8,7,5,6,4,10,4,6,3,7,8,8,3,1,4,2,2,10,7});
            var expected18 = 4;
            var result18 = compareLogic.Compare(actual18, expected18);
            TestUtils.Check(result18, "Exception --- test case 17 failed to pass");

            var actual19 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {9,8,6,10,2,6,10,2,7,8,10,3,8,2,6,2,3,1});
            var expected19 = 2;
            var result19 = compareLogic.Compare(actual19, expected19);
            TestUtils.Check(result19, "Exception --- test case 18 failed to pass");

            var actual20 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {5,5,3,9,5,6,3,2,8,5,6,10,10,6,8,4,10,7,7,10,8});
            var expected20 = -1;
            var result20 = compareLogic.Compare(actual20, expected20);
            TestUtils.Check(result20, "Exception --- test case 19 failed to pass");

            var actual21 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {10});
            var expected21 = -1;
            var result21 = compareLogic.Compare(actual21, expected21);
            TestUtils.Check(result21, "Exception --- test case 20 failed to pass");

            var actual22 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {9,7,7,2,4,7,2,10,9,7,5,7,2});
            var expected22 = 2;
            var result22 = compareLogic.Compare(actual22, expected22);
            TestUtils.Check(result22, "Exception --- test case 21 failed to pass");

            var actual23 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {5,4,10,2,1,1,10,3,6,1,8});
            var expected23 = 1;
            var result23 = compareLogic.Compare(actual23, expected23);
            TestUtils.Check(result23, "Exception --- test case 22 failed to pass");

            var actual24 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {7,9,9,9,3,4,1,5,9,1,2,1,1,10,7,5,6,7,6,7,7,6});
            var expected24 = 1;
            var result24 = compareLogic.Compare(actual24, expected24);
            TestUtils.Check(result24, "Exception --- test case 23 failed to pass");

            var actual25 = Benchmarks.csharp_28.Gemini.Solver.Search(new List<int> {3,10,10,9,2});
            var expected25 = -1;
            var result25 = compareLogic.Compare(actual25, expected25);
            TestUtils.Check(result25, "Exception --- test case 24 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {5,5,5,5,1});
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {4,1,4,1,4,4});
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {3,3});
            var expected3 = -1;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {8,8,8,8,8,8,8,8});
            var expected4 = 8;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {2,3,3,2,2});
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {2,7,8,8,4,8,7,3,9,6,5,10,4,3,6,7,1,7,4,10,8,1});
            var expected6 = 1;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {3,2,8,2});
            var expected7 = 2;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {6,7,1,8,8,10,5,8,5,3,10});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {8,8,3,6,5,6,4});
            var expected9 = -1;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {6,9,6,7,1,4,7,1,8,8,9,8,10,10,8,4,10,4,10,1,2,9,5,7,9});
            var expected10 = 1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {1,9,10,1,3});
            var expected11 = 1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {6,9,7,5,8,7,5,3,7,5,10,10,3,6,10,2,8,6,5,4,9,5,3,10});
            var expected12 = 5;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {1});
            var expected13 = 1;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {8,8,10,6,4,3,5,8,2,4,2,8,4,6,10,4,2,1,10,2,1,1,5});
            var expected14 = 4;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {2,10,4,8,2,10,5,1,2,9,5,5,6,3,8,6,4,10});
            var expected15 = 2;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {1,6,10,1,6,9,10,8,6,8,7,3});
            var expected16 = 1;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");

            var actual17 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {9,2,4,1,5,1,5,2,5,7,7,7,3,10,1,5,4,2,8,4,1,9,10,7,10,2,8,10,9,4});
            var expected17 = 4;
            var result17 = compareLogic.Compare(actual17, expected17);
            TestUtils.Check(result17, "Exception --- test case 16 failed to pass");

            var actual18 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {2,6,4,2,8,7,5,6,4,10,4,6,3,7,8,8,3,1,4,2,2,10,7});
            var expected18 = 4;
            var result18 = compareLogic.Compare(actual18, expected18);
            TestUtils.Check(result18, "Exception --- test case 17 failed to pass");

            var actual19 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {9,8,6,10,2,6,10,2,7,8,10,3,8,2,6,2,3,1});
            var expected19 = 2;
            var result19 = compareLogic.Compare(actual19, expected19);
            TestUtils.Check(result19, "Exception --- test case 18 failed to pass");

            var actual20 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {5,5,3,9,5,6,3,2,8,5,6,10,10,6,8,4,10,7,7,10,8});
            var expected20 = -1;
            var result20 = compareLogic.Compare(actual20, expected20);
            TestUtils.Check(result20, "Exception --- test case 19 failed to pass");

            var actual21 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {10});
            var expected21 = -1;
            var result21 = compareLogic.Compare(actual21, expected21);
            TestUtils.Check(result21, "Exception --- test case 20 failed to pass");

            var actual22 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {9,7,7,2,4,7,2,10,9,7,5,7,2});
            var expected22 = 2;
            var result22 = compareLogic.Compare(actual22, expected22);
            TestUtils.Check(result22, "Exception --- test case 21 failed to pass");

            var actual23 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {5,4,10,2,1,1,10,3,6,1,8});
            var expected23 = 1;
            var result23 = compareLogic.Compare(actual23, expected23);
            TestUtils.Check(result23, "Exception --- test case 22 failed to pass");

            var actual24 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {7,9,9,9,3,4,1,5,9,1,2,1,1,10,7,5,6,7,6,7,7,6});
            var expected24 = 1;
            var result24 = compareLogic.Compare(actual24, expected24);
            TestUtils.Check(result24, "Exception --- test case 23 failed to pass");

            var actual25 = Benchmarks.csharp_28.Claude.Solver.Search(new List<int> {3,10,10,9,2});
            var expected25 = -1;
            var result25 = compareLogic.Compare(actual25, expected25);
            TestUtils.Check(result25, "Exception --- test case 24 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {5,5,5,5,1});
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {4,1,4,1,4,4});
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {3,3});
            var expected3 = -1;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {8,8,8,8,8,8,8,8});
            var expected4 = 8;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {2,3,3,2,2});
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {2,7,8,8,4,8,7,3,9,6,5,10,4,3,6,7,1,7,4,10,8,1});
            var expected6 = 1;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {3,2,8,2});
            var expected7 = 2;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {6,7,1,8,8,10,5,8,5,3,10});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {8,8,3,6,5,6,4});
            var expected9 = -1;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {6,9,6,7,1,4,7,1,8,8,9,8,10,10,8,4,10,4,10,1,2,9,5,7,9});
            var expected10 = 1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {1,9,10,1,3});
            var expected11 = 1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {6,9,7,5,8,7,5,3,7,5,10,10,3,6,10,2,8,6,5,4,9,5,3,10});
            var expected12 = 5;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {1});
            var expected13 = 1;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {8,8,10,6,4,3,5,8,2,4,2,8,4,6,10,4,2,1,10,2,1,1,5});
            var expected14 = 4;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {2,10,4,8,2,10,5,1,2,9,5,5,6,3,8,6,4,10});
            var expected15 = 2;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {1,6,10,1,6,9,10,8,6,8,7,3});
            var expected16 = 1;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");

            var actual17 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {9,2,4,1,5,1,5,2,5,7,7,7,3,10,1,5,4,2,8,4,1,9,10,7,10,2,8,10,9,4});
            var expected17 = 4;
            var result17 = compareLogic.Compare(actual17, expected17);
            TestUtils.Check(result17, "Exception --- test case 16 failed to pass");

            var actual18 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {2,6,4,2,8,7,5,6,4,10,4,6,3,7,8,8,3,1,4,2,2,10,7});
            var expected18 = 4;
            var result18 = compareLogic.Compare(actual18, expected18);
            TestUtils.Check(result18, "Exception --- test case 17 failed to pass");

            var actual19 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {9,8,6,10,2,6,10,2,7,8,10,3,8,2,6,2,3,1});
            var expected19 = 2;
            var result19 = compareLogic.Compare(actual19, expected19);
            TestUtils.Check(result19, "Exception --- test case 18 failed to pass");

            var actual20 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {5,5,3,9,5,6,3,2,8,5,6,10,10,6,8,4,10,7,7,10,8});
            var expected20 = -1;
            var result20 = compareLogic.Compare(actual20, expected20);
            TestUtils.Check(result20, "Exception --- test case 19 failed to pass");

            var actual21 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {10});
            var expected21 = -1;
            var result21 = compareLogic.Compare(actual21, expected21);
            TestUtils.Check(result21, "Exception --- test case 20 failed to pass");

            var actual22 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {9,7,7,2,4,7,2,10,9,7,5,7,2});
            var expected22 = 2;
            var result22 = compareLogic.Compare(actual22, expected22);
            TestUtils.Check(result22, "Exception --- test case 21 failed to pass");

            var actual23 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {5,4,10,2,1,1,10,3,6,1,8});
            var expected23 = 1;
            var result23 = compareLogic.Compare(actual23, expected23);
            TestUtils.Check(result23, "Exception --- test case 22 failed to pass");

            var actual24 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {7,9,9,9,3,4,1,5,9,1,2,1,1,10,7,5,6,7,6,7,7,6});
            var expected24 = 1;
            var result24 = compareLogic.Compare(actual24, expected24);
            TestUtils.Check(result24, "Exception --- test case 23 failed to pass");

            var actual25 = Benchmarks.csharp_28.Grok.Solver.Search(new List<int> {3,10,10,9,2});
            var expected25 = -1;
            var result25 = compareLogic.Compare(actual25, expected25);
            TestUtils.Check(result25, "Exception --- test case 24 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {5,5,5,5,1});
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {4,1,4,1,4,4});
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {3,3});
            var expected3 = -1;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {8,8,8,8,8,8,8,8});
            var expected4 = 8;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {2,3,3,2,2});
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {2,7,8,8,4,8,7,3,9,6,5,10,4,3,6,7,1,7,4,10,8,1});
            var expected6 = 1;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {3,2,8,2});
            var expected7 = 2;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {6,7,1,8,8,10,5,8,5,3,10});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {8,8,3,6,5,6,4});
            var expected9 = -1;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {6,9,6,7,1,4,7,1,8,8,9,8,10,10,8,4,10,4,10,1,2,9,5,7,9});
            var expected10 = 1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {1,9,10,1,3});
            var expected11 = 1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {6,9,7,5,8,7,5,3,7,5,10,10,3,6,10,2,8,6,5,4,9,5,3,10});
            var expected12 = 5;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {1});
            var expected13 = 1;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {8,8,10,6,4,3,5,8,2,4,2,8,4,6,10,4,2,1,10,2,1,1,5});
            var expected14 = 4;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {2,10,4,8,2,10,5,1,2,9,5,5,6,3,8,6,4,10});
            var expected15 = 2;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {1,6,10,1,6,9,10,8,6,8,7,3});
            var expected16 = 1;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");

            var actual17 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {9,2,4,1,5,1,5,2,5,7,7,7,3,10,1,5,4,2,8,4,1,9,10,7,10,2,8,10,9,4});
            var expected17 = 4;
            var result17 = compareLogic.Compare(actual17, expected17);
            TestUtils.Check(result17, "Exception --- test case 16 failed to pass");

            var actual18 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {2,6,4,2,8,7,5,6,4,10,4,6,3,7,8,8,3,1,4,2,2,10,7});
            var expected18 = 4;
            var result18 = compareLogic.Compare(actual18, expected18);
            TestUtils.Check(result18, "Exception --- test case 17 failed to pass");

            var actual19 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {9,8,6,10,2,6,10,2,7,8,10,3,8,2,6,2,3,1});
            var expected19 = 2;
            var result19 = compareLogic.Compare(actual19, expected19);
            TestUtils.Check(result19, "Exception --- test case 18 failed to pass");

            var actual20 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {5,5,3,9,5,6,3,2,8,5,6,10,10,6,8,4,10,7,7,10,8});
            var expected20 = -1;
            var result20 = compareLogic.Compare(actual20, expected20);
            TestUtils.Check(result20, "Exception --- test case 19 failed to pass");

            var actual21 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {10});
            var expected21 = -1;
            var result21 = compareLogic.Compare(actual21, expected21);
            TestUtils.Check(result21, "Exception --- test case 20 failed to pass");

            var actual22 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {9,7,7,2,4,7,2,10,9,7,5,7,2});
            var expected22 = 2;
            var result22 = compareLogic.Compare(actual22, expected22);
            TestUtils.Check(result22, "Exception --- test case 21 failed to pass");

            var actual23 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {5,4,10,2,1,1,10,3,6,1,8});
            var expected23 = 1;
            var result23 = compareLogic.Compare(actual23, expected23);
            TestUtils.Check(result23, "Exception --- test case 22 failed to pass");

            var actual24 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {7,9,9,9,3,4,1,5,9,1,2,1,1,10,7,5,6,7,6,7,7,6});
            var expected24 = 1;
            var result24 = compareLogic.Compare(actual24, expected24);
            TestUtils.Check(result24, "Exception --- test case 23 failed to pass");

            var actual25 = Benchmarks.csharp_28.Mistral.Solver.Search(new List<int> {3,10,10,9,2});
            var expected25 = -1;
            var result25 = compareLogic.Compare(actual25, expected25);
            TestUtils.Check(result25, "Exception --- test case 24 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {5,5,5,5,1});
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {4,1,4,1,4,4});
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {3,3});
            var expected3 = -1;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {8,8,8,8,8,8,8,8});
            var expected4 = 8;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {2,3,3,2,2});
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {2,7,8,8,4,8,7,3,9,6,5,10,4,3,6,7,1,7,4,10,8,1});
            var expected6 = 1;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {3,2,8,2});
            var expected7 = 2;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {6,7,1,8,8,10,5,8,5,3,10});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {8,8,3,6,5,6,4});
            var expected9 = -1;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {6,9,6,7,1,4,7,1,8,8,9,8,10,10,8,4,10,4,10,1,2,9,5,7,9});
            var expected10 = 1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {1,9,10,1,3});
            var expected11 = 1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {6,9,7,5,8,7,5,3,7,5,10,10,3,6,10,2,8,6,5,4,9,5,3,10});
            var expected12 = 5;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {1});
            var expected13 = 1;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {8,8,10,6,4,3,5,8,2,4,2,8,4,6,10,4,2,1,10,2,1,1,5});
            var expected14 = 4;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {2,10,4,8,2,10,5,1,2,9,5,5,6,3,8,6,4,10});
            var expected15 = 2;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {1,6,10,1,6,9,10,8,6,8,7,3});
            var expected16 = 1;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");

            var actual17 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {9,2,4,1,5,1,5,2,5,7,7,7,3,10,1,5,4,2,8,4,1,9,10,7,10,2,8,10,9,4});
            var expected17 = 4;
            var result17 = compareLogic.Compare(actual17, expected17);
            TestUtils.Check(result17, "Exception --- test case 16 failed to pass");

            var actual18 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {2,6,4,2,8,7,5,6,4,10,4,6,3,7,8,8,3,1,4,2,2,10,7});
            var expected18 = 4;
            var result18 = compareLogic.Compare(actual18, expected18);
            TestUtils.Check(result18, "Exception --- test case 17 failed to pass");

            var actual19 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {9,8,6,10,2,6,10,2,7,8,10,3,8,2,6,2,3,1});
            var expected19 = 2;
            var result19 = compareLogic.Compare(actual19, expected19);
            TestUtils.Check(result19, "Exception --- test case 18 failed to pass");

            var actual20 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {5,5,3,9,5,6,3,2,8,5,6,10,10,6,8,4,10,7,7,10,8});
            var expected20 = -1;
            var result20 = compareLogic.Compare(actual20, expected20);
            TestUtils.Check(result20, "Exception --- test case 19 failed to pass");

            var actual21 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {10});
            var expected21 = -1;
            var result21 = compareLogic.Compare(actual21, expected21);
            TestUtils.Check(result21, "Exception --- test case 20 failed to pass");

            var actual22 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {9,7,7,2,4,7,2,10,9,7,5,7,2});
            var expected22 = 2;
            var result22 = compareLogic.Compare(actual22, expected22);
            TestUtils.Check(result22, "Exception --- test case 21 failed to pass");

            var actual23 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {5,4,10,2,1,1,10,3,6,1,8});
            var expected23 = 1;
            var result23 = compareLogic.Compare(actual23, expected23);
            TestUtils.Check(result23, "Exception --- test case 22 failed to pass");

            var actual24 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {7,9,9,9,3,4,1,5,9,1,2,1,1,10,7,5,6,7,6,7,7,6});
            var expected24 = 1;
            var result24 = compareLogic.Compare(actual24, expected24);
            TestUtils.Check(result24, "Exception --- test case 23 failed to pass");

            var actual25 = Benchmarks.csharp_28.DeepSeek.Solver.Search(new List<int> {3,10,10,9,2});
            var expected25 = -1;
            var result25 = compareLogic.Compare(actual25, expected25);
            TestUtils.Check(result25, "Exception --- test case 24 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {5,5,5,5,1});
            var expected1 = 1;
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {4,1,4,1,4,4});
            var expected2 = 4;
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {3,3});
            var expected3 = -1;
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {8,8,8,8,8,8,8,8});
            var expected4 = 8;
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {2,3,3,2,2});
            var expected5 = 2;
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {2,7,8,8,4,8,7,3,9,6,5,10,4,3,6,7,1,7,4,10,8,1});
            var expected6 = 1;
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {3,2,8,2});
            var expected7 = 2;
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {6,7,1,8,8,10,5,8,5,3,10});
            var expected8 = 1;
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {8,8,3,6,5,6,4});
            var expected9 = -1;
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");

            var actual10 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {6,9,6,7,1,4,7,1,8,8,9,8,10,10,8,4,10,4,10,1,2,9,5,7,9});
            var expected10 = 1;
            var result10 = compareLogic.Compare(actual10, expected10);
            TestUtils.Check(result10, "Exception --- test case 9 failed to pass");

            var actual11 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {1,9,10,1,3});
            var expected11 = 1;
            var result11 = compareLogic.Compare(actual11, expected11);
            TestUtils.Check(result11, "Exception --- test case 10 failed to pass");

            var actual12 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {6,9,7,5,8,7,5,3,7,5,10,10,3,6,10,2,8,6,5,4,9,5,3,10});
            var expected12 = 5;
            var result12 = compareLogic.Compare(actual12, expected12);
            TestUtils.Check(result12, "Exception --- test case 11 failed to pass");

            var actual13 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {1});
            var expected13 = 1;
            var result13 = compareLogic.Compare(actual13, expected13);
            TestUtils.Check(result13, "Exception --- test case 12 failed to pass");

            var actual14 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {8,8,10,6,4,3,5,8,2,4,2,8,4,6,10,4,2,1,10,2,1,1,5});
            var expected14 = 4;
            var result14 = compareLogic.Compare(actual14, expected14);
            TestUtils.Check(result14, "Exception --- test case 13 failed to pass");

            var actual15 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {2,10,4,8,2,10,5,1,2,9,5,5,6,3,8,6,4,10});
            var expected15 = 2;
            var result15 = compareLogic.Compare(actual15, expected15);
            TestUtils.Check(result15, "Exception --- test case 14 failed to pass");

            var actual16 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {1,6,10,1,6,9,10,8,6,8,7,3});
            var expected16 = 1;
            var result16 = compareLogic.Compare(actual16, expected16);
            TestUtils.Check(result16, "Exception --- test case 15 failed to pass");

            var actual17 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {9,2,4,1,5,1,5,2,5,7,7,7,3,10,1,5,4,2,8,4,1,9,10,7,10,2,8,10,9,4});
            var expected17 = 4;
            var result17 = compareLogic.Compare(actual17, expected17);
            TestUtils.Check(result17, "Exception --- test case 16 failed to pass");

            var actual18 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {2,6,4,2,8,7,5,6,4,10,4,6,3,7,8,8,3,1,4,2,2,10,7});
            var expected18 = 4;
            var result18 = compareLogic.Compare(actual18, expected18);
            TestUtils.Check(result18, "Exception --- test case 17 failed to pass");

            var actual19 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {9,8,6,10,2,6,10,2,7,8,10,3,8,2,6,2,3,1});
            var expected19 = 2;
            var result19 = compareLogic.Compare(actual19, expected19);
            TestUtils.Check(result19, "Exception --- test case 18 failed to pass");

            var actual20 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {5,5,3,9,5,6,3,2,8,5,6,10,10,6,8,4,10,7,7,10,8});
            var expected20 = -1;
            var result20 = compareLogic.Compare(actual20, expected20);
            TestUtils.Check(result20, "Exception --- test case 19 failed to pass");

            var actual21 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {10});
            var expected21 = -1;
            var result21 = compareLogic.Compare(actual21, expected21);
            TestUtils.Check(result21, "Exception --- test case 20 failed to pass");

            var actual22 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {9,7,7,2,4,7,2,10,9,7,5,7,2});
            var expected22 = 2;
            var result22 = compareLogic.Compare(actual22, expected22);
            TestUtils.Check(result22, "Exception --- test case 21 failed to pass");

            var actual23 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {5,4,10,2,1,1,10,3,6,1,8});
            var expected23 = 1;
            var result23 = compareLogic.Compare(actual23, expected23);
            TestUtils.Check(result23, "Exception --- test case 22 failed to pass");

            var actual24 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {7,9,9,9,3,4,1,5,9,1,2,1,1,10,7,5,6,7,6,7,7,6});
            var expected24 = 1;
            var result24 = compareLogic.Compare(actual24, expected24);
            TestUtils.Check(result24, "Exception --- test case 23 failed to pass");

            var actual25 = Benchmarks.csharp_28.Llama.Solver.Search(new List<int> {3,10,10,9,2});
            var expected25 = -1;
            var result25 = compareLogic.Compare(actual25, expected25);
            TestUtils.Check(result25, "Exception --- test case 24 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
