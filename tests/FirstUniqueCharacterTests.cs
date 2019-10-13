using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class FirstUniqueCharacterTests
	{
		[Fact]
		public void FirstUniqueCharacterTests1()
		{
			InternalTest("leetcode",0);
		}

		[Fact]
		public void FirstUniqueCharacterTests2()
		{
			InternalTest("loveleetcode", 2);
		}

		void InternalTest(string s, int expected)
		{
			int actual = FirstUniqueCharacter.FirstUniqChar(s);
			Assert.Equal<int>(expected, actual);
		}
	}
}
