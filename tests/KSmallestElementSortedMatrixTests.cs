using Leetcode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class KSmallestElementSortedMatrixTests
	{
		[Fact]
		public void KSmallestElementSortedMatrixTests1()
		{
			int[][] matrix = new int[][] { new int[] {  1,  5,  9 },
											new int[] { 10, 11, 13 },
											new int[] { 12, 13, 15 }};
			InternalTest(matrix, 8, 13);
		}

		void InternalTest(int[][] matrix, int k, int expected)
		{
			int actual = KSmallestElementSortedMatrix.KthSmallest(matrix, k);
			Assert.Equal(expected, actual);
		}
	}
}
