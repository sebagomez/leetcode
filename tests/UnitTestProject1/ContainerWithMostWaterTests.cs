using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class ContainerWithMostWaterTests
	{
		[TestMethod]
		public void Test1()
		{
			InternalTest(new int[] { 1, 1 }, 1);
		}

		[TestMethod]
		public void Test2()
		{
			InternalTest(new int[] { 0, 2 }, 0);
		}

		[TestMethod]
		public void Test3()
		{
			InternalTest(new int[] { 1, 2, 1 }, 2);
		}

		[TestMethod]
		public void Test4()
		{
			InternalTest(new int[] { 1, 2, 4, 3 }, 4);
		}

		void InternalTest(int[] height, int expected)
		{
			int value = ContainerWithMostWater.SmartMaxArea(height);
			Assert.AreEqual<int>(expected, value, $"Expected: {expected}, got {value}");
		}
	}
}
