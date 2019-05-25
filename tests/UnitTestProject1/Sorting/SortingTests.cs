using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Sorting
{
	[TestClass]
	public class SortingTests
	{
		List<Func<int[], int[]>> algorithms = new List<Func<int[], int[]>>
		{
			Bubble.Sort,
			Selection.Sort,
			Merge.Sort,
			Quick.Sort
		};

		[TestMethod]
		public void TestCase0()
		{
			int[] arr = new int[] { 3, 2, 1, 4 };
			int[] expected = new int[] { 1, 2, 3, 4 };
			InternalTest(ref arr, expected);
		}

		[TestMethod]
		public void TestCase1()
		{
			int[] arr = new int[] { 2, 5, 7, 3, 1, 9, 4 };
			int[] expected = new int[] { 1, 2, 3, 4, 5, 7, 9 };
			InternalTest(ref arr, expected);
		}

		[TestMethod]
		public void TestCase2()
		{
			int[] arr = new int[] { 3, 1, 2 };
			int[] expected = new int[] { 1, 2, 3 };
			InternalTest(ref arr, expected);
		}

		[TestMethod]
		public void TestCase3()
		{
			int[] arr = new int[] { 3 };
			int[] expected = new int[] { 3 };
			InternalTest(ref arr, expected);
		}

		[TestMethod]
		public void TestCase4()
		{
			int[] arr = new int[] { };
			int[] expected = new int[] { };
			InternalTest(ref arr, expected);
		}

		[TestMethod]
		public void TestCase5()
		{
			int[] arr = new int[] { 1, 4, 5, 2, 8, 9 };
			int[] expected = new int[] { 1, 2, 4, 5, 8, 9 };
			InternalTest(ref arr, expected);
		}

		[TestMethod]
		public void TestCase6()
		{
			int[] arr = new int[] { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
			int[] expected = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 };
			InternalTest(ref arr, expected);
		}

		[TestMethod]
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
				Assert.AreEqual(expected.Length, result.Length, $"Algorithm:{algo.Method.DeclaringType.FullName}");
				for (int i = 0; i < expected.Length; i++)
				{
					Assert.AreEqual(expected[i], result[i], $"Algorithm:{algo.Method.DeclaringType.FullName}");
				}
			}
		}
	}
}
