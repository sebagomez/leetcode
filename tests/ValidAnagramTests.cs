using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class ValidAnagramTests
	{
		[Fact]
		public void ValidAnagramTests1()
		{
			InternalTest("anagram", "nagaram", true);
		}

		[Fact]
		public void ValidAnagramTests2()
		{
			InternalTest("rat", "car", false);
		}

		void InternalTest(string s, string t, bool expected)
		{
			bool actual = ValidAnagram.IsAnagram(s, t);
			Assert.Equal<bool>(expected, actual);
		}
	}
}
