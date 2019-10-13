using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class TrappingRainWaterTests
	{
		[Fact]
		public void TrappingRainWaterTests1()
		{
			int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
			InternalTest(height, 6);
		}

		[Fact]
		public void TrappingRainWaterTests2()
		{
			int[] height = new int[] { };
			InternalTest(height, 0);
		}

		[Fact]
		public void TrappingRainWaterTests3()
		{
			int[] height = new int[] { 1, 0, 1 };
			InternalTest(height, 1);
		}

		[Fact]
		public void TrappingRainWaterTests4()
		{
			int[] height = new int[] { 2, 1, 0, 2 };
			InternalTest(height, 3);
		}

		void InternalTest(int[] height, int expected)
		{
			int actual = TrappingRainWater.SmartTrap(height);
			Assert.Equal<int>(expected, actual);
		}
	}
}
