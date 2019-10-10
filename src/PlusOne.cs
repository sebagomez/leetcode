using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class PlusOne
	{
		public static int[] Solve(int[] digits)
		{
			bool done = false;
			for (int i = digits.Length - 1; i >= 0; i--)
			{
				int current = digits[i];
				if (current != 9)
				{
					digits[i] = ++current;
					done = true;
					break;
				}
				digits[i] = 0;
			}

			if (done)
				return digits;

			// need a bigger array
			int[] copy = new int[digits.Length + 1];
			for (int i = digits.Length - 1; i >= 0; i--)
			{
				copy[i] = digits[i];
			}

			copy[0] = 1;

			return copy;
		}
	}
}
