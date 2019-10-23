using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class KSmallestElementSortedMatrix
	{
		public static int KthSmallest(int[][] matrix, int k)
		{
			Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
			Dictionary<int, int> pointer = new Dictionary<int, int>();
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				dict[i] = matrix[i];
				pointer[i] = 0;
			}

			int min = int.MaxValue;
			int index = 0;
			int loop = 1;

			while (loop <=k)
			{
				int curentMin = int.MaxValue;
				for (int i = 0; i < dict.Keys.Count; i++)
				{
					int p = pointer[i];
					if (p < dict[i].Length && dict[i][p] <= curentMin)
					{
						index = i;
						curentMin = dict[i][p];
					}
				}

				min = dict[index][pointer[index]];
				pointer[index]++;

				loop++;
			}

			return min;
		}
	}
}
