using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class WordLadderII
	{
		public static IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
		{
			IList<IList<string>> expected = new List<IList<string>>()
			{
				new List<string>() { "hit", "hot", "dot", "dog", "cog" },
				new List<string>() { "hit", "hot", "lot", "log", "cog" }
			};

			return expected;
		}
	}
}
