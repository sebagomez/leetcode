using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class ImplementTrie
	{
		public ImplementTrieNode Root { get; set; }

		public ImplementTrie()
		{
			Root = new ImplementTrieNode();
		}

		/** Inserts a word into the trie. */
		public void Insert(string word)
		{
			ImplementTrieNode current = Root;
			for (int i = 0; i < word.Length; i++)
			{
				char c = word[i];
				if (!current.Next.ContainsKey(c))
					current.Next[c] = new ImplementTrieNode();
				
				current = current.Next[c];
			}

			current.Final = true;
		}

		/** Returns if the word is in the trie. */
		public bool Search(string word)
		{
			ImplementTrieNode current = Root;
			for (int i = 0; i < word.Length; i++)
			{
				char c = word[i];
				if (!current.Next.ContainsKey(c))
					return false;

				current = current.Next[c];
			}

			return current.Final;
		}

		/** Returns if there is any word in the trie that starts with the given prefix. */
		public bool StartsWith(string prefix)
		{
			ImplementTrieNode current = Root;
			for (int i = 0; i < prefix.Length; i++)
			{
				char c = prefix[i];
				if (!current.Next.ContainsKey(c))
					return false;

				current = current.Next[c];
			}

			return true;
		}


	}

	public class ImplementTrieNode
	{
		public Dictionary<char,ImplementTrieNode> Next { get; set; }
		public bool Final { get; set; }

		public ImplementTrieNode()
		{
			Next = new Dictionary<char, ImplementTrieNode>();
		}
	}
}
