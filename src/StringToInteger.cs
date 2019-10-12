using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class StringToInteger
	{
		public static int MyAtoi(string str)
		{
			str = str.Trim();
			if (string.IsNullOrEmpty(str))
				return 0;

			string strValue = "";
			bool negative = false;
			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];
				if (i == 0)
				{
					if (c == '-')
					{
						negative = true;
						continue;
					}
					else if (c == '+')
					{
						negative = false;
						continue;
					}
				}

				if (c >= 48 && c <= 57)
					strValue += c;
				else
					break;
			}

			if (string.IsNullOrEmpty(strValue))
				return 0;

			try
			{
				return negative ? int.Parse("-" + strValue) : int.Parse(strValue);
			}
			catch (OverflowException)
			{
				if (negative)
					return int.MinValue;
				else
					return int.MaxValue;
			}
		}
	}
}
