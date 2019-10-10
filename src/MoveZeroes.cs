using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class MoveZeroes
	{
		public static void Solve(int[] nums)
		{
			int k = nums.Length;
			for (int i = 0; i < k; i++)
			{
				if (nums[i] != 0)
					continue;
				
				int j = i;
				i--;
				while (j < k - 1)
				{
					int tmp = nums[j + 1];
					nums[j + 1] = nums[j];
					nums[j] = tmp;
					j++;
				}
				k--;
			}
		}
	}
}
