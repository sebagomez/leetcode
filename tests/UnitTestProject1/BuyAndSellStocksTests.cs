﻿using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class BuyAndSellStocksTests
	{
		[TestMethod]
		public void Test1BuyAndSellStocksTests1()
		{
			InternalTest(new int[] { 7, 1, 5, 3, 6, 4 }, 5);
		}

		[TestMethod]
		public void Test1BuyAndSellStocksTests2()
		{
			InternalTest(new int[] { 7, 6, 4, 3, 1 }, 0);
		}

		[TestMethod]
		public void Test1BuyAndSellStocksTests3()
		{
			InternalTest(new int[] { 3, 2, 6, 5, 0, 3 }, 4);
		}

		void InternalTest(int[] prices, int expected)
		{
			int value = BuyAndSellStocks.MaxProfit(prices);
			Assert.AreEqual<int>(value, expected, $"For {prices} returned {value}");
		}
	}
}
