using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class RemoveDeplicatesSortedArrayTests
	{
		[Fact]
		public void RemoveDeplicatesSortedArray1()
		{
			int[] nums = new int[] { 1, 1, 2 };
			InternalTest(nums, 2);
		}

		[Fact]
		public void RemoveDeplicatesSortedArray2()
		{
			int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
			InternalTest(nums, 5);
		}

		[Fact]
		public void RemoveDeplicatesSortedArray3()
		{
			int[] nums = new int[] {  };
			InternalTest(nums, 0);
		}

		void InternalTest(int[] nums, int expected)
		{
			int actual = RemoveDeplicatesSortedArray.RemoveDuplicates(nums);
			Assert.Equal<int>(expected, actual);
			for (int i = 1; i < expected; i++)
			{
				Assert.True(nums[i] > nums[i - 1]);
			}
		}
	}
}
