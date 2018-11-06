using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class WordLadderIITests
	{
		[TestMethod]
		public void Test1()
		{
			string beginWord = "hit";
			string endWord = "cog";
			IList<string> wordList = new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" };

			IList<IList<string>> expected = new List<IList<string>>
			{
				new List<string>() { "hit", "hot", "dot", "dog", "cog" },
				new List<string>() { "hit", "hot", "lot", "log", "cog" }
			};

			InternalTest(beginWord, endWord, wordList, expected);
		}

		void InternalTest(string beginWord, string endWord, IList<string> wordList, IList<IList<string>> expected)
		{
			IList<IList<string>> value = WordLadderII.FindLadders(beginWord, endWord, wordList);

			Assert.AreEqual<int>(expected.Count, value.Count, "Different ammount of arrays");

			for (int i = 0; i < expected.Count; i++)
			{
				Assert.AreEqual<int>(expected[i].Count, value[i].Count, $"Different ammount of items in array at {i}");

				for (int j = 0; j < expected[i].Count; j++)
				{
					Assert.AreEqual<string>(expected[i][j], value[i][j], $"Expected:{expected[i][j]}, obtained:{value[i][j]}");
				}
			}
		}
	}
}
