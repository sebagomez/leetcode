using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class FizzBuzz
	{
		public static IList<string> Solve(int n)
		{
			List<string> result = new List<string>();
			int three = 1;
			int five = 1;
			for (int i = 1; i <= n; i++)
			{
				if (three == 3 && five == 5)
					result.Add("FizzBuzz");
				else if (three == 3)
					result.Add("Fizz");
				else if (five == 5)
					result.Add("Buzz");
				else
					result.Add(i.ToString());
				if (three == 3)
					three = 1;
				else
					three++;
				if (five == 5)
					five = 1;
				else
					five++;
			}

			return result;
		}
	}
}
