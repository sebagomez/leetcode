using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class TotalHammingDistanceTests
	{
		[TestMethod]
		public void Test1()
		{
			InternalTest(new int[] { 4, 14, 2 }, 6);
		}

		void InternalTest(int[] nums, int expected)
		{
			int value = TotalHammingDistance.Distance(nums);
			Assert.AreEqual<int>(expected, value, $"Expected: {expected}, got {value}");
		}
	}
}
