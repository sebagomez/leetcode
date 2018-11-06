using System;
using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/container-with-most-water/
	/// </summary>
	public class ContainerWithMostWater
	{
		public static int MaxArea(int[] height)
		{
			int max = int.MinValue;
			for (int i = 0; i < height.Length; i++)
			{
				for (int j = i + 1; j < height.Length; j++)
				{
					max = Math.Max(max, (j - i) * Math.Min(height[i], height[j]));
				}
			}

			return max;
		}

		public static int SmartMaxArea(int[] height)
		{
			int max = int.MinValue;
			int left = 0;
			int right = height.Length - 1;

			while (left < right)
			{
				int area = Math.Min(height[left], height[right]) * (right - left);
				max = Math.Max(max, area);
				if (height[left] < height[right])
					left++;
				else
					right--;
			}

			return max;
		}
	}
}
