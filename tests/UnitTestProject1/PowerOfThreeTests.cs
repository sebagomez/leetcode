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
	public class PowerOfThreeTests
	{
		[TestMethod]
		public void PowerOfThreeTests1()
		{
			InternalTest(9, true);
		}

		[TestMethod]
		public void PowerOfThreeTests2()
		{
			InternalTest(27, true);
		}

		[TestMethod]
		public void PowerOfThreeTests3()
		{
			InternalTest(0, false);
		}

		[TestMethod]
		public void PowerOfThreeTests4()
		{
			InternalTest(45, false);
		}

		[TestMethod]
		public void PowerOfThreeTests5()
		{
			InternalTest(43046720, false);
		}

		void InternalTest(int n, bool expected)
		{
			bool actual = PowerOfThree.IsPowerOfThree(n);
			Assert.AreEqual<bool>(expected, actual);
		}
	}
}
