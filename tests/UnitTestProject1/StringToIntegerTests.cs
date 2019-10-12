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
	public class StringToIntegerTests
	{
		[TestMethod]
		public void StringToIntegerTests1()
		{
			InternalTest("42",42);
		}

		[TestMethod]
		public void StringToIntegerTests2()
		{
			InternalTest("   -42", -42);
		}

		[TestMethod]
		public void StringToIntegerTests3()
		{
			InternalTest("4193 with words", 4193);
		}

		[TestMethod]
		public void StringToIntegerTests4()
		{
			InternalTest("-91283472332", int.MinValue);
		}

		[TestMethod]
		public void StringToIntegerTests5()
		{
			InternalTest("+1", 1);
		}

		[TestMethod]
		public void StringToIntegerTests6()
		{
			InternalTest(" + 0 123", 0);
		}

		void InternalTest(string str, int expected)
		{
			int actual = StringToInteger.MyAtoi(str);
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
