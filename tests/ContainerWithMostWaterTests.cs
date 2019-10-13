using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class ContainerWithMostWaterTests
	{
		[Fact]
		public void Test1()
		{
			InternalTest(new int[] { 1, 1 }, 1);
		}

		[Fact]
		public void Test2()
		{
			InternalTest(new int[] { 0, 2 }, 0);
		}

		[Fact]
		public void Test3()
		{
			InternalTest(new int[] { 1, 2, 1 }, 2);
		}

		[Fact]
		public void Test4()
		{
			InternalTest(new int[] { 1, 2, 4, 3 }, 4);
		}

		void InternalTest(int[] height, int expected)
		{
			int value = ContainerWithMostWater.SmartMaxArea(height);
			Assert.Equal<int>(expected, value);
		}
	}
}
