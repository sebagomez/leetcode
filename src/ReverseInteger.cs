using System;

namespace LeetCode
{
	public class ReverseInteger
	{
		public static int Reverse(int x)
		{
			try
			{
				string rev = "";
				bool negative = x < 0;
				if (negative)
					x = Math.Abs(x);

				string strX = x.ToString();
				for (int i = strX.Length - 1; i >= 0; i--)
					rev += strX[i];

				return negative ? -int.Parse(rev) : int.Parse(rev);
			}
			catch (OverflowException)
			{
				return 0;
			}
		}
	}
}
