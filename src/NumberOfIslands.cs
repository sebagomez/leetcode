using System;
using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/number-of-islands/description/
	/// </summary>
	public class NumberOfIslands
	{
		public static int NumIslands(char[,] grid)
		{
			const char WATER = '0';
			const char LAND = '1';
			const string NONE = "";

			Dictionary<string, HashSet<string>> islands = new Dictionary<string, HashSet<string>>();
			int lengthX = grid.GetLength(0);
			int lengthY = grid.GetLength(1);
			for (int i = 0; i < lengthX; i++)
			{
				for (int j = 0; j < lengthY; j++)
				{
					Console.Write(grid[i, j]);
					if (grid[i, j] == WATER)
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
							if (k < lengthX && grid[k, j] == LAND)
								islands[island].Add($"{k}:{j}");
							if (l < lengthY && grid[i, l] == LAND)
								islands[island].Add($"{i}:{l}");
						}
					}

					toDelete.ForEach(island => islands.Remove(island));

					if (!isPrevIsland)
					{
						islands.Add(coord, new HashSet<string> { coord });
						int k = i + 1;
						if (k < lengthX && grid[k, j] == LAND)
							islands[coord].Add($"{k}:{j}");
						int l = j + 1;
						if (l < lengthY && grid[i, l] == LAND)
							islands[coord].Add($"{i}:{l}");
					}
				}

				Console.WriteLine();
			}

			return islands.Count;
		}
	}
}

