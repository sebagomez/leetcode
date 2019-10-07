using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class TwoSum
	{
		public static int[] Solve(int[] nums, int target)
		{
			Dictionary<int, List<int>> tmp = new Dictionary<int, List<int>>();
			for (int i = 0; i < nums.Length; i++)
			{
				if (tmp.ContainsKey(nums[i]))
					tmp[nums[i]].Add(i);
				else
					tmp[nums[i]] = new List<int> { i };
			}

			for (int i = 0; i < nums.Length; i++)
			{
				int num = nums[i];
				int diff = target - num;
				if (tmp.ContainsKey(diff) && (!tmp[diff].Contains(i) || tmp[diff].Count > 1))
				{
					if (tmp[diff].Count == 1)
						return new int[] { i, tmp[diff][0] };
					else
						return new int[] { i, tmp[diff].First(x => x != i) };
				}
			}
			return new int[2];
		}
	}
}
