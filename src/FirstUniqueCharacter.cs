using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class FirstUniqueCharacter
	{
		public static int FirstUniqChar(string s)
		{
			Dictionary<char, List<int>> counts = new Dictionary<char, List<int>>();
			for (int i = 0; i < s.Length; i++)
			{
				if (counts.ContainsKey(s[i]))
					counts[s[i]].Add(i);
				else
					counts[s[i]] = new List<int>() { i };
			}

			foreach (var key in counts.Keys)
			{
				if (counts[key].Count == 1)
					return counts[key][0];
			}

			return - 1;
		}
	}
}
