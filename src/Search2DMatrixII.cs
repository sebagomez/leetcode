using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class Search2DMatrixII
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

				bool found = FindInArray(matrix, i, target);
				if (found)
					return true;
			}

			return false;
		}

		private static bool FindInArray(int[,] matrix, int row, int target)
		{
			int length = matrix.GetLength(1);
			if (matrix[row, length - 1] < target)
				return false;

			int[] array = new int[length];
			int size = System.Runtime.InteropServices.Marshal.SizeOf<int>();
			Buffer.BlockCopy(matrix, row * length * size, array, 0, length * size);

			//for (int i = 0; i < length; i++)
			//	array[i] = matrix[row, i];

			return FindRecursive(array, 0, array.Length - 1, target);
		}

		private static bool FindRecursive(int[] array, int l, int r, int target)
		{
			if (array[r] < target)
				return false;

			if (l == r)
				return array[l] == target;

			int m = (r + l) / 2;
			if (array[m] == target)
				return true;

			if (array[m] > target)
				return FindRecursive(array, l, m, target);
			else
				return FindRecursive(array, m + 1, r, target);
		}
	}
}
