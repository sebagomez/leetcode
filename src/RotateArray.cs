using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class RotateArray
	{
		public static void Rotate(int[] nums, int k)
		{
			Dictionary<int, int> aux = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
				aux[i] = nums[i];

			for (int i = 0; i < nums.Length; i++)
			{
				int newIndex = i + k;
				while (newIndex >= nums.Length)
					newIndex -= nums.Length;

				nums[newIndex] = aux[i];
			}
		}
	}
}
