using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class PrimePalindrome
	{
		public static int Solve(int n)
		{
			if (n == 1)
				return 2;

			for (int i = n; i < int.MaxValue; i++)
			{
				if (IsPalindromeAndPrime(i))
					return i;
			}

			return n;
		}

		private static bool IsPalindromeAndPrime(int n)
		{
			if (n == 2 || n == 11)
				return true;

			string strN = n.ToString();
			int l = 0;
			int r = strN.Length - 1;
			while (l <= r)
			{
				if (strN[l] != strN[r])
					return false;
				l++;
				r--;
			}

			if (strN.Length % 2 == 0)
				return false;

			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0)
					return false;

			}

			return true;
		}
	}
}
