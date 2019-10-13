using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class FizzBuzzTests
	{
		[Fact]
		public void FizzBuzzTests1()
		{
			List<string> expected = new List<string>()
			{
				"1",
				"2",
				"Fizz",
				"4",
				"Buzz",
				"Fizz",
				"7",
				"8",
				"Fizz",
				"Buzz",
				"11",
				"Fizz",
				"13",
				"14",
				"FizzBuzz"
			};
			InternalTest(15, expected);
		}

		void InternalTest(int n, IList<string> expected)
		{
			IList<string> actual = FizzBuzz.Solve(n);
			Assert.Equal<int>(expected.Count, actual.Count);
			for (int i = 0; i < actual.Count; i++)
				Assert.Equal(expected[i], actual[i]);
		}
	}
}
