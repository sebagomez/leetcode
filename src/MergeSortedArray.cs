using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class MergeSortedArray
	{
		public static void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			int j = 0;
			for (int i = 0; i < n; i++)
			{
				while (j < nums1.Length && nums1[j] <= nums2[i] && j < i+m)
					j++;

				if (j == nums1.Length)
				{
					nums1[j - 1] = nums2[i];
					return;
				}

				for (int k = nums1.Length - 1; k > j; k--)
					nums1[k] = nums1[k - 1];

				nums1[j] = nums2[i];
			}
		}
	}
}
