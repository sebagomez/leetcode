using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
	/// </summary>
	public class LongestSubstring
	{
		public static int LengthOfLongestSubstring(string s)
		{
			if (string.IsNullOrEmpty(s))
				return 0;

			Dictionary<string, int> words = new Dictionary<string, int>();
			Dictionary<char, int> reg = new Dictionary<char, int>();
			string currentWord = "";
			int wordStart = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (string.IsNullOrEmpty(currentWord))
					wordStart = i;

				char c = s[i];
				if (!reg.ContainsKey(c))
				{
					reg.Add(c, i);
					currentWord += c;
				}
				else
				{
					if (!words.ContainsKey(currentWord))
						words.Add(currentWord, currentWord.Length);
					i = wordStart;
					currentWord = "";
					reg = new Dictionary<char, int>();
				}
			}

			if (!words.ContainsKey(currentWord))
				words.Add(currentWord, currentWord.Length);

			return words.Values.Max();
		}
	}
}

