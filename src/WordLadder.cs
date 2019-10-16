using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class WordLadder
	{
		public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
		{
			Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
			Dictionary<string, List<string>> mirror = new Dictionary<string, List<string>>();
			foreach (string word in wordList)
			{
				for (int i = 0; i < word.Length; i++)
				{
					string aux = string.Concat(word.Substring(0, i),"*",word.Substring(i + 1));
					if (dic.ContainsKey(aux))
						dic[aux].Add(word);
					else
						dic[aux] = new List<string> { word };

					if (mirror.ContainsKey(word))
						mirror[word].Add(aux);
					else
						mirror[word] = new List<string> { aux };
				}
			}

			for (int i = 0; i < beginWord.Length; i++)
			{
				string aux = string.Concat(beginWord.Substring(0, i),"*",beginWord.Substring(i + 1));
				if (mirror.ContainsKey(beginWord))
					mirror[beginWord].Add(aux);
				else
					mirror[beginWord] = new List<string> { aux };
			}

			string start = beginWord;
			Queue<string> queue = new Queue<string>();
			queue.Enqueue(start);
			Dictionary<string, bool> visited = new Dictionary<string, bool>();
			Dictionary<string, int> levels = new Dictionary<string, int>
			{
				[start] = 1
			};

			while (queue.Count > 0)
			{
				string word = queue.Dequeue();
				
				if (word == endWord)
					return levels[word];
				
				visited[word] = true;
				foreach (string aux in mirror[word])
				{
					if (dic.ContainsKey(aux))
					{
						dic[aux].ForEach(s => 
						{
							if (!visited.ContainsKey(s))
							{
								if (!levels.ContainsKey(s))
									levels[s] = levels[word] + 1;
								queue.Enqueue(s);
							}
						});
					}
				}
			}

			return 0;
		}
	}
}
