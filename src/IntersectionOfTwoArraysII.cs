using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class IntersectionOfTwoArraysII
	{
		public static int[] Intersect(int[] nums1, int[] nums2)
		{
			List<int> result = new List<int>();
			Dictionary<int, int> aux1 = new Dictionary<int, int>();
			for (int i = 0; i < nums1.Length; i++)
			{
				if (aux1.ContainsKey(nums1[i]))
					aux1[nums1[i]]++;
				else
					aux1[nums1[i]] = 1;
			}

			Dictionary<int, int> aux2 = new Dictionary<int, int>();
			for (int i = 0; i < nums2.Length; i++)
			{
				if (aux2.ContainsKey(nums2[i]))
					aux2[nums2[i]]++;
				else
					aux2[nums2[i]] = 1;
			}

			Dictionary<int, int> shortest = nums2.Length <= nums1.Length ? aux2 : aux1;
			Dictionary<int, int> longest = nums2.Length <= nums1.Length ? aux1 : aux2;

			foreach (var item in longest.Keys)
			{
				if (shortest.ContainsKey(item))
				{
					int count = Math.Min(longest[item], shortest[item]);
					while (count != 0)
					{
						result.Add(item);
						count--;
					}
				}
			}

			return result.ToArray();
		}
	}
}
