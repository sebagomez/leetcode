using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class SudokuSolver
	{
		const char EMPTY = '.';

		public static void SolveSudoku(char[][] board)
		{
			SolveCell(board, 0, 0);
		}

		private static bool SolveCell(char[][] board, int row, int col)
		{
			if (col == board[row].Length)
			{
				col = 0;
				row++;

				if (row == board.Length)
					return true;
			}

			if (board[row][col] != EMPTY)
				return SolveCell(board, row, col + 1);

			for (int i = 1; i <= 9; i++)
			{
				char c = (char)(i + '0');
				if (IsValidCell(board, row, col, c))
				{
					board[row][col] = c;
					if (SolveCell(board, row, col + 1))
						return true;
					else
						board[row][col] = EMPTY;
				}
			}

			return false;
		}

		private static bool IsValidCell(char[][] board, int row, int col, char c)
		{
			// check for the row
			for (int i = 0; i < board.GetLength(0); i++)
			{
				if (board[row][i] == c)
					return false;
			}

			//check for the column
			for (int i = 0; i < board[row].GetLength(0); i++)
			{
				if (board[i][col] == c)
					return false;
			}

			// check for the 3x3 subgrid
			int firstRow = row < 3 ? 0 : row < 6 ? 3 : 6;
			int firstCol = col < 3 ? 0 : col < 6 ? 3 : 6;

			for (int i = firstRow; i < (firstRow + 3); i++)
			{
				for (int j = firstCol; j < (firstCol + 3); j++)
				{
					if (board[i][j] == c)
						return false;
				}
			}

			return true;
		}
	}
}
