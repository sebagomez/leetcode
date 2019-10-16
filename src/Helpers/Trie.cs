using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helpers
{
	public class Trie
	{
		public readonly TrieNode root;

		public Trie()
		{
			root = new TrieNode();
		}

		public void Insert(String word, int i)
		{
			var start = root;
			foreach (var ch in word)
			{
				if (!start.Neighbors.ContainsKey(ch))
				{
					var newnode = new TrieNode();
					start.Neighbors.Add(ch, newnode);
				}

				start = start.Neighbors[ch];
			}

			start.IsEnd = true;
			start.index = i;
		}

		public bool ContainsWord(string word)
		{
			TrieNode current = root;
			for (int i = 0; i < word.Length; i++)
			{
				char c = word[i];
				if (!current.Neighbors.ContainsKey(c))
					return false;

				current = current.Neighbors[c];
			}

			return true;
		}
	}
}
