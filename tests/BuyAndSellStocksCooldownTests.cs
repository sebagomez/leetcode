using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class BuyAndSellStocksCooldownTests
	{
		[Fact]
		public void Test1BuyAndSellStocksTests1()
		{
			InternalTest(new int[] { 1, 2, 3, 0, 2 }, 3);
		}

		[Fact]
		public void Test1BuyAndSellStocksTests2()
		{
			InternalTest(new int[] { 7, 1, 5, 3, 6, 4 }, 5);
		}

		[Fact]
		public void Test1BuyAndSellStocksTests3()
		{
			InternalTest(new int[] { 7, 6, 4, 3, 1 }, 0);
		}

		void InternalTest(int[] prices, int expected)
		{
			int value = BuyAndSellStocksCooldown.MaxProfit(prices);
			Assert.Equal<int>(expected, value);
		}
	}
}
