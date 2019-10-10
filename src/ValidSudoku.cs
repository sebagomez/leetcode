using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ValidSudoku
	{
		public static bool IsValidSudoku(char[][] board)
		{
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board[i].GetLength(0); j++)
				{
					if (board[i][j] == '.')
						continue;

					if(!ValidRow(board, i, j))
						return false;
					if(!ValidColumn(board, i, j))
						return false; 
					if(!ValidThreeByThree(board, i, j))
						return false;
				}
			}

			return true;
		}

		private static bool ValidThreeByThree(char[][] board, int i, int j)
		{
			char current = board[i][j];
			//[0,1,2][3,4,5][6,7,8]
			int x = i >= 6 ? 6 : i >= 3 ? 3 : 0;
			int y = j >= 6 ? 6 : j >= 3 ? 3 : 0;

			for (int m = x; m < (x + 3); m++)
			{
				for (int n = y; n < (y + 3); n++)
				{
					if ((m == i && n == j) || board[m][n] == '.')
						continue;

					if (board[m][n] == current)
						return false;
				}
			}

			return true;
		}

		private static bool ValidColumn(char[][] board, int i, int j)
		{
			char current = board[i][j];
			for (int y = 0; y < board.GetLength(0); y++)
			{
				if (board[y][j] == '.' || i == y)
					continue;
				if (board[y][j] == current)
					return false;
			}

			return true;
		}

		private static bool ValidRow(char[][] board, int i, int j)
		{
			char current = board[i][j];
			for (int x = 0; x < board[i].GetLength(0); x++)
			{
				if (board[i][x] == '.' || x == j)
					continue;
				if (board[i][x] == current)
					return false;
			}

			return true;
		}
	}
}
