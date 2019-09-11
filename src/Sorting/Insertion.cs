using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sorting
{
	public class Insertion
	{
		public static int[] Sort(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int t = arr[i];
				int j;
				for (j = i; j > 0 && t < arr[j-1]; j--)
					arr[j] = arr[j - 1];
				
				arr[j] = t;
			}
			return arr;
		}
	}
}
