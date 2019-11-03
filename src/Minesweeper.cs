using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class Minesweeper
	{
		const char MINE = 'M';
		const char EMPTY = 'E';
		const char GAME_OVER = 'X';
		const char BLANK = 'B';

		static HashSet<string> s_visited;

		public static char[][] UpdateBoard(char[][] board, int[] click)
		{
			if (!IsValidSquare(board, click))
				return board;

			if (board[click[0]][click[1]] == MINE)
			{
				board[click[0]][click[1]] = GAME_OVER;
				return board;
			}

			s_visited = new HashSet<string>();
			if (board[click[0]][click[1]] == EMPTY)
				board = RevealEmpty(board, click);

			return board;
		}

		private static bool IsValidSquare(char[][] board, int[] click)
		{
			if (click[0] < 0 || click[0] >= board.GetLength(0))
				return false ;

			if (click[1] < 0 || click[1] >= board[click[0]].GetLength(0))
				return false;

			return true;
		}

		static int[][] s_directions = new int[][] { new int[] {  0, -1 },  // <-
											   new int[] { -1, -1 },  // <\
											   new int[] { -1,  0 },  //  |^
											   new int[] { -1,  1 },  // /^
											   new int[] {  0,  1 },  // ->
											   new int[] {  1,  1 },  // \>
											   new int[] {  1,  0 },  // |
											   new int[] {  1, -1 }}; // </

		private static char[][] RevealEmpty(char[][] board, int[] square)
		{
			if (!IsValidSquare(board, square))
				return board;

			if (board[square[0]][square[1]] == BLANK)
				return board;

			string key = $"{square[0]}:{square[1]}";
			if (s_visited.Contains(key))
				return board;

			s_visited.Add(key);

			int mines = GetCountMines(board, square);
			if (mines > 0)
			{
				board[square[0]][square[1]] = char.Parse(mines.ToString());
				return board;
			}

			board[square[0]][square[1]] = BLANK;

			

			for (int i = 0; i < s_directions.Length; i++)
			{
				int[] neighbour = new int[] { square[0] + s_directions[i][0], square[1] + s_directions[i][1] };
				board = RevealEmpty(board, neighbour);
			}

			return board;
		}

		private static int GetCountMines(char[][] board, int[] click)
		{
			int count = 0;
			for (int i = 0; i < s_directions.Length; i++)
			{
				int[] neighbour = new int[] { click[0] + s_directions[i][0], click[1] + s_directions[i][1] };
				if (IsValidSquare(board, neighbour) && board[neighbour[0]][neighbour[1]] == MINE)
					count++;
			}

			return count;
		}
	}
}
