using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class LongestCommonPrefix
	{
		public static string Solve(string[] strs)
		{
			string prefix = "";
			if (strs.Length == 0)
				return prefix;

			if (strs.Length == 1)
				return strs[0];

			int shortestIndex = 0;
			int currentLength = int.MaxValue;
			for (int i = 0; i < strs.Length; i++)
			{
				if (strs[i].Length < currentLength)
				{
					currentLength = strs[i].Length;
					shortestIndex = i;
				}
			}

			for (int i = 0; i < strs[shortestIndex].Length; i++)
			{
				bool include = true;
				char c = strs[shortestIndex][i];
				foreach (string str in strs)
				{
					include &= str[i] == c;
				}

				if (include)
					prefix += c;
				else
					break;
			}

			return prefix;
		}
	}
}
