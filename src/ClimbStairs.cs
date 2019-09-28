using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/climbing-stairs/
	/// </summary>
	public class ClimbStairs
	{
		static Dictionary<int, int> m_cache = new Dictionary<int, int>();
		public static int Solve(int n)
		{
			return FibonacciOf(n);
		}

		static int FibonacciOf(int n)
		{
			if (n == 1 || n == 2)
				return n;

			if (m_cache.ContainsKey(n))
				return m_cache[n];

			int value = FibonacciOf(n - 1) + FibonacciOf(n - 2);
			m_cache[n] = value;

			return value;
		}
	}
}
