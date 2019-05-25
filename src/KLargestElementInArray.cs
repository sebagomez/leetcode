using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	//https://leetcode.com/problems/kth-largest-element-in-an-array/
	public class KLargestElementInArray
	{
		public static int FindKthLargest(int[] nums, int k)
		{
			//I can do bubble k times
			for (int i = 1; i <= k; i++)
			{
				for (int j = 0; j < nums.Length - 1; j++)
				{
					if (nums[j] > nums[j + 1])
					{
						int aux = nums[j + 1];
						nums[j + 1] = nums[j];
						nums[j] = aux;
					}
				}
			}

			return nums[nums.Length - k];
		}
	}
}
