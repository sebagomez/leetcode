using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class UniquePathsIIITests
	{
		[Fact]
		public void UniquePathsIIITests1()
		{

			int[][] grid = new int[][] { new[] { 1,0,0,0 },
										 new[] { 0,0,0,0 },
										 new[] { 0,0,2,-1 }};

			InternalTest(grid, 2);
		}

		[Fact]
		public void UniquePathsIIITests2()
		{

			int[][] grid = new int[][] { new[] { 1,0,0,0 },
										 new[] { 0,0,0,0 },
										 new[] { 0,0,0,2 }};

			InternalTest(grid, 4);
		}

		[Fact]
		public void UniquePathsIIITests3()
		{

			int[][] grid = new int[][] { new[] { 0,1 },
										 new[] { 2,0 }};

			InternalTest(grid, 0);
		}

		void InternalTest(int[][] grid, int expected)
		{
			int actual = UniquePathsIII.Solve(grid);
			Assert.Equal<int>(expected, actual);
		}

	}
}
