using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/vowel-spellchecker/
	/// </summary>
	public class VowelSpellchecker
	{
		public static string[] Spellchecker(string[] wordlist, string[] queries)
		{
			HashSet<string> original = new HashSet<string>(wordlist);
			Dictionary<string, string> noCapsDic = new Dictionary<string, string>();
			Dictionary<string, string> noVowelsDic = new Dictionary<string, string>();

			foreach (string word in original)
			{
				string lower = word.ToLower();
				if (!noCapsDic.ContainsKey(lower))
					noCapsDic[lower] = word;
				string noVowel = RemoveVowels(lower);
				if (!noVowelsDic.ContainsKey(noVowel))
					noVowelsDic[noVowel] = word;
			}

			for (int i = 0; i < queries.Length; i++)
			{
				string query = queries[i];
				if (original.Contains(query))
					continue;
				string lower = query.ToLower();

				string result = "";
				if (noCapsDic.ContainsKey(lower))
					result = noCapsDic[lower];
				else
				{
					string noVowel = RemoveVowels(lower);
					if (noVowelsDic.ContainsKey(noVowel))
						result = noVowelsDic[noVowel];
				}
				queries[i] = result;
			}

			return queries;
		}

		static string RemoveVowels(string word)
		{
			return System.Text.RegularExpressions.Regex.Replace(word, "[aeiou]", "?");
		}
	}
}
