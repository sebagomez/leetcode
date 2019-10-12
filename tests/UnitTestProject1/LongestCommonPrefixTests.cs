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
	public class LongestCommonPrefixTests
	{
		[TestMethod]
		public void LongestCommonPrefixTests1()
		{
			string[] strs = new string[] { "flower", "flow", "flight" };
			InternalTest(strs, "fl");
		}

		[TestMethod]
		public void LongestCommonPrefixTests2()
		{
			string[] strs = new string[] { "dog", "racecar", "car" };
			InternalTest(strs, "");
		}

		[TestMethod]
		public void LongestCommonPrefixTests3()
		{
			string[] strs = new string[] { };
			InternalTest(strs, "");
		}

		[TestMethod]
		public void LongestCommonPrefixTests4()
		{
			string[] strs = new string[] { "a" };
			InternalTest(strs, "a");
		}

		void InternalTest(string[] strs, string expected)
		{
			string actual = LongestCommonPrefix.Solve(strs);
			Assert.AreEqual<string>(expected, actual);
		}
	}
}
