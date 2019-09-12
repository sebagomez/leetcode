using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class UniquePathsIII
	{
		public static int Solve(int[][] grid)
		{
			int x = 0, y = 0;
			int obstacles = 0;
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid[i].GetLength(0); j++)
				{
					if (grid[i][j] == 1)
					{
						x = i;
						y = j;
					}
					else if (grid[i][j] == -1)
						obstacles++;
				}
			}

			int maxJumps = grid.GetLength(0) * grid[0].GetLength(0) - 1 - obstacles;
			int jumps = 0;
			int count = 0;
			FindPath(grid, x, y, ref jumps, maxJumps, ref count);

			return count;
		}

		static int[][] s_moves = new int[][] { new int[] { 0,1 },
											   new int[] { 1,0 },
											   new int[] { 0,-1 },
											   new int[] { -1,0 }};

		private static void FindPath(int[][] grid, int x, int y, ref int jumps, int maxJumps, ref int count)
		{
			if (x < 0 || x > grid.GetLength(0) - 1 || y < 0 || y > grid[x].GetLength(0) - 1)
				return;

			if (grid[x][y] >= 10)
				return;

			if (grid[x][y] == -1)
				return;

			if (grid[x][y] == 2)
			{
				if (jumps == maxJumps)
				{
					count++;
				}
				return;
			}

			grid[x][y] = grid[x][y] + 10;

			foreach (int[] direction in s_moves)
			{
				jumps++;
				FindPath(grid, x + direction[0], y + direction[1], ref jumps, maxJumps, ref count);
				jumps--;
			}
			grid[x][y] = grid[x][y] - 10;
		}
	}
}
