using System;
using System.Collections.Generic;
using LeetCode.Sorting;
using Xunit;

namespace LeetcodeTests.Sorting
{
	
	public class SortingTests
	{
		readonly List<Func<int[], int[]>> algorithms = new List<Func<int[], int[]>>
		{
			Bubble.Sort,
			Selection.Sort,
			Merge.Sort,
			Quick.Sort,
			Insertion.Sort
		};

		[Fact]
		public void TestCase0()
		{
			int[] arr = new int[] { 3, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4 };
			InternalTest(ref arr, expected);
		}

		[Fact]
		public void TestCase1()
		{
			int[] arr = new int[] { 2, 5, 7, 3, 1, 9, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5, 7, 9 };
			InternalTest(ref arr, expected);
		}

		[Fact]
		public void TestCase2()
		{
			int[] arr = new int[] { 3, 1, 2 };
			int[] expected = new int[] { 1, 2, 3 };
			InternalTest(ref arr, expected);
		}

		[Fact]
		public void TestCase3()
		{
			int[] arr = new int[] { 3 };
			int[] expected = new int[] { 3 };
			InternalTest(ref arr, expected);
		}

		[Fact]
		public void TestCase4()
		{
			int[] arr = new int[] { };
			int[] expected = new int[] { };
			InternalTest(ref arr, expected);
		}

		[Fact]
		public void TestCase5()
		{
			int[] arr = new int[] { 1, 4, 5, 2, 8, 9 };
			int[] expected = new int[] { 1, 2, 4, 5, 8, 9 };
			InternalTest(ref arr, expected);
		}

		[Fact]
		public void TestCase6()
		{
			int[] arr = new int[] { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
			int[] expected = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 };
			InternalTest(ref arr, expected);
		}

		[Fact]
		public void TestCase7()
		{
			int[] arr = new int[] { 2, 1 };
			int[] expected = new int[] { 1, 2 };
			InternalTest(ref arr, expected);
		}

		void InternalTest(ref int[] arr, int[] expected)
		{

			foreach (Func<int[], int[]> algo in algorithms)
			{
				int[] clone = new int[arr.Length];
				Array.Copy(arr, clone, arr.Length);
				int[] result = algo(clone);
				Assert.Equal(expected.Length, result.Length);
				for (int i = 0; i < expected.Length; i++)
				{
					Assert.Equal(expected[i], result[i]);
				}
			}
		}
	}
}
