using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class LongestPalindrome
	{
		public static int Solve(string s)
		{
			if (s.Length <= 1)
				return s.Length;

			if (s.Length == 2)
			{
				if (s[0] == s[1])
					return s.Length;
				else
					return 1;
			}

			Dictionary<char, int> aux = new Dictionary<char, int>();
			for (int i = 0; i < s.Length; i++)
			{
				if (aux.ContainsKey(s[i]))
					aux[s[i]]++;
				else
					aux[s[i]] = 1;
			}

			int max = 0;
			int maxOdd = 0;
			foreach (char c in aux.Keys)
			{
				if (aux[c] % 2 == 0)
					max += aux[c];
				else
				{
					max += aux[c] - 1;
					maxOdd = Math.Max(maxOdd, aux[c]);
				}
			}

			return maxOdd > 0 ? max + 1 : max;
		}
	}
}
