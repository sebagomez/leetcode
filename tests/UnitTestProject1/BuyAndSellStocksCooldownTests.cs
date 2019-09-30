using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class BuyAndSellStocksCooldownTests
	{
		[TestMethod]
		public void Test1BuyAndSellStocksTests1()
		{
			InternalTest(new int[] { 1, 2, 3, 0, 2 }, 3);
		}

		[TestMethod]
		public void Test1BuyAndSellStocksTests2()
		{
			InternalTest(new int[] { 7, 1, 5, 3, 6, 4 }, 5);
		}

		[TestMethod]
		public void Test1BuyAndSellStocksTests3()
		{
			InternalTest(new int[] { 7, 6, 4, 3, 1 }, 0);
		}

		void InternalTest(int[] prices, int expected)
		{
			int value = BuyAndSellStocksCooldown.MaxProfit(prices);
			Assert.AreEqual<int>(value, expected, $"For {prices} returned {value}");
		}
	}
}
