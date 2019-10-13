using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class RotateArrayTests
	{
		[Fact]
		public void RotateArrayTests1()
		{
			int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			int[] expected = new int[] { 5, 6, 7, 1, 2, 3, 4  };
			InternalTest(nums, 3, expected);
		}

		[Fact]
		public void RotateArrayTests2()
		{
			int[] nums = new int[] { -1, -100, 3, 99 };
			int[] expected = new int[] { 3, 99, -1, -100 };
			InternalTest(nums, 2, expected);
		}

		[Fact]
		public void RotateArrayTests3()
		{
			int[] nums = new int[] { -1 };
			int[] expected = new int[] { -1 };
			InternalTest(nums, 2, expected);
		}

		void InternalTest(int[] nums, int k, int[] expected)
		{
			RotateArray.Rotate(nums, k);
			Assert.Equal<int>(expected.Length, nums.Length);
			for (int i = 0; i < nums.Length; i++)
			{
				Assert.Equal<int>(expected[i], nums[i]);
			}
		}
	}
}
