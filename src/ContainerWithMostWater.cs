using System;

namespace LeetCode
{
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
	}
}
