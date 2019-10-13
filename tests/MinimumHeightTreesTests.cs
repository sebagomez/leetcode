using System.Collections.Generic;
using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class MinimumHeightTreesTests
	{
		[Fact]
		public void Test1()
		{
			int n = 4;
			int[][] edges = new int[][] { new int[] { 1, 0 },
										  new int[] { 1, 2 },
										  new int[] { 1, 3 } };
			IList<int> expected = new List<int> { 1 };
			InternalTest(n, edges, expected);
		}

		[Fact]
		public void Test2()
		{
			int n = 6;
			int[][] edges = new int[][] { new int[] { 0, 3 },
											new int[] { 1, 3 },
											new int[] { 2, 3 },
											new int[] { 4, 3 },
											new int[] { 5, 4 } };
			IList<int> expected = new List<int> { 3, 4 };
			InternalTest(n, edges, expected);
		}

		[Fact]
		public void Test3()
		{
			int n = 1;
			int[][] edges = new int[][] { };
			IList<int> expected = new List<int> { 0 };
			InternalTest(n, edges, expected);
		}

		[Fact]
		public void Test4()
		{
			int n = 6;
			int[][] edges = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 0, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 } };
			IList<int> expected = new List<int> { 3 };
			InternalTest(n, edges, expected);
		}

		[Fact]
		public void Test5()
		{
			int n = 2;
			int[][] edges = new int[][] { new int[] { 0, 1 } };
			IList<int> expected = new List<int> { 0, 1 };
			InternalTest(n, edges, expected);
		}

		[Fact]
		public void Test6()
		{
			int n = 8;
			int[][] edges = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 0, 4 }, new int[] { 4, 5 }, new int[] { 4, 6 }, new int[] { 6, 7 } };
			IList<int> expected = new List<int> { 0 };
			InternalTest(n, edges, expected);
		}

		void InternalTest(int n, int[][] edges, IList<int> expected)
		{
			IList<int> value = MinimumHeightTrees.FindMinHeightTrees(n, edges);

			Assert.Equal(expected.Count, value.Count);

			IEnumerator<int> e1 = expected.GetEnumerator();
			IEnumerator<int> e2 = value.GetEnumerator();

			while (e1.MoveNext() && e2.MoveNext())
			{
				Assert.Equal(e1.Current, e2.Current);
			}
		}
	}
}
