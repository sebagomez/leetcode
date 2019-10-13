using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class NumberOfIslandsTests
	{
		[Fact]
		public void NumberOfIslandsTests1()
		{
			char[][] grid = new char[][] { new[] { '1','1','1','1','0' },
										   new[] { '1','1','0','1','0' },
										   new[] { '1','1','0','0','0' },
										   new[] { '0','0','0','0','0' }};
			InternalTest(grid, 1);
		}

		[Fact]
		public void NumberOfIslandsTests2()
		{
			char[][] grid = new char[][] { new[] { '1','1','0','0','0' },
										   new[] { '1','1','0','0','0' },
										   new[] { '0','0','1','0','0' },
										   new[] { '0','0','0','1','1' }};
			InternalTest(grid, 3);
		}

		[Fact]
		public void NumberOfIslandsTests3()
		{
			char[][] grid = new char[][] {  };
			InternalTest(grid, 0);
		}

		[Fact]
		public void NumberOfIslandsTests4()
		{
			char[][] grid = new char[][] { new[] { '1','0','1','1','1' },
										   new[] { '1','0','1','0','1' },
										   new[] { '1','1','1','0','1' }};
			InternalTest(grid, 1);
		}

		[Fact]
		public void NumberOfIslandsTests5()
		{
			char[][] grid = new char[][] { new[] { '1','1','1' },
										   new[] { '0','1','0' },
										   new[] { '1','1','1'}};
			InternalTest(grid, 1);
		}

		void InternalTest(char[][] grid, int expected)
		{
			char[][] clone = CloneGrid(grid);
			int actual = NumberOfIslands.BFSNumIslands(grid);
			Assert.Equal<int>(expected, actual);

			actual = NumberOfIslands.DFSNumIslands(clone);
			Assert.Equal<int>(expected, actual);
		}

		char[][] CloneGrid(char[][] grid)
		{
			char[][] clone = new char[grid.GetLength(0)][];
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				char[] array = new char[grid[i].GetLength(0)];
				for (int j = 0; j < grid[i].GetLength(0); j++)
				{
					array[j] = grid[i][j];
				}
				clone[i] = array;
			}

			return clone;
		}
	}
}
