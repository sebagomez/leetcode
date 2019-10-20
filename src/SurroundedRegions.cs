using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class SurroundedRegions
	{
		const char X = 'X';
		const char O = 'O';

		public static void Solve(char[][] board)
		{
			HashSet<string> visitied = new HashSet<string>();

			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board[i].GetLength(0); j++)
				{
					if (board[i][j] == X)
						continue;

					HashSet<string> currentRegion = new HashSet<string>();
					if (!CaptureRegion(board, i, j, visitied, currentRegion))
					{
						foreach (string key in currentRegion)
						{
							string[] s = key.Split(new char[] { ':' });
							int x = int.Parse(s[0]);
							int y = int.Parse(s[1]);
							board[x][y] = O;
						}
					}
				}
			}
		}

		private static bool CaptureRegion(char[][] board, int i, int j, HashSet<string> visitied, HashSet<string> currentRegion)
		{
			string key = $"{i}:{j}";
			if (visitied.Contains(key) || board[i][j] == X)
				return true;

			bool retVal = true;
			visitied.Add(key);
			currentRegion.Add(key);

			board[i][j] = X;

			if (i < board.GetLength(0) - 1)
				retVal &= CaptureRegion(board, i + 1, j, visitied, currentRegion);
			else
				retVal = false;

			if (i > 0)
				retVal &= CaptureRegion(board, i - 1, j, visitied, currentRegion);
			else
				retVal = false;

			if (j < board[i].GetLength(0) - 1)
				retVal &= CaptureRegion(board, i, j + 1, visitied, currentRegion);
			else
				retVal = false;

			if (j > 0)
				retVal &= CaptureRegion(board, i, j - 1, visitied, currentRegion);
			else
				retVal = false;

			return retVal;
		}
	}
}
