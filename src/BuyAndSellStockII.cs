﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class BuyAndSellStockII
	{
		public static int MaxProfit(int[] prices)
		{
			if (prices.Length < 2)
				return 0;

			int profit = 0;
			for (int i = 1; i < prices.Length; i++)
			{
				if (prices[i] > prices[i - 1])
					profit += prices[i] - prices[i - 1];
			}

			return profit;
		}
	}
}
