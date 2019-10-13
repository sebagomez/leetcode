using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class BuyAndSellStocksTests
	{
		[Fact]
		public void Test1BuyAndSellStocksTests1()
		{
			InternalTest(new int[] { 7, 1, 5, 3, 6, 4 }, 5);
		}

		[Fact]
		public void Test1BuyAndSellStocksTests2()
		{
			InternalTest(new int[] { 7, 6, 4, 3, 1 }, 0);
		}

		[Fact]
		public void Test1BuyAndSellStocksTests3()
		{
			InternalTest(new int[] { 3, 2, 6, 5, 0, 3 }, 4);
		}

		void InternalTest(int[] prices, int expected)
		{
			int value = BuyAndSellStocks.MaxProfit(prices);
			Assert.Equal<int>(expected, value);
		}
	}
}
