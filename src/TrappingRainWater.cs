using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class TrappingRainWater
	{
		public static int Trap(int[] height)
		{
			int max = GetMaxHeight(height);
			int floorWater = 0;
			for (int f = 1; f <= max; f++) //floors
			{
				bool start = false;
				int bucketWater = 0;
				for (int i = 0; i < height.Length; i++) // holes
				{
					if (!start && height[i] < f)
						continue;

					start = true;

					if (height[i] < f)
					{
						if (i != height.Length - 1)
						{
							bucketWater++;
						}
					}
					else
					{
						floorWater += bucketWater;
						bucketWater = 0;
					}
				}
			}

			return floorWater;
		}

		private static int GetMaxHeight(int[] height)
		{
			if (height.Length == 0)
				return 0;

			int max = int.MinValue;
			for (int i = 0; i < height.Length; i++)
			{
				max = Math.Max(max, height[i]);
			}

			return max;
		}

		public static int SmartTrap(int[] height)
		{
			if (height.Length == 0)
				return 0;

			int left = 0, right = height.Length - 1;
			int leftMax = 0, rightMax = 0;
			int ans = 0;
			while (left < right)
			{
				if (height[left] > leftMax)
					leftMax = height[left];

				if (height[right] > rightMax)
					rightMax = height[right];

				if (leftMax < rightMax)
				{
					ans += Math.Max(0, leftMax - height[left]);
					left++;
				}
				else
				{
					ans += Math.Max(0, rightMax - height[right]);
					right--;
				}
			}
			return ans;
		}
	}
}
