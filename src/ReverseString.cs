using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ReverseString
	{
		public static void Solve(char[] s)
		{
			if (s.Length == 0)
				return;

			int start = 0;
			int end = s.Length - 1;
			while (start < end)
			{
				char aux = s[start];
				s[start] = s[end];
				s[end] = aux;
				start++;
				end--;
			}
		}
	}
}
