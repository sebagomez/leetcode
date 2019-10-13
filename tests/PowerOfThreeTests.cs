using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class PowerOfThreeTests
	{
		[Fact]
		public void PowerOfThreeTests1()
		{
			InternalTest(9, true);
		}

		[Fact]
		public void PowerOfThreeTests2()
		{
			InternalTest(27, true);
		}

		[Fact]
		public void PowerOfThreeTests3()
		{
			InternalTest(0, false);
		}

		[Fact]
		public void PowerOfThreeTests4()
		{
			InternalTest(45, false);
		}

		[Fact]
		public void PowerOfThreeTests5()
		{
			InternalTest(43046720, false);
		}

		void InternalTest(int n, bool expected)
		{
			bool actual = PowerOfThree.IsPowerOfThree(n);
			Assert.Equal<bool>(expected, actual);
		}
	}
}
