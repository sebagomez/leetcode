using System.Collections.Generic;

namespace LeetCode
{
	public class RepeatedCharWords
	{
		public static List<string> SmartSolution(string word, int length)
		{
			List<string> list = new List<string>();
			if (word.Length < length)
				return list;

			string currentWord = "";
			Dictionary<char, int> map = new Dictionary<char, int>();
			for (int i = 0; i < word.Length; i++)
			{
				if (currentWord.Length == length)
				{
					if (map.Count < length && !list.Contains(currentWord))
						list.Add(currentWord);

					if (map[currentWord[0]] == 1)
						map.Remove(currentWord[0]);
					else
						map[currentWord[0]]--;
					currentWord = currentWord.Substring(1);
				}

				if (map.ContainsKey(word[i]))
					map[word[i]]++;
				else
					map[word[i]] = 1;

				currentWord += word[i].ToString();
			}

			if (map.Count < length && currentWord.Length == length && !list.Contains(currentWord))
				list.Add(currentWord);

			return list;
		}

		public static List<string> BruteSolution(string word, int length)
		{
			List<string> list = new List<string>();
			if (word.Length < length)
				return list;

			for (int i = length - 1; i < word.Length; i++)
			{
				List<char> w = new List<char>();
				for (int j = i; j >= (i - (length - 1)); j--)
				{
					if (w.Contains(word[j]))
					{
						string part = word.Substring(i - (length - 1), length);
						if (!list.Contains(part))
							list.Add(part);
						break;
					}
					else
						w.Add(word[j]);
				}
			}

			return list;
		}
	}
}
