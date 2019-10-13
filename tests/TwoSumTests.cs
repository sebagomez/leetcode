using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class TwoSumTests
	{
		[Fact]
		public void TwoSumTests1()
		{
			int[] nums = new int[] { 2, 7, 11, 15 };
			int[] expected = new int[] { 0, 1 };
			InternalTest(nums, 9, expected);
		}

		[Fact]
		public void TwoSumTests2()
		{
			int[] nums = new int[] { 3, 2, 4 };
			int[] expected = new int[] { 1, 2 };
			InternalTest(nums, 6, expected);
		}

		[Fact]
		public void TwoSumTests3()
		{
			int[] nums = new int[] { 3, 3 };
			int[] expected = new int[] { 0, 1 };
			InternalTest(nums, 6, expected);
		}

		void InternalTest(int[] nums, int target, int[] expected)
		{
			int[] actual = TwoSum.Solve(nums, target);
			Assert.Equal<int>(expected.Length, actual.Length);
			for (int i = 0; i < expected.Length; i++)
			{
				Assert.Equal<int>(expected[i], actual[i]);
			}
		}
	}
}
