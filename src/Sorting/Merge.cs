using System.Linq;

namespace LeetCode.Sorting
{
	public class Merge
	{
		public static int[] Sort(int[] arr)
		{
			int mid = arr.Length / 2;
			return MergeArrays(arr.Take(mid).ToArray(), arr.Skip(mid).ToArray());
		}

		static int[] MergeArrays(int[] a, int[] b)
		{
			int[] mergedA = a;
			if (a.Length > 1)
			{
				int midA = a.Length / 2;
				mergedA = MergeArrays(a.Take(midA).ToArray(), a.Skip(midA).ToArray());
			}

			int[] mergedB = b;
			if (b.Length > 1)
			{
				int midB = b.Length / 2;
				mergedB = MergeArrays(b.Take(midB).ToArray(), b.Skip(midB).ToArray());
			}

			int[] helper = new int[mergedA.Length + mergedB.Length];
			int j = 0;
			int k = 0;
			for (int i = 0; i < helper.Length; i++)
			{
				if (j >= mergedA.Length)
				{
					helper[i] = mergedB[k];
					k++;
				}
				else if (k >= mergedB.Length)
				{
					helper[i] = mergedA[j];
					j++;
				}
				else if (mergedA[j] < mergedB[k])
				{
					helper[i] = mergedA[j];
					j++;
				}
				else
				{
					helper[i] = mergedB[k];
					k++;
				}
			}

			return helper;
		}
	}
}
