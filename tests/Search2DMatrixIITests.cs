using Leetcode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class Search2DMatrixIITests
	{
		[Fact]
		public void Search2DMatrixIITests1()
		{
			int[,] matrix = new int[,]
			{
				{  1,  4,  7, 11, 15 },
				{  2,  5,  8, 12, 19 },
				{  3,  6,  9, 16, 22 },
				{ 10, 13, 14, 17, 24 },
				{ 18, 21, 23, 26, 30 }
			};

			InternalTest(matrix, 5, true);
		}

		[Fact]
		public void Search2DMatrixIITests2()
		{
			int[,] matrix = new int[,]
			{
				{  1,  4,  7, 11, 15 },
				{  2,  5,  8, 12, 19 },
				{  3,  6,  9, 16, 22 },
				{ 10, 13, 14, 17, 24 },
				{ 18, 21, 23, 26, 30 }
			};

			InternalTest(matrix, 20, false);
		}

		[Fact]
		public void Search2DMatrixIITests3()
		{
			int[,] matrix = new int[,]
			{
				{ }
			};

			InternalTest(matrix, 1, false);
		}

		[Fact]
		public void Search2DMatrixIITests4()
		{
			int[,] matrix = new int[,]
			{
				{  3,  5,  9,  9, 14 },
				{  7,  8, 11, 15, 15 },
				{  8, 10, 16, 16, 17 }
			};

			InternalTest(matrix, 12, false);
		}

		void InternalTest(int[,] matrix, int target, bool expected)
		{
			bool value = Search2DMatrixII.SearchMatrix(matrix, target);
			Assert.Equal<bool>(expected, value);
		}
	}
}
