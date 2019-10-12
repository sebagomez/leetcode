using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ImplementStrStr
	{
		public static int StrStr1(string haystack, string needle)
		{
			if (string.IsNullOrWhiteSpace(needle))
				return 0;

			if (haystack == needle)
				return 0;

			int length = needle.Length;

			for (int i = 0; i <= haystack.Length - length; i++)
			{
				string aux = haystack.Substring(i, length);
				if (aux == needle)
					return i;
			}

			return -1;
		}
	}
}
