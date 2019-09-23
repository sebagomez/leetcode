using System;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class MicrosoftLongestPalindromeTests
	{

		[TestMethod]
		public void TestMethod00()
		{
			string text = "a";
			InternalTest(text, string.Empty, true);
		}

		[TestMethod]
		public void TestMethod01()
		{
			string text = "aba";
			InternalTest(text, string.Empty, true);
		}

		[TestMethod]
		public void TestMethod02()
		{
			string text = "ab";
			InternalTest(text, string.Empty, false);
		}

		[TestMethod]
		public void TestMethod03()
		{
			string text = "abcdedcba";
			InternalTest(text, string.Empty, true);
		}

		[TestMethod]
		public void TestMethod04()
		{
			string text = "abcdeedcba";
			InternalTest(text, string.Empty, true);
		}

		[TestMethod]
		public void TestMethod10()
		{
			string text = "zaba";
			InternalTest(text, "aba", true);
		}

		[TestMethod]
		public void TestMethod11()
		{
			string text = "abaz";
			InternalTest(text, "aba", true);
		}

		[TestMethod]
		public void TestMethod12()
		{
			string text = "rabaz";
			InternalTest(text, "aba", true);
		}

		[TestMethod]
		public void TestMethod13()
		{
			string text = "abaxabaxabb";
			InternalTest(text, "baxabaxab", true);
		}

		[TestMethod]
		public void TestMethod14()
		{
			string text = "rabaxabaxabb";
			InternalTest(text, "baxabaxab", true);
		}

        [TestMethod]
        public void TestMethod15()
        {
            string text = "abba";
            InternalTest(text, "abba", true);
        }

        [TestMethod]
        public void TestMethod16()
        {
            string text = "134556abba";
            InternalTest(text, "abba", true);
        }

        [TestMethod]
        public void TestMethod17()
        {
            string text = "abba1235458";
            InternalTest(text, "abba", true);
        }

		[TestMethod]
		public void TestMethod18()
		{
			string text = "cbbd";
			InternalTest(text, "bb", true);
		}

		[TestMethod]
		public void TestMethod19()
		{
			string text = "a";
			InternalTest(text, "a", true);
		}

		[TestMethod]
		public void TestMethod20()
		{
			string text = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
			InternalTest(text, "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111", true);
		}

		void InternalTest(string text, string longest, bool expected)
		{
			if (string.IsNullOrEmpty(longest))
			{
				bool isPalindrome = MicrosoftLongestPalindrome.IsPalindrome(text);
				Assert.AreEqual<bool>(expected, isPalindrome);
			}
			else
			{
				string actual = MicrosoftLongestPalindrome.LongestPalindrome(text);
				Assert.AreEqual<string>(longest, actual);
			}
		}
	}
}
