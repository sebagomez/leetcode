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
	public class ValidAnagramTests
	{
		[TestMethod]
		public void ValidAnagramTests1()
		{
			InternalTest("anagram", "nagaram", true);
		}

		[TestMethod]
		public void ValidAnagramTests2()
		{
			InternalTest("rat", "car", false);
		}

		void InternalTest(string s, string t, bool expected)
		{
			bool actual = ValidAnagram.IsAnagram(s, t);
			Assert.AreEqual<bool>(expected, actual);
		}
	}
}
