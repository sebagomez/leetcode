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
	public class RemoveDeplicatesSortedArrayTests
	{
		[TestMethod]
		public void RemoveDeplicatesSortedArray1()
		{
			int[] nums = new int[] { 1, 1, 2 };
			InternalTest(nums, 2);
		}

		[TestMethod]
		public void RemoveDeplicatesSortedArray2()
		{
			int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
			InternalTest(nums, 5);
		}

		[TestMethod]
		public void RemoveDeplicatesSortedArray3()
		{
			int[] nums = new int[] {  };
			InternalTest(nums, 0);
		}

		void InternalTest(int[] nums, int expected)
		{
			int actual = RemoveDeplicatesSortedArray.RemoveDuplicates(nums);
			Assert.AreEqual<int>(expected, actual);
			for (int i = 1; i < expected; i++)
			{
				Assert.IsTrue(nums[i] > nums[i - 1]);
			}
		}
	}
}
