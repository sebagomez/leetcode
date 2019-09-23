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
	public class ValidPalindromeTests
	{
		[TestMethod]
		public void ValidPalindromeTests1()
		{
			string word = "A man, a plan, a canal: Panama";
			InternalTest(word, true);
		}

		[TestMethod]
		public void ValidPalindromeTests2()
		{
			string word = "race a car";
			InternalTest(word, false);
		}

		[TestMethod]
		public void ValidPalindromeTests3()
		{
			string word = "0P";
			InternalTest(word, false);
		}

		void InternalTest(string word, bool expected)
		{
			bool actual = ValidPalindrome.IsPalindrome(word);
			Assert.IsTrue(actual == expected);
		}
	}
}
