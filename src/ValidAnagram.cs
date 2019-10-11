using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ValidAnagram
	{
		public static bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length)
				return false;

			Dictionary<char, int> aux = new Dictionary<char, int>();
			for (int i = 0; i < t.Length; i++)
			{
				if (aux.ContainsKey(t[i]))
					aux[t[i]]++;
				else
					aux[t[i]] = 1;
			}

			for (int i = 0; i < s.Length; i++)
			{
				if (!aux.ContainsKey(s[i]))
					return false;
				
				aux[s[i]]--;
				if (aux[s[i]] == 0)
					aux.Remove(s[i]);
			}

			return aux.Count == 0;
		}
	}
}
