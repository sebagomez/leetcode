using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class Search2DMatrix
	{
		public static bool SearchMatrix(int[,] matrix, int target)
		{
			int lengthX = matrix.GetLength(0);
			int lengthY = matrix.GetLength(1);

			if (lengthX == 0 || lengthY == 0)
				return false;

			for (int i = 0; i < lengthX; i++)
			{
				if (matrix[i, 0] > target)
					return false;

				if (matrix[i, 0] <= target && matrix[i, lengthY - 1] >= target)
				{
					for (int j = 0; j < lengthY; j++)
					{
						if (matrix[i, j] == target)
							return true;
					}

					return false;
				}
			}

			return false;
		}
	}
}
