using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/search-a-2d-matrix/
	/// </summary>
	public class Search2DMatrix
	{
		public static bool SearchMatrix(int[][] matrix, int target)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				if (matrix[i].GetLength(0) == 0)
					return false;

				if (matrix[i][0] > target)
					return false;

				if (matrix[i][0] <= target && matrix[i][matrix[i].GetLength(0) - 1] >= target)
				{
					for (int j = 0; j < matrix[i].GetLength(0); j++)
					{
						if (matrix[i][j] == target)
							return true;
					}

					return false;
				}
			}

			return false;
		}
	}
}
