using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ContainsDuplicate
	{
		public static bool Solve(int[] nums)
		{
			HashSet<int> aux = new HashSet<int>();
			for (int i = 0; i < nums.Length; i++)
			{
				if (aux.Contains(nums[i]))
					return true;

				aux.Add(nums[i]);
			}

			return false;
		}
	}
}
