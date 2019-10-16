using Leetcode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class PrimePalindromeTests
	{
		[Fact]
		public void PrimePalindromeTests1()
		{
			InternalTest(6, 7);
		}

		[Fact]
		public void PrimePalindromeTests2()
		{
			InternalTest(8, 11);
		}

		[Fact]
		public void PrimePalindromeTests3()
		{
			InternalTest(13, 101);
		}

		[Fact]
		public void PrimePalindromeTests4()
		{
			InternalTest(1, 2);
		}

		[Fact]
		public void PrimePalindromeTests5()
		{
			InternalTest(9989900, 100030001);
		}

		void InternalTest(int n, int expected)
		{
			int actual = PrimePalindrome.Solve(n);
			Assert.Equal(expected, actual);
		}
	}
}
