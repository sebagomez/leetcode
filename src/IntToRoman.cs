using System.Text;

namespace LeetCode
{
	public class IntToRoman
	{
		//Symbol Value
		//I             1
		//V             5
		//X             10
		//L             50
		//C             100
		//D             500
		//M             1000
		public static string Solve(int num)
		{
			StringBuilder builder = new StringBuilder();

			num = BuildUnit(num, 'M', 1000, builder);
			num = BuildUnit(num, 'D', 500, builder);
			num = BuildUnit(num, 'C', 100, builder);
			num = BuildUnit(num, 'L', 50, builder);
			num = BuildUnit(num, 'X', 10, builder);
			num = BuildUnit(num, 'V', 5, builder);
			num = BuildUnit(num, 'I', 1, builder);

			builder.Replace("DCCCC", "CM");     //900
			builder.Replace("CCCC", "CD");      //400
			builder.Replace("LXXXX", "XC");     //90
			builder.Replace("XXXX", "XL");      //40
			builder.Replace("VIIII", "IX");     //9
			builder.Replace("IIII", "IV");      //4

			return builder.ToString();
		}

		static int BuildUnit(int num, char roman, int value, StringBuilder builder)
		{
			int times = num / value;
			for (int i = 1; i <= times; i++)
			{
				builder.Append(roman);
				num -= value;
			}

			return num;
		}
	}
}
