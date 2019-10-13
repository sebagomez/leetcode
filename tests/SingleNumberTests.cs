using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class SingleNumberTests
	{
		[Fact]
		public void SingleNumberTests1()
		{
			int[] nums = new int[] { 2, 2, 1 };
			InternalTest(nums, 1);
		}

		[Fact]
		public void SingleNumberTests4()
		{
			int[] nums = new int[] { 4, 1, 2, 1, 2 };
			InternalTest(nums, 4);
		}

		void InternalTest(int[] nums, int expected)
		{
			int actual = SingleNumber.Solve(nums);
			Assert.Equal<int>(expected, actual);
		}
	}
}
