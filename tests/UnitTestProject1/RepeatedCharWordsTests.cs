using System;
using System.Collections.Generic;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class RepeatedCharWordsTests
	{
		List<Func<string, int, List<string>>> algorithms = new List<Func<string, int, List<string>>>
		{
			RepeatedCharWords.BruteSolution,
			RepeatedCharWords.SmartSolution
		};

		[TestMethod]
		public void TestCase1()
		{
			string word = "legend";
			int length = 4;
			List<string> expected = new List<string>()
			{
				"lege",
				"egen"
			};
			InternalTest(word, length, expected);
		}

		[TestMethod]
		public void TestCase2()
		{
			string word = "legend";
			int length = 6;
			List<string> expected = new List<string>()
			{
				"legend"
			};
			InternalTest(word, length, expected);
		}

		[TestMethod]
		public void TestCase3()
		{
			string word = "legend";
			int length = 7;
			List<string> expected = new List<string>();
			InternalTest(word, length, expected);
		}

		[TestMethod]
		public void TestCaseMississippi()
		{
			string word = "mississippi";
			int length = 4;
			List<string> expected = new List<string>()
			{
				"miss",
				"issi",
				"ssis",
				"siss",
				"ssip",
				"sipp",
				"ippi"
			};
			InternalTest(word, length, expected);
		}

		void InternalTest(string word, int length, List<string> expected)
		{
			foreach (var algo in algorithms)
			{
				List<string> result = algo(word, length);
				Assert.AreEqual(expected.Count, result.Count, $"Algorithm:{algo.Method.DeclaringType.FullName}");
				foreach (string item in result)
				{
					Assert.IsTrue(expected.Contains(item), $"Algorithm:{algo.Method.DeclaringType.FullName}");
				}
			}

			
		}
	}
}
