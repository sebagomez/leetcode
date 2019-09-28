using System;
using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/number-of-islands/description/
	/// </summary>
	public class NumberOfIslands
	{
		const char WATER = '0';
		const char LAND = '1';
		const string NONE = "";


		public static int BFSNumIslands(char[][] grid)
		{
			int islands = 0;
			Queue<int[]> q = new Queue<int[]>();
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid[i].GetLength(0); j++)
				{
					if (grid[i][j] == LAND)
					{
						islands++;
						q.Enqueue(new int[] { i, j });
						while (q.Count != 0)
						{
							int[] island = q.Dequeue();
							int x = island[0];
							int y = island[1];

							if (grid[x][y] == LAND)
								grid[x][y] = WATER;
							else
								continue;

							if (x < grid.GetLength(0) - 1)
								q.Enqueue(new int[] { x + 1, y });
							if (x > 0)
								q.Enqueue(new int[] { x - 1, y });
							if (y < grid[i].GetLength(0) - 1)
								q.Enqueue(new int[] { x, y + 1 });
							if (y > 0)
								q.Enqueue(new int[] { x, y - 1 });
						}
					}
				}
			}

			return islands;
		}

		public static int NumIslands(char[][] grid)
		{
			int islands = 0;
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid[i].GetLength(0); j++)
				{
					if (grid[i][j] == LAND)
					{
						islands++;
						DFSIslands(grid, i, j);
					}
				}
			}

			return islands;
		}

		private static void DFSIslands(char[][] grid, int i, int j)
		{
			if (grid[i][j] == LAND)
				grid[i][j] = WATER;
			else
				return;

			if (i < grid.GetLength(0) - 1)
				DFSIslands(grid, i + 1, j);
			if (i > 0)
				DFSIslands(grid, i - 1, j);
			if (j < grid[i].GetLength(0) - 1)
				DFSIslands(grid, i, j + 1);
			if (j > 0)
				DFSIslands(grid, i, j - 1);
		}

		public static int NumIslands_old(char[][] grid)
		{
			Dictionary<string, HashSet<string>> islands = new Dictionary<string, HashSet<string>>();
			int lengthX = grid.GetLength(0);
			if (lengthX == 0)
				return 0;

			int lengthY = grid[0].GetLength(0);
			for (int i = 0; i < lengthX; i++)
			{
				for (int j = 0; j < lengthY; j++)
				{
					Console.Write(grid[i][j]);
					if (grid[i][j] == WATER)
						continue;

					string coord = $"{i}:{j}";
					bool isPrevIsland = false;
					List<string> toDelete = new List<string>();
					string currentIsland = NONE;
					foreach (string island in islands.Keys)
					{
						int l = j + 1;
						string next = $"{i}:{l}";
						if (islands[island].Contains(coord) || islands[island].Contains(next))
						{
							if (isPrevIsland)
							{
								foreach (string item in islands[island])
									islands[currentIsland].Add(item);

								toDelete.Add(island);
								continue;
							}

							isPrevIsland = true;
							currentIsland = island;
							int k = i + 1;
							if (k < lengthX && grid[k][j] == LAND)
								islands[island].Add($"{k}:{j}");
							if (l < lengthY && grid[i][l] == LAND)
								islands[island].Add($"{i}:{l}");
						}
					}

					toDelete.ForEach(island => islands.Remove(island));

					if (!isPrevIsland)
					{
						islands.Add(coord, new HashSet<string> { coord });
						int k = i + 1;
						if (k < lengthX && grid[k][j] == LAND)
							islands[coord].Add($"{k}:{j}");
						int l = j + 1;
						if (l < lengthY && grid[i][l] == LAND)
							islands[coord].Add($"{i}:{l}");
					}
				}

				Console.WriteLine();
			}

			return islands.Count;
		}
	}
}

