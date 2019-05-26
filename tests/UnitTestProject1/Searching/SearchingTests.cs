using System;
using System.Collections.Generic;
using LeetCode.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Searching
{
	[TestClass]
	public class SearchingTests
	{
		List<Func<int[], int, int>> algorithms = new List<Func<int[], int, int>>
		{
			Binary.SearchRecursive,
			Binary.Search
		};

		[TestMethod]
		public void TestCase1()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 4;
			int expected = 4;
			InternalTest(arr, search, expected);
		}

		[TestMethod]
		public void TestCase2()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 8;
			int expected = -1;
			InternalTest(arr, search, expected);
		}

		[TestMethod]
		public void TestCase3()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 0;
			int expected = 0;
			InternalTest(arr, search, expected);
		}

		[TestMethod]
		public void TestCase4()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 7;
			int expected = 7;
			InternalTest(arr, search, expected);
		}

		[TestMethod]
		public void TestCase5()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 3;
			int expected = 3;
			InternalTest(arr, search, expected);
		}

		void InternalTest(int[] arr, int search, int expected)
		{
			foreach (Func<int[], int, int> algo in algorithms)
			{
				int result = algo(arr,search);
				Assert.AreEqual(expected, result, $"Algorithm:{algo.Method.DeclaringType.FullName}");
			}
		}
	}
}
