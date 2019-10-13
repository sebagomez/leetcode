using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class ValidPalindromeTests
	{
		[Fact]
		public void ValidPalindromeTests1()
		{
			string word = "A man, a plan, a canal: Panama";
			InternalTest(word, true);
		}

		[Fact]
		public void ValidPalindromeTests2()
		{
			string word = "race a car";
			InternalTest(word, false);
		}

		[Fact]
		public void ValidPalindromeTests3()
		{
			string word = "0P";
			InternalTest(word, false);
		}

		void InternalTest(string word, bool expected)
		{
			bool actual = ValidPalindrome.IsPalindrome(word);
			Assert.Equal<bool>(expected, actual);
		}
	}
}
