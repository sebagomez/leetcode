using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/flood-fill/
	/// </summary>
	public class FloodFill
	{
		public static int[][] Solve(int[][] image, int sr, int sc, int newColor)
		{
			int baseColor = image[sr][sc];

			PaintCell(image, sr, sc, baseColor, newColor);

			return image;
		}

		private static void PaintCell(int[][] image, int i, int j, int baseColor, int newColor)
		{
			if (i < 0 || j < 0 || i > image.GetLength(0) - 1 || j > image[i].GetLength(0) - 1)
				return; // not a valid possition (out of bounds)

			if (image[i][j] < 0)
				return; //negatove integer => already visited

			if (image[i][j] == baseColor)
				image[i][j] = newColor;
			else
				return; //not the original color, do nothing

			image[i][j] = 0 - image[i][j];

			int[][] move = new int[][] { new[] { 0, 1 },
										 new[] { 1, 0 },
										 new[] { 0, -1 },
										 new[] { -1, 0 } };

			foreach (int[] coords in move)
			{
				PaintCell(image, i + coords[0], j + coords[1], baseColor, newColor);
			}

			image[i][j] = 0 - image[i][j];
		}
	}
}
