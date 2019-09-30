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
	}
}
