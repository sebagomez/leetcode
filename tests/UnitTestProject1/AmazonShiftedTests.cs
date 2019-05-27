using System;
using System.Collections.Generic;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class AmazonShiftedTests
	{
		List<Func<int[], int>> algorithms = new List<Func<int[], int>>
		{
			AmazonShifted.SiftedN,
			AmazonShifted.SiftedLogN
		};


		[TestMethod]
		public void TestCase0()
		{
			int[] arr = new int[] { 3, 1, 2 };
			int expected = 1;
			InternalTest(arr, expected);
		}

		[TestMethod]
		public void TestCase1()
		{
			int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
			int expected = 0;
			InternalTest(arr, expected);
		}

		[TestMethod]
		public void TestCase2()
		{
			int[] arr = new int[] { 4, 5, 6, 1, 2, 3 };
			int expected = 3;
			InternalTest(arr, expected);
		}

		[TestMethod]
		public void TestCase3()
		{
			int[] arr = new int[] { };
			int expected = -1;
			InternalTest(arr, expected);
		}

		void InternalTest(int[] arr, int expected)
		{
			foreach (Func<int[], int> algo in algorithms)
			{
				int result = algo(arr);
				Assert.AreEqual(expected, result, $"Algorithm:{algo.Method.DeclaringType.FullName}");
			}
		}
	}
}
