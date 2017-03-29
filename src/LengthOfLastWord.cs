using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
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
