using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Helpers;

namespace UnitTestProject1
{
	[TestClass]
	public class MoveZeroesTests
	{
		[TestMethod]
		public void MoveZeroesTests1()
		{
			int[] nums = new int[] { 0, 1, 0, 3, 12 };
			int[] expected = new int[] { 1, 3, 12, 0, 0 };
			InternalTest(nums, expected);
		}

		[TestMethod]
		public void MoveZeroesTests2()
		{
			int[] nums = new int[] { 0, 0, 1 };
			int[] expected = new int[] { 1, 0, 0 };
			InternalTest(nums, expected);
		}

		void InternalTest(int[] nums, int[] expected)
		{
			MoveZeroes.Solve(nums);
			AssertHelper.AssertArrays(expected, nums);
		}
	}
}
