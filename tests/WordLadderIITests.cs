using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class WordLadderIITests
	{
		[Fact]
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

			Assert.Equal<int>(expected.Count, value.Count);

			for (int i = 0; i < expected.Count; i++)
			{
				Assert.Equal<int>(expected[i].Count, value[i].Count);

				for (int j = 0; j < expected[i].Count; j++)
				{
					Assert.Equal(expected[i][j], value[i][j]);
				}
			}
		}
	}
}
