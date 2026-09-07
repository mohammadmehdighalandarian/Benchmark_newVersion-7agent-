// Auto-generated Tests for Task: csharp_73
using System;
using System.Collections.Generic;
using System.Linq;
using KellermanSoftware.CompareNetObjects;
using Tests.Shared;

namespace Tests.csharp_73
{
    public class TestRunner
    {
        public void Run_GPT()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("Watashi",new List<string> {"tEN","niNE","eIGHt8OKe"});
            var expected1 = "Watashi.eIGHt8OKe";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("Boku123",new List<string> {"nani","NazeDa","YEs.WeCaNe","32145tggg"});
            var expected2 = "Boku123.YEs.WeCaNe";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("__YESIMHERE",new List<string> {"t","eMptY","nothing","zeR00","NuLl__","123NoooneB321"});
            var expected3 = "__YESIMHERE.NuLl__";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("K",new List<string> {"Ta","TAR","t234An","cosSo"});
            var expected4 = "K.TAR";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("__HAHA",new List<string> {"Tab","123","781345","-_-"});
            var expected5 = "__HAHA.123";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("YameRore",new List<string> {"HhAas","okIWILL123","WorkOut","Fails","-_-"});
            var expected6 = "YameRore.okIWILL123";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("finNNalLLly",new List<string> {"Die","NowW","Wow","WoW"});
            var expected7 = "finNNalLLly.WoW";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("_",new List<string> {"Bb","91245"});
            var expected8 = "_.Bb";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_73.GPT.Solver.StrongestExtension("Sp",new List<string> {"671235","Bb"});
            var expected9 = "Sp.671235";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Gemini()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("Watashi",new List<string> {"tEN","niNE","eIGHt8OKe"});
            var expected1 = "Watashi.eIGHt8OKe";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("Boku123",new List<string> {"nani","NazeDa","YEs.WeCaNe","32145tggg"});
            var expected2 = "Boku123.YEs.WeCaNe";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("__YESIMHERE",new List<string> {"t","eMptY","nothing","zeR00","NuLl__","123NoooneB321"});
            var expected3 = "__YESIMHERE.NuLl__";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("K",new List<string> {"Ta","TAR","t234An","cosSo"});
            var expected4 = "K.TAR";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("__HAHA",new List<string> {"Tab","123","781345","-_-"});
            var expected5 = "__HAHA.123";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("YameRore",new List<string> {"HhAas","okIWILL123","WorkOut","Fails","-_-"});
            var expected6 = "YameRore.okIWILL123";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("finNNalLLly",new List<string> {"Die","NowW","Wow","WoW"});
            var expected7 = "finNNalLLly.WoW";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("_",new List<string> {"Bb","91245"});
            var expected8 = "_.Bb";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_73.Gemini.Solver.StrongestExtension("Sp",new List<string> {"671235","Bb"});
            var expected9 = "Sp.671235";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Claude()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("Watashi",new List<string> {"tEN","niNE","eIGHt8OKe"});
            var expected1 = "Watashi.eIGHt8OKe";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("Boku123",new List<string> {"nani","NazeDa","YEs.WeCaNe","32145tggg"});
            var expected2 = "Boku123.YEs.WeCaNe";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("__YESIMHERE",new List<string> {"t","eMptY","nothing","zeR00","NuLl__","123NoooneB321"});
            var expected3 = "__YESIMHERE.NuLl__";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("K",new List<string> {"Ta","TAR","t234An","cosSo"});
            var expected4 = "K.TAR";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("__HAHA",new List<string> {"Tab","123","781345","-_-"});
            var expected5 = "__HAHA.123";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("YameRore",new List<string> {"HhAas","okIWILL123","WorkOut","Fails","-_-"});
            var expected6 = "YameRore.okIWILL123";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("finNNalLLly",new List<string> {"Die","NowW","Wow","WoW"});
            var expected7 = "finNNalLLly.WoW";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("_",new List<string> {"Bb","91245"});
            var expected8 = "_.Bb";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_73.Claude.Solver.StrongestExtension("Sp",new List<string> {"671235","Bb"});
            var expected9 = "Sp.671235";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Grok()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("Watashi",new List<string> {"tEN","niNE","eIGHt8OKe"});
            var expected1 = "Watashi.eIGHt8OKe";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("Boku123",new List<string> {"nani","NazeDa","YEs.WeCaNe","32145tggg"});
            var expected2 = "Boku123.YEs.WeCaNe";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("__YESIMHERE",new List<string> {"t","eMptY","nothing","zeR00","NuLl__","123NoooneB321"});
            var expected3 = "__YESIMHERE.NuLl__";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("K",new List<string> {"Ta","TAR","t234An","cosSo"});
            var expected4 = "K.TAR";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("__HAHA",new List<string> {"Tab","123","781345","-_-"});
            var expected5 = "__HAHA.123";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("YameRore",new List<string> {"HhAas","okIWILL123","WorkOut","Fails","-_-"});
            var expected6 = "YameRore.okIWILL123";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("finNNalLLly",new List<string> {"Die","NowW","Wow","WoW"});
            var expected7 = "finNNalLLly.WoW";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("_",new List<string> {"Bb","91245"});
            var expected8 = "_.Bb";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_73.Grok.Solver.StrongestExtension("Sp",new List<string> {"671235","Bb"});
            var expected9 = "Sp.671235";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Mistral()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("Watashi",new List<string> {"tEN","niNE","eIGHt8OKe"});
            var expected1 = "Watashi.eIGHt8OKe";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("Boku123",new List<string> {"nani","NazeDa","YEs.WeCaNe","32145tggg"});
            var expected2 = "Boku123.YEs.WeCaNe";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("__YESIMHERE",new List<string> {"t","eMptY","nothing","zeR00","NuLl__","123NoooneB321"});
            var expected3 = "__YESIMHERE.NuLl__";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("K",new List<string> {"Ta","TAR","t234An","cosSo"});
            var expected4 = "K.TAR";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("__HAHA",new List<string> {"Tab","123","781345","-_-"});
            var expected5 = "__HAHA.123";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("YameRore",new List<string> {"HhAas","okIWILL123","WorkOut","Fails","-_-"});
            var expected6 = "YameRore.okIWILL123";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("finNNalLLly",new List<string> {"Die","NowW","Wow","WoW"});
            var expected7 = "finNNalLLly.WoW";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("_",new List<string> {"Bb","91245"});
            var expected8 = "_.Bb";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_73.Mistral.Solver.StrongestExtension("Sp",new List<string> {"671235","Bb"});
            var expected9 = "Sp.671235";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_DeepSeek()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("Watashi",new List<string> {"tEN","niNE","eIGHt8OKe"});
            var expected1 = "Watashi.eIGHt8OKe";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("Boku123",new List<string> {"nani","NazeDa","YEs.WeCaNe","32145tggg"});
            var expected2 = "Boku123.YEs.WeCaNe";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("__YESIMHERE",new List<string> {"t","eMptY","nothing","zeR00","NuLl__","123NoooneB321"});
            var expected3 = "__YESIMHERE.NuLl__";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("K",new List<string> {"Ta","TAR","t234An","cosSo"});
            var expected4 = "K.TAR";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("__HAHA",new List<string> {"Tab","123","781345","-_-"});
            var expected5 = "__HAHA.123";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("YameRore",new List<string> {"HhAas","okIWILL123","WorkOut","Fails","-_-"});
            var expected6 = "YameRore.okIWILL123";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("finNNalLLly",new List<string> {"Die","NowW","Wow","WoW"});
            var expected7 = "finNNalLLly.WoW";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("_",new List<string> {"Bb","91245"});
            var expected8 = "_.Bb";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension("Sp",new List<string> {"671235","Bb"});
            var expected9 = "Sp.671235";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

