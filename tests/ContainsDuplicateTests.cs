using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class ContainsDuplicateTests
	{
		[Fact]
		public void ContainsDuplicate1()
		{
			int[] nums = new int[] { 1, 2, 3, 1 };
			InternalTest(nums, true);
		}

		[Fact]
		public void ContainsDuplicate2()
		{
			int[] nums = new int[] { 1, 2, 3, 4 };
			InternalTest(nums, false);
		}

		[Fact]
		public void ContainsDuplicate3()
		{
			int[] nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
			InternalTest(nums, true);
		}

		void InternalTest(int[] nums, bool expected)
		{
			bool actual = ContainsDuplicate.Solve(nums);
			Assert.Equal<bool>(expected, actual);
		}
	}
}
