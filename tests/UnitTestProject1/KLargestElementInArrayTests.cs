using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class KLargestElementInArrayTests
	{
		[TestMethod]
		public void TestCase1()
		{
			int[] arr = new int[] { 3, 2, 1, 5, 6, 4 };
			int k = 2;
			int expected = 5;
			InternalTest(arr, k, expected);
		}

		[TestMethod]
		public void TestCase2()
		{
			int[] arr = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
			int k = 4;
			int expected = 4;
			InternalTest(arr, k, expected);
		}

		void InternalTest(int[] arr, int k, int expected)
		{
			int result = KLargestElementInArray.FindKthLargest(arr, k);
			Assert.AreEqual(expected, result);
		}
	}
}
