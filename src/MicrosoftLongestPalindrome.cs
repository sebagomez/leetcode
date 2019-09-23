using System;
using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/longest-palindromic-substring/
	/// </summary>
	public class MicrosoftLongestPalindrome
	{
		public static string LongestPalindrome(string s)
		{
			if (s.Length == 0)
				return s;

			Dictionary<int, int> aux = new Dictionary<int, int>();
			int max = int.MinValue;
			for (int i = 0; i < s.Length; i++)
			{
				for (int j = s.Length - 1; j > i; j--)
				{
					if (j - i + 1 < max)
						break;

					while (s[i] != s[j] && j >= 0)
						j--;

					if (i == j || j < 0)
						break;

					if (j - i + 1 < max)
						break;

					int left = i;
					int right = j;
					while (left < right)
					{
						if (s[left] != s[right])
							break;
						left++;
						right--;
					}

					if (left >= right)
					{
						int length = (j - i) + 1;
						if (length == s.Length)
							return s;

						aux[length] = i;

						max = Math.Max(length, max);
					}
				}
			}

			if (max > 0)
				return s.Substring(aux[max], max);
			else
				return s[0].ToString();
		}

		public static bool IsPalindrome(string text)
		{
			int m = 0;
			int n = text.Length - 1;
			while (m < n)
			{
				if (text[m] != text[n])
					return false;
				m++;
				n--;
			}
			return true;
		}
	}
}
