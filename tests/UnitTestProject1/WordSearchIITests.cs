using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	[TestClass]
	public class WordSearchIITests
	{

		[TestMethod]
		public void WordSearchIITests0()
		{
			char[][] board = new char[][] { new[] { 'o', 'a' },
											new[] { 'e', 't' }};
			InternalTest(board, new string[] { "oa", "te", "ea", "ot" }, new List<string> { "oa", "te" });
		}

		[TestMethod]
		public void WordSearchIITests1()
		{
			char[][] board = new char[][] { new[] { 'o', 'a' },
											new[] { 'e', 'a' }};
			InternalTest(board, new string[] { "oa", "te", "ea", "aa", "oaa" }, new List<string> { "oa", "ea", "aa", "oaa" });
		}

		[TestMethod]
		public void WordSearchIITests2()
		{
			char[][] board = new char[][] { new[] { 'o', 'a', 'a' },
											new[] { 'e', 't', 'e' },
											new[] { 'i', 'h', 'k'} };
			InternalTest(board, new string[] { "oath", "pee", "ekh", "eta" }, new List<string> { "oath", "ekh", "eta" });
		}

		[TestMethod]
		public void WordSearchIITests3()
		{
			char[][] board = new char[][] { new[] { 'o', 'a', 'a', 'n' },
											new[] { 'e', 't', 'a', 'e' },
											new[] { 'i', 'h', 'k', 'r' },
											new[] { 'i', 'f', 'l', 'v' } };
			InternalTest(board, new string[] { "oath", "pea", "eat", "rain" }, new List<string> { "eat", "oath" });
		}

		//[TestMethod]
		//public void WordSearchIITests2()
		//{
		//	//InternalTest(new int[] { 3, 5, 1, 6, 2, 0, 8, int.MinValue, int.MinValue, 7, 4 }, 5, 4, expected);
		//}

		void InternalTest(char[][] board, string[] words, List<string> expected)
		{
			List<string> actual = WordSearchII.FindWords(board, words);
			Assert.AreEqual<int>(expected.Count, actual.Count);
			foreach (string word in expected)
			{
				Assert.IsTrue(actual.Contains(word), $"{word} was not returned");
			}
		}
	}
}
