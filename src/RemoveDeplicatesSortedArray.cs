using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/explore/featured/card/top-interview-questions-easy/92/array/727/
	/// </summary>
	public class RemoveDeplicatesSortedArray
	{
		public static int RemoveDuplicates(int[] nums)
		{
			int currIndex = -1;
			int currentValue = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (i == 0)
				{
					currentValue = nums[i];
					currIndex = 0;
					continue;
				}

				if (nums[i] != currentValue)
				{
					currentValue = nums[i];
					nums[++currIndex] = currentValue;
				}
			}

			return ++currIndex;
		}
	}
}
