using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class KDiffPairs
	{
		public static int FindPairs(int[] nums, int k)
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

