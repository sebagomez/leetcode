using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class VowelSpellcheckerTests
	{
		[Fact]
		public void VowelSpellcheckerTests1()
		{
			string[] wordList = new string[] { "KiTe", "kite", "hare", "Hare" };
			string[] queries = new string[] { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" };
			string[] expected = new string[] { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" };
			InternalTest(wordList, queries, expected);
		}

		[Fact]
		public void VowelSpellcheckerTests2()
		{
			string[] wordList = new string[] { "wg", "uo", "as", "kv", "ra", "mw", "gi", "we", "og", "zu" };
			string[] queries = new string[] { "AS", "in", "yc", "kv", "mw", "ov", "lc", "os", "wm", "Mw" };
			string[] expected = new string[] { "as", "", "", "kv", "mw", "", "", "as", "", "mw" };
			InternalTest(wordList, queries, expected);
		}

		[Fact]
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
			Assert.Equal<int>(expected.Length, actual.Length);
			for (int i = 0; i < expected.Length; i++)
			{
				Assert.Equal(expected[i], actual[i]);
			}
		}
	}
}
