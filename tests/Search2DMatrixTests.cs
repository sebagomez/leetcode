using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class Search2DMatrixTests
	{
		[Fact]
		public void Search2DMatrixTests1()
		{
			int[,] matrix = new int[,]
			{
				{ 1,   3,  5,  7},
				{ 10, 11, 16, 20},
				{ 23, 30, 34, 50}
			};

			InternalTest(matrix, 3, true);
		}

		[Fact]
		public void Search2DMatrixTests2()
		{
			int[,] matrix = new int[,] { { } };

			InternalTest(matrix, 3, false);
		}

		[Fact]
		public void Search2DMatrixTests3()
		{
			int[,] matrix = new int[,] { { 1 } };

			InternalTest(matrix, 1, true);
		}

		void InternalTest(int[,] matrix, int target, bool expected)
		{
			bool value = Search2DMatrix.SearchMatrix(matrix, target);
			Assert.Equal<bool>(expected, value);
		}
	}
}
