using Leetcode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class FindPeakTests
	{
		[Fact]
		public void FindPeakTests1()
		{
			int[] nums = new int[] { 1, 2, 3, 1 };
			int[] expected = new int[] { 2 };
			InternalTest(nums, expected);
		}

		[Fact]
		public void FindPeakTests2()
		{
			int[] nums = new int[] { 1, 2, 1, 3, 5, 6, 4 };
			int[] expected = new int[] { 1, 5 };
			InternalTest(nums, expected);
		}

		[Fact]
		public void FindPeakTests3()
		{
			int[] nums = new int[] { 1 };
			int[] expected = new int[] { 0 };
			InternalTest(nums, expected);
		}

		[Fact]
		public void FindPeakTests4()
		{
			int[] nums = new int[] { 1, 2 };
			int[] expected = new int[] { 1 };
			InternalTest(nums, expected);
		}

		[Fact]
		public void FindPeakTests5()
		{
			int[] nums = new int[] { 3, 2, 1 };
			int[] expected = new int[] { 0 };
			InternalTest(nums, expected);
		}

		void InternalTest(int[] nums, int[] expected)
		{
			int actual = FindPeak.FindPeakElement(nums);
			Assert.Contains(actual, expected);
		}
	}
}
