using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/k-diff-pairs-in-an-array/
	/// </summary>
	public class KDiffPairs
	{

		public static int FindPairs(int[] nums, int k)
		{
			if (k < 0)
				return 0;

			Dictionary<int, int> vector = new Dictionary<int, int>();
			HashSet<string> pairs = new HashSet<string>();

			for (int i = 0; i < nums.Length; i++)
			{
				if (vector.ContainsKey(nums[i]))
					vector[nums[i]]++;
				else
					vector[nums[i]] = 1;
			}

			int count = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				int num = nums[i];
				int low = num - k;
				int high = num + k;
				if (k != 0)
				{
					if (vector.ContainsKey(low) && !pairs.Contains($"{num}:{low}"))
					{
						count++;
						pairs.Add($"{num}:{low}");
						pairs.Add($"{low}:{num}");
					}

					if (vector.ContainsKey(high) && !pairs.Contains($"{num}:{high}"))
					{
						count++;
						pairs.Add($"{num}:{high}");
						pairs.Add($"{high}:{num}");
					}
				}
				else
				{
					if (vector[low] > 1 && !pairs.Contains($"{num}:{low}"))
					{
						count++;
						pairs.Add($"{num}:{low}");
					}
				}
			}

			return count;
		}

		public static int FindPairs_old(int[] nums, int k)
		{
			if (k < 0)
				return 0;

			Dictionary<string, int> pairs = new Dictionary<string, int>();
			Dictionary<int, int> diffs = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				int num = nums[i];

				int[] possibles = new[] { num - k, num + k };
				foreach (int operand in possibles)
				{
					if (diffs.ContainsValue(operand))
					{
						string key = $"{operand}:{num}";
						if (num < operand)
							key = $"{num}:{operand}";
						if (pairs.ContainsKey(key))
							pairs[key] += 1;
						else
							pairs.Add(key, 1);
					}
				}

				diffs.Add(i, num);
			}

			return pairs.Count();
		}
	}
}

