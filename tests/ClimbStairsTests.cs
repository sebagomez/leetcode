using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class ClimbStairsTests
	{
		[Fact]
		public void ClimbStairsTests1()
		{
			InternalTest(2, 2);
		}

		[Fact]
		public void ClimbStairsTests2()
		{
			InternalTest(3, 3);
		}

		[Fact]
		public void ClimbStairsTests3()
		{
			InternalTest(4, 5);
		}

		[Fact]
		public void ClimbStairsTests4()
		{
			InternalTest(44, 1134903170);
		}

		void InternalTest(int steps, int expected)
		{
			int actual = ClimbStairs.Solve(steps);
			Assert.Equal<int>(expected, actual);
		}
	}
}
