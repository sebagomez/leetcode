using Leetcode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class WordLadderTests
	{
		[Fact]
		public void WordLadderTests1()
		{
			List<string> wordList = new List<string>       //   [hit]
			{                                              //  [h][d] [l]  [c]
				"hot","dot","dog","lot","log","cog"        //  [o][o] [o]  [o]
			};                                             //  [t][t][g][t][g]

			InternalTest("hit", "cog", wordList, 5);
		}

		[Fact]
		public void WordLadderTests2()
		{
			List<string> wordList = new List<string>
			{
				"hot","dot","dog","lot","log"
			};

			InternalTest("hit", "cog", wordList, 0);
		}

		[Fact]
		public void WordLadderTests3()
		{
			List<string> wordList = new List<string>
			{
				"hot","dog","dot"
			};

			InternalTest("hot", "dog", wordList, 3);
		}

		[Fact]
		public void WordLadderTests4()
		{
			List<string> wordList = new List<string>
			{
				"a","b","c"
			};

			InternalTest("a", "c", wordList, 2);
		}

		void InternalTest(string beginWord, string endWord, IList<string> wordList, int expected)
		{
			int actual = WordLadder.LadderLength(beginWord, endWord, wordList);
			Assert.Equal(expected, actual);
		}
	}
}
