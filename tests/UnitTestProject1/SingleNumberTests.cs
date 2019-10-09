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
	public class SingleNumberTests
	{
		[TestMethod]
		public void SingleNumberTests1()
		{
			int[] nums = new int[] { 2, 2, 1 };
			InternalTest(nums, 1);
		}

		[TestMethod]
		public void SingleNumberTests4()
		{
			int[] nums = new int[] { 4, 1, 2, 1, 2 };
			InternalTest(nums, 4);
		}

		void InternalTest(int[] nums, int expected)
		{
			int actual = SingleNumber.Solve(nums);
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
