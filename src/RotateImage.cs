using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class RotateImage
	{
		public static void Rotate(int[][] matrix)
		{
			int length = matrix.GetLength(0);
			int moves = length - 1;
			Dictionary<string, bool> visited = new Dictionary<string, bool>();

			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					string key = $"{i}{j}";
					if (visited.ContainsKey(key))
						continue;

					visited[key] = true;

					int newJ = moves - i;
					int newI = j;
					int currentI = i;
					int currentJ = j;
					int currentValue = matrix[currentI][currentJ];
					int aux = 0;
					while (i != newI || j != newJ)
					{
						key = $"{newI}{newJ}";
						visited[key] = true;

						aux = matrix[newI][newJ];
						matrix[newI][newJ] = currentValue;
						currentI = newI;
						currentJ = newJ;
						newJ = moves - currentI;
						newI = currentJ;
						currentValue = aux;
					}
					matrix[i][j] = currentValue;
				}
			}
		}
	}
}
