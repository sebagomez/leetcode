using Leetcode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class GenerateParenthesesTests
	{
		[Fact]
		public void GenerateParenthesesTests1()
		{
			List<string> expected = new List<string>
			{
				"((()))",
				"(()())",
				"(())()",
				"()(())",
				"()()()"
			};

			InternalTest(3, expected);
		}

		void InternalTest(int n, IList<string> expected)
		{
			IList<string> actual = GenerateParentheses.GenerateParenthesis(n);
			Assert.Equal(expected.Count, actual.Count);
			for (int i = 0; i < actual.Count; i++)
			{
				Assert.Equal(expected[i], actual[i]);
			}
		}
	}
}
