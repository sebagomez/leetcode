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
	public class ImplementStrStrTests
	{
		[TestMethod]
		public void ImplementStrStrTests1()
		{
			InternalTest("hello", "ll", 2);
		}

		[TestMethod]
		public void ImplementStrStrTests2()
		{
			InternalTest("aaaaa", "bba", -1);
		}

		[TestMethod]
		public void ImplementStrStrTests3()
		{
			InternalTest("a", "a", 0);
		}

		[TestMethod]
		public void ImplementStrStrTests4()
		{
			InternalTest("mississippi", "pi", 9);
		}

		void InternalTest(string str1, string str2, int expected)
		{
			int actual = ImplementStrStr.StrStr(str1, str2);
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
