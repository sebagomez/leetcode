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
	public class FirstUniqueCharacterTests
	{
		[TestMethod]
		public void FirstUniqueCharacterTests1()
		{
			InternalTest("leetcode",0);
		}

		[TestMethod]
		public void FirstUniqueCharacterTests2()
		{
			InternalTest("loveleetcode", 2);
		}

		void InternalTest(string s, int expected)
		{
			int actual = FirstUniqueCharacter.FirstUniqChar(s);
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
