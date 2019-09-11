using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/word-search/
	/// </summary>
	public class WordSearch
	{

		public static bool Exist(char[][] board, string word)
		{
			int index = 0;
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board[i].GetLength(0); j++)
				{
					if(FindWord(board, i, j, word, index))
						return true;
				}
			}

			return false;
		}

		private static bool FindWord(char[][] board, int i, int j, string word, int index)
		{
			char c = board[i][j];

			if (word[index] != c)
				return false;

			string key = $"{i}{j}";

			board[i][j] = (char)(board[i][j] ^ 32);

			if (index == word.Length - 1)
				return true;

			bool found = false;
			if (i > 0)
				found = FindWord(board, i - 1, j, word, index + 1);

			if (i + 1 < board.GetLength(0) && !found)
				found |= FindWord(board, i + 1, j, word, index + 1);

			if (j > 0 && !found)
				found |= FindWord(board, i, j - 1, word, index + 1);

			if (j + 1 < board[i].GetLength(0) && !found)
				found |= FindWord(board, i, j + 1, word, index + 1);

			board[i][j] = (char)(board[i][j] ^ 32);

			return found;
		}

		//public static bool Exist(char[][] board, string word)
		//{
		//	WSTrie trie = new WSTrie(word);

		//	Dictionary<string, bool> visited = new Dictionary<string, bool>();

		//	bool found = false;
		//	for (int i = 0; i < board.GetLength(0); i++)
		//	{
		//		for (int j = 0; j < board[i].GetLength(0); j++)
		//		{
		//			found |= FindWord(board, i, j, trie.Root, visited);
		//			if (found)
		//				return found;
		//		}
		//	}

		//	return found;
		//}

		//private static bool FindWord(char[][] board, int i, int j, WSTrieNode root, Dictionary<string, bool> visited)
		//{
		//	char c = board[i][j];

		//	if (!root.Neibourghs.ContainsKey(c))
		//		return false;

		//	string key = $"{i}{j}";
		//	if (visited.ContainsKey(key) && visited[key])
		//		return false;

		//	visited[key] = true;

		//	WSTrieNode neibourgh = root.Neibourghs[c];

		//	if (neibourgh.IsEnd)
		//		return true;

		//	bool found = false;
		//	if (i > 0)
		//		found = FindWord(board, i - 1, j, neibourgh, visited);

		//	if (i + 1 < board.GetLength(0) && !found)
		//		found |= FindWord(board, i + 1, j, neibourgh, visited);

		//	if (j > 0 && !found)
		//		found |= FindWord(board, i , j - 1, neibourgh, visited);

		//	if (j + 1 < board[i].GetLength(0) && !found)
		//		found |= FindWord(board, i , j + 1, neibourgh, visited);

		//	visited[key] = false;

		//	return found;
		//}
	}

	public class WSTrieNode
	{
		public Dictionary<char, WSTrieNode> Neibourghs = new Dictionary<char, WSTrieNode>();
		public bool IsEnd { get; set; }
	}

	public class WSTrie
	{
		public WSTrieNode Root { get; }
		public WSTrie(string word)
		{
			Root = new WSTrieNode();
			WSTrieNode current = Root;
			foreach (char c in word)
			{
				if (!current.Neibourghs.ContainsKey(c))
				{
					WSTrieNode node = new WSTrieNode();
					current.Neibourghs[c] = node;
				}

				current = current.Neibourghs[c];
			}
			current.IsEnd = true;
		}

	}
}
