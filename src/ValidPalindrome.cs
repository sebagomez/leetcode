using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ValidPalindrome
	{
		public static bool IsPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s))
				return true;

			s = s.ToLower();

			int left = 0;
			int right = s.Length - 1;
			while (left < right)
			{
				char a = s[left];
				char b = s[right];

				while (!IsValidChar(a) && left < right)
				{
					left++;
					a = s[left];
				}

				while (!IsValidChar(b) && left < right)
				{
					right--;
					b = s[right];
				}

				if (a != b)
					return false;

				left++;
				right--;
			}

			return true;
		}

		private static bool IsValidChar(char c)
		{
			return (c > 96 && c < 123) || (c > 47 && c < 58);
		}
	}
}
