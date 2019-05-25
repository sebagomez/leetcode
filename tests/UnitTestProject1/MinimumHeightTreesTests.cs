using System.Collections.Generic;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class MinimumHeightTreesTests
	{
		[TestMethod]
		public void Test1()
		{
			int n = 4;
			int[,] edges = new[,] { { 1, 0 }, { 1, 2 }, { 1, 3 } };
			IList<int> expected = new List<int> { 1 };
			InternalTest(n, edges, expected);
		}

		[TestMethod]
		public void Test2()
		{
			int n = 6;
			int[,] edges = new[,] { { 0, 3 }, { 1, 3 }, { 2, 3 }, { 4, 3 }, { 5, 4 } };
			IList<int> expected = new List<int> { 3, 4 };
			InternalTest(n, edges, expected);
		}

		[TestMethod]
		public void Test3()
		{
			int n = 1;
			int[,] edges = new int[0, 0];
			IList<int> expected = new List<int> { 0 };
			InternalTest(n, edges, expected);
		}

		[TestMethod]
		public void Test4()
		{
			int n = 6;
			int[,] edges = new[,] { { 0, 1 }, { 0, 2 }, { 0, 3 }, { 3, 4 }, { 4, 5 } };
			IList<int> expected = new List<int> { 3 };
			InternalTest(n, edges, expected);
		}

		[TestMethod]
		public void Test5()
		{
			int n = 2;
			int[,] edges = new[,] { { 0, 1 } };
			IList<int> expected = new List<int> { 0, 1 };
			InternalTest(n, edges, expected);
		}

		[TestMethod]
		public void Test6()
		{
			int n = 8;
			int[,] edges = new[,] { { 0, 1 }, { 1, 2 }, { 2, 3 }, { 0, 4 }, { 4, 5 }, { 4, 6 }, { 6, 7 } };
			IList<int> expected = new List<int> { 0 };
			InternalTest(n, edges, expected);
		}

		void InternalTest(int n, int[,] edges, IList<int> expected)
		{
			IList<int> value = MinimumHeightTrees.FindMinHeightTrees(n, edges);

			Assert.AreEqual(expected.Count, value.Count, "Different sizes!");

			IEnumerator<int> e1 = expected.GetEnumerator();
			IEnumerator<int> e2 = value.GetEnumerator();

			while (e1.MoveNext() && e2.MoveNext())
			{
				Assert.AreEqual(e1.Current, e2.Current, "Different items!");
			}
		}
	}
}
