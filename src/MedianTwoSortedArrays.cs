using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class MedianTwoSortedArrays
	{
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			int length = nums1.Length + nums2.Length;
			int[] merge = new int[length];
			int j = 0;
			int k = 0;
			for (int i = 0; i < merge.Length; i++)
			{
				bool take1 = (j < nums1.Length && k < nums2.Length && nums1[j] <= nums2[k]) || 
							((j == nums1.Length || k == nums2.Length) && j < nums1.Length);
				if (take1)
				{
					merge[i] = nums1[j];
					j++;
				}
				else
				{
					merge[i] = nums2[k];
					k++;
				}
			}

			if (length % 2 == 0)
				return (merge[(length / 2) - 1] + merge[length / 2]) / 2d;
			else
				return merge[length / 2];
		}
	}
}
