using Leetcode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class MedianTwoSortedArraysTests
	{
		[Fact]
		public void MedianTwoSortedArraysTests1()
		{
			int[] nums1 = new int[] { 1, 3 };
			int[] nums2 = new int[] { 2 };
			InternalTest(nums1, nums2, 2.0);
		}

		[Fact]
		public void MedianTwoSortedArraysTests2()
		{
			int[] nums1 = new int[] { 1, 2 };
			int[] nums2 = new int[] { 3, 4 };
			InternalTest(nums1, nums2, 2.5);
		}

		[Fact]
		public void MedianTwoSortedArraysTests3()
		{
			int[] nums1 = new int[] { 3 };
			int[] nums2 = new int[] { -2, -1 };
			InternalTest(nums1, nums2, -1);
		}

		void InternalTest(int[] nums1, int[] nums2, double expected)
		{
			double actual = MedianTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
			Assert.Equal(expected, actual);
		}
	}
}
