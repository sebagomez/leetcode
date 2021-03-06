﻿using LeetCode;
using LeetCode.Sorting;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class IntersectionOfTwoArraysIITests
	{
		[Fact]
		public void IntersectionOfTwoArraysIITests1()
		{
			int[] nums1 = new int[] { 1, 2, 2, 1 };
			int[] nums2 = new int[] { 2, 2 };
			int[] expected = new int[] { 2, 2 };
			InternalTest(nums1, nums2, expected);
		}

		[Fact]
		public void IntersectionOfTwoArraysIITests2()
		{
			int[] nums1 = new int[] { 4, 9, 5 };
			int[] nums2 = new int[] { 9, 4, 9, 8, 4 };
			int[] expected = new int[] { 4, 9 };
			InternalTest(nums1, nums2, expected);
		}

		[Fact]
		public void IntersectionOfTwoArraysIITests3()
		{
			int[] nums1 = new int[] { 1, 2 };
			int[] nums2 = new int[] { 1, 1 };
			int[] expected = new int[] { 1 };
			InternalTest(nums1, nums2, expected);
		}

		void InternalTest(int[] nums1, int[] nums2, int[] expected)
		{
			int[] actual = IntersectionOfTwoArraysII.Intersect(nums1, nums2);
			Assert.Equal<int>(expected.Length, actual.Length);

			//the order does not matter
			Quick.Sort(expected);
			Quick.Sort(actual);

			for (int i = 0; i < actual.Length; i++)
			{
				Assert.Equal<int>(expected[i], actual[i]);
			}
		}
	}
}
