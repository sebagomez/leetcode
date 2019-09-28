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
	public class ClimbStairsTests
	{
		[TestMethod]
		public void ClimbStairsTests1()
		{
			InternalTest(2, 2);
		}

		[TestMethod]
		public void ClimbStairsTests2()
		{
			InternalTest(3, 3);
		}

		[TestMethod]
		public void ClimbStairsTests3()
		{
			InternalTest(4, 5);
		}

		[TestMethod]
		public void ClimbStairsTests4()
		{
			InternalTest(44, 1134903170);
		}

		void InternalTest(int steps, int expected)
		{
			int actual = ClimbStairs.Solve(steps);
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
