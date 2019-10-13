using System;
using System.Collections.Generic;
using LeetCode.Searching;
using Xunit;

namespace LeetcodeTests.Searching
{
	
	public class SearchingTests
	{
		readonly List<Func<int[], int, int>> algorithms = new List<Func<int[], int, int>>
		{
			Binary.SearchRecursive,
			Binary.Search
		};

		[Fact]
		public void TestCase1()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 4;
			int expected = 4;
			InternalTest(arr, search, expected);
		}

		[Fact]
		public void TestCase2()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 8;
			int expected = -1;
			InternalTest(arr, search, expected);
		}

		[Fact]
		public void TestCase3()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 0;
			int expected = 0;
			InternalTest(arr, search, expected);
		}

		[Fact]
		public void TestCase4()
		{
			int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
			int search = 7;
			int expected = 7;
			InternalTest(arr, search, expected);
		}

		[Fact]
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
				Assert.Equal(expected, result);
			}
		}
	}
}
