using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode
{
	public class PowerOfThree
	{
		public static bool IsPowerOfThree(int n)
		{
			if (n == 0)
				return false;

			while (n % 3 == 0)
				n /= 3;

			return n == 1;
		}

		public static bool IsPowerOfThree_Recursive(int n)
		{
			for (int i = 0; i <= n; i++)
			{
				double result = Math.Pow(3, i);
				if (result == n)
					return true;
				else if (result > n)
					return false;
			}

			return false;
		}
	}
}
