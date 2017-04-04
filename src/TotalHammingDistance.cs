﻿using System;

namespace LeetCode
{
	public class TotalHammingDistance
	{
		public static int Distance(int[] nums)
		{
			int sum = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				string operand1 = Convert.ToString(nums[i], 2);
				for (int j = (i + 1); j < nums.Length; j++)
				{
					string operand2 = Convert.ToString(nums[j], 2);
					int maxLength = Math.Max(operand1.Length, operand2.Length);
					if (operand1.Length != operand2.Length)
					{
						if (operand1.Length != maxLength)
							operand1 = new string('0', maxLength - operand1.Length) + operand1;
						if (operand2.Length != maxLength)
							operand2 = new string('0', maxLength - operand2.Length) + operand2;
					}

					for (int k = 0; k < maxLength; k++)
					{
						if (operand1[k] != operand2[k])
							sum++;
					}
				}
			}

			return sum;
		}
	}
}
