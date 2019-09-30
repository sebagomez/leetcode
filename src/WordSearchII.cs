using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/word-search-ii/
	/// </summary>
	public class WordSearchII
	{
		public static List<string> FindWords(char[][] board, string[] words)
		{
			var res = new HashSet<string>();
			var visited = new bool[board.GetLength(0), board[0].GetLength(0)];

			var trie = new Trie();
			for (var i = 0; i < words.Length; i++)
			{
				trie.Insert(words[i], i);
			}

			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board[i].GetLength(0); j++)
				{
					FindWordsHelper(board, i, j, visited, trie.root, res, words);
				}
			}

			return res.ToList();
		}

		private static void FindWordsHelper(char[][] board, int i, int j, bool[,] visited, TrieNode root, HashSet<string> res, string[] words)
		{
			if (visited[i, j])
				return;

			if (!root.Neighbors.ContainsKey(board[i][j]))
				return;

			if (root.Neighbors[board[i][j]].IsEnd)
			{
				res.Add(words[root.Neighbors[board[i][j]].index]);
			}

			visited[i, j] = true;

			if (i > 0)
			{
				FindWordsHelper(board, i - 1, j, visited, root.Neighbors[board[i][j]], res, words);
			}
			if (i + 1 < board.GetLength(0))
			{
				FindWordsHelper(board, i + 1, j, visited, root.Neighbors[board[i][j]], res, words);
			}
			if (j > 0)
			{
				FindWordsHelper(board, i, j - 1, visited, root.Neighbors[board[i][j]], res, words);
			}
			if (j + 1 < board[i].GetLength(0))
			{
				FindWordsHelper(board, i, j + 1, visited, root.Neighbors[board[i][j]], res, words);
			}

			visited[i, j] = false;
		}

	}
}
