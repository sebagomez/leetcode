using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class BuyAndSellStockIITests
	{
		[Fact]
		public void BuyAndSellStockIITests1()
		{
			int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
			InternalTest(prices, 7);
		}

		[Fact]
		public void BuyAndSellStockIITests2()
		{
			int[] prices = new int[] { 1, 2, 3, 4, 5 };
			InternalTest(prices, 4);
		}


		[Fact]
		public void BuyAndSellStockIITests3()
		{
			int[] prices = new int[] { 7, 6, 4, 3, 1 };
			InternalTest(prices, 0);
		}

		void InternalTest(int[] prices, int expected)
		{
			int actual = BuyAndSellStockII.MaxProfit(prices);
			Assert.Equal<int>(expected, actual);
		}
	}
}