        public void Run_Llama()
        {
            TestUtils.Reset();
            try {
CompareLogic compareLogic = new CompareLogic();
            var actual1 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("Watashi",new List<string> {"tEN","niNE","eIGHt8OKe"});
            var expected1 = "Watashi.eIGHt8OKe";
            var result1 = compareLogic.Compare(actual1, expected1);
            TestUtils.Check(result1, "Exception --- test case 0 failed to pass");

            var actual2 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("Boku123",new List<string> {"nani","NazeDa","YEs.WeCaNe","32145tggg"});
            var expected2 = "Boku123.YEs.WeCaNe";
            var result2 = compareLogic.Compare(actual2, expected2);
            TestUtils.Check(result2, "Exception --- test case 1 failed to pass");

            var actual3 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("__YESIMHERE",new List<string> {"t","eMptY","nothing","zeR00","NuLl__","123NoooneB321"});
            var expected3 = "__YESIMHERE.NuLl__";
            var result3 = compareLogic.Compare(actual3, expected3);
            TestUtils.Check(result3, "Exception --- test case 2 failed to pass");

            var actual4 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("K",new List<string> {"Ta","TAR","t234An","cosSo"});
            var expected4 = "K.TAR";
            var result4 = compareLogic.Compare(actual4, expected4);
            TestUtils.Check(result4, "Exception --- test case 3 failed to pass");

            var actual5 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("__HAHA",new List<string> {"Tab","123","781345","-_-"});
            var expected5 = "__HAHA.123";
            var result5 = compareLogic.Compare(actual5, expected5);
            TestUtils.Check(result5, "Exception --- test case 4 failed to pass");

            var actual6 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("YameRore",new List<string> {"HhAas","okIWILL123","WorkOut","Fails","-_-"});
            var expected6 = "YameRore.okIWILL123";
            var result6 = compareLogic.Compare(actual6, expected6);
            TestUtils.Check(result6, "Exception --- test case 5 failed to pass");

            var actual7 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("finNNalLLly",new List<string> {"Die","NowW","Wow","WoW"});
            var expected7 = "finNNalLLly.WoW";
            var result7 = compareLogic.Compare(actual7, expected7);
            TestUtils.Check(result7, "Exception --- test case 6 failed to pass");

            var actual8 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("_",new List<string> {"Bb","91245"});
            var expected8 = "_.Bb";
            var result8 = compareLogic.Compare(actual8, expected8);
            TestUtils.Check(result8, "Exception --- test case 7 failed to pass");

            var actual9 = Benchmarks.csharp_73.Llama.Solver.StrongestExtension("Sp",new List<string> {"671235","Bb"});
            var expected9 = "Sp.671235";
            var result9 = compareLogic.Compare(actual9, expected9);
            TestUtils.Check(result9, "Exception --- test case 8 failed to pass");
            } catch (Exception ex) { Console.WriteLine("CRITICAL FAIL: " + ex.Message); }
        }

    }
}
