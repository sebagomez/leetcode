using System;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/description/
	/// </summary>
	public class BuyAndSellStocks
	{
		public static int MaxProfit(int[] prices)
		{
			int sell = 0, prev_sell = 0, buy = int.MinValue, prev_buy;
			foreach (int price in prices)
			{
				prev_buy = buy;
				buy = Math.Max(prev_sell - price, prev_buy);
				prev_sell = sell;
				sell = Math.Max(prev_buy + price, prev_sell);
			}
			return sell;
		}
	}
}
