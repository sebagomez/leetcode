using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class BuyAndSellStocksTests
	{
		[TestMethod]
		public void Test1()
		{
			InternalTest(new int[] { 1, 2, 3, 0, 2 }, 3);

		}

		void InternalTest(int[] prices, int expected)
		{
			int value = BuyAndSellStocks.MaxProfit(prices);
			Assert.AreEqual<int>(value, expected, $"For {prices} returned {value}");
		}
	}
}
