using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class FindPeak
	{
		public static int FindPeakElement(int[] nums)
		{
			return GetPeak(nums, 0, nums.Length - 1);
		}

		private static int GetPeak(int[] nums, int l, int r)
		{
			int m = l + (r - l) / 2;
			int j = m - 1;
			int k = m + 1;
			if (j < l && k > r)
				return m;
			else if (j < l && nums[m] >= nums[k])
				return m;
			else if (k > r && nums[j] <= nums[m])
				return m;
			else if (j >= l && k <= r && nums[j] <= nums[m] && nums[m] >= nums[k])
				return m;

			if (k <= r && nums[k] >= nums[m])
				return GetPeak(nums, m + 1, r);
			else if (j >= l && nums[j] >= nums[m])
				return GetPeak(nums, l, m);

			return -1;
		}

		public static int FindPeakElement_slow(int[] nums)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				int j = i - 1;
				int k = i + 1;
				if (j < 0 && k == nums.Length)
				{
					return i;
				}
				else if (j < 0 && nums[i] >= nums[k])
				{
					return i;
				}
				else if (k == nums.Length && nums[j] <= nums[i])
				{
					return i;
				}
				else if (j >= 0 && k <= nums.Length && nums[j] <= nums[i] && nums[i] >= nums[k])
				{
					return i;
				}
			}

			return -1;
		}
	}
}
