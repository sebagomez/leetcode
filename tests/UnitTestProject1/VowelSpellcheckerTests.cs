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
	public class VowelSpellcheckerTests
	{
		[TestMethod]
		public void VowelSpellcheckerTests1()
		{
			string[] wordList = new string[] { "KiTe", "kite", "hare", "Hare" };
			string[] queries = new string[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" };
			string[] expected = new string[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" };
			InternalTest(wordList, queries, expected);
		}

		[TestMethod]
		public void VowelSpellcheckerTests2()
		{
			string[] wordList = new string[] { "wg", "uo", "as", "kv", "ra", "mw", "gi", "we", "og", "zu" };
			string[] queries = new string[] { "AS", "in", "yc", "kv", "mw", "ov", "lc", "os", "wm", "Mw" };
			string[] expected = new string[] { "as", "", "", "kv", "mw", "", "", "as", "", "mw" };
			InternalTest(wordList, queries, expected);
		}

		[TestMethod]
		public void VowelSpellcheckerTests3()
		{
			string[] wordList = new string[] { "ae", "aa" };
			string[] queries = new string[] { "UU" };
			string[] expected = new string[] { "ae" };
			InternalTest(wordList, queries, expected);
		}

		void InternalTest(string[] wordlist, string[] queries, string[] expected)
		{
			string[] actual = VowelSpellchecker.Spellchecker(wordlist, queries);
			Assert.AreEqual<int>(expected.Length, actual.Length, "Different length");
			for (int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual<string>(expected[i], actual[i], $"Expected '{expected[i]}', but got '{actual[i]}' instead.");
			}
		}
	}
}
