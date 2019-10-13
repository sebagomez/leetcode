using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class MergeSortedArrayTests
	{
		[Fact]
		public void MergeSortedArrayTests1()
		{
			int[] n1 = new int[] { 1, 2, 3, 0, 0, 0 };
			int[] n2 = new int[] { 2, 5, 6 };
			int[] expected = new int[] { 1, 2, 2, 3, 5, 6 };
			InternalTest(n1, 3, n2, 3, expected);
		}

		[Fact]
		public void MergeSortedArrayTests2()
		{
			int[] n1 = new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
			int[] n2 = new int[] { 1, 2, 2 };
			int[] expected = new int[] { -1, 0, 0, 1, 2, 2, 3, 3, 3 };
			InternalTest(n1, 6, n2, 3, expected);
		}

		[Fact]
		public void MergeSortedArrayTests3()
		{
			int[] n1 = new int[] { 0 };
			int[] n2 = new int[] { 1 };
			int[] expected = new int[] { 1 };
			InternalTest(n1, 0, n2, 1, expected);
		}

		[Fact]
		public void MergeSortedArrayTests4()
		{
			int[] n1 = new int[] { 1, 2, 3, 0, 0, 0 };
			int[] n2 = new int[] { 4, 5, 6 };
			int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };
			InternalTest(n1, 3, n2, 3, expected);
		}

		void InternalTest(int[] n1, int m, int[] n2, int n, int[] expected)
		{
			MergeSortedArray.Merge(n1, m, n2, n);
			Assert.Equal<int>(expected.Length, n1.Length);
			for (int i = 0; i < n1.Length; i++)
			{
				Assert.Equal<int>(expected[i], n1[i]);
			}
		}
	}
}
