using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class GenerateParentheses
	{
		const string OPEN = "(";
		const string CLOSE = ")";

		public static IList<string> GenerateParenthesis(int n)
		{
			List<string> list = new List<string>();

			if (n == 0)
				return list;

			GetSet(n, n, "", list);

			return list;
		}

		private static void GetSet(int left, int right, string subSolution, List<string> result)
		{
			// base case
			if (left == 0 && right == 0)
			{
				result.Add(subSolution);
				return;
			}
			// recursive rule
			if (left > 0)
			{
				GetSet(left - 1, right, subSolution + "(", result);
			}
			if (right > left)
			{
				GetSet(left, right - 1, subSolution + ")", result);
			}
		}
	}
}

