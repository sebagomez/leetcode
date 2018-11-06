using System;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/length-of-last-word/
	/// </summary>
	public class LengthOfLastWord
	{
		public static int FindLengthOfLastWord(string s)
		{
			string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (words.Length > 0)
				return words[words.Length - 1].Length;

			return 0;
		}
	}
}
