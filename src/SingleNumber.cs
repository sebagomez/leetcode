using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class SingleNumber
	{
		public static int Solve(int[] nums)
		{
			HashSet<int> aux = new HashSet<int>();
			for (int i = 0; i < nums.Length; i++)
			{
				if (aux.Contains(nums[i]))
					aux.Remove(nums[i]);
				else
					aux.Add(nums[i]);
			}

			return aux.ToArray()[0];
		}
	}
}
