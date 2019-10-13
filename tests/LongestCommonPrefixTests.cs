using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class LongestCommonPrefixTests
	{
		[Fact]
		public void LongestCommonPrefixTests1()
		{
			string[] strs = new string[] { "flower", "flow", "flight" };
			InternalTest(strs, "fl");
		}

		[Fact]
		public void LongestCommonPrefixTests2()
		{
			string[] strs = new string[] { "dog", "racecar", "car" };
			InternalTest(strs, "");
		}

		[Fact]
		public void LongestCommonPrefixTests3()
		{
			string[] strs = new string[] { };
			InternalTest(strs, "");
		}

		[Fact]
		public void LongestCommonPrefixTests4()
		{
			string[] strs = new string[] { "a" };
			InternalTest(strs, "a");
		}

		void InternalTest(string[] strs, string expected)
		{
			string actual = LongestCommonPrefix.Solve(strs);
			Assert.Equal(expected, actual);
		}
	}
}
