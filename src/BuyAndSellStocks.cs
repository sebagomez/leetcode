using System;

namespace LeetCode
{
	/// <summary>
	/// 
	/// </summary>
	public class BuyAndSellStocks
	{
		public static int MaxProfit(int[] prices)
		{
			int benefit = 0;
			int buy = 0;
			int prev_buy = int.MaxValue;
			int prev_benefit = int.MinValue;
			foreach (int price in prices)
			{
				buy = Math.Min(price, prev_buy);
				prev_benefit = benefit;
				benefit = Math.Max(price - buy, prev_benefit);
				prev_buy = buy;
			}
			return benefit;
		}
	}
}
