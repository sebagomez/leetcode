using Leetcode;
using LeetcodeTests.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class MinesweeperTests
	{
		[Fact]
		public void MinesweeperTests1()
		{
			char[][] board = new char[][] { new char[] { 'E', 'E', 'E', 'E', 'E' },
											new char[] { 'E', 'E', 'M', 'E', 'E' },
											new char[] { 'E', 'E', 'E', 'E', 'E' },
											new char[] { 'E', 'E', 'E', 'E', 'E' }};

			char[][] expected = new char[][] { new char[] { 'B', '1', 'E', '1', 'B' },
											   new char[] { 'B', '1', 'M', '1', 'B' },
											   new char[] { 'B', '1', '1', '1', 'B' },
											   new char[] { 'B', 'B', 'B', 'B', 'B' }};

			int[] click = new int[] { 3, 0 };

			InternalTest(board, click, expected);
		}

		[Fact]
		public void MinesweeperTests2()
		{
			char[][] board = new char[][] { new char[] { 'B', '1', 'E', '1', 'B' },
							 			    new char[] { 'B', '1', 'M', '1', 'B' },
											new char[] { 'B', '1', '1', '1', 'B' },
											new char[] { 'B', 'B', 'B', 'B', 'B' }};

			char[][] expected = new char[][] { new char[] { 'B', '1', 'E', '1', 'B' },
											   new char[] { 'B', '1', 'X', '1', 'B' },
											   new char[] { 'B', '1', '1', '1', 'B' },
											   new char[] { 'B', 'B', 'B', 'B', 'B' }};

			int[] click = new int[] { 1, 2 };

			InternalTest(board, click, expected);
		}

		[Fact]
		public void MinesweeperTests3()
		{
			char[][] board = new char[][] { new char[] { 'E','E','E','E','E','E','E','E' },
											new char[] { 'E','E','E','E','E','E','E','M' },
											new char[] { 'E','E','M','E','E','E','E','E' },
											new char[] { 'M','E','E','E','E','E','E','E' },
											new char[] { 'E','E','E','E','E','E','E','E' },
											new char[] { 'E','E','E','E','E','E','E','E' },
											new char[] { 'E','E','E','E','E','E','E','E' },
											new char[] { 'E','E','M','M','E','E','E','E'}};

			char[][] expected = new char[][] { new char[] { 'B','B','B','B','B','B','1','E' },
											   new char[] { 'B','1','1','1','B','B','1','M' },
											   new char[] { '1','2','M','1','B','B','1','1' },
											   new char[] { 'M','2','1','1','B','B','B','B' },
											   new char[] { '1','1','B','B','B','B','B','B' },
											   new char[] { 'B','B','B','B','B','B','B','B' },
											   new char[] { 'B','1','2','2','1','B','B','B' },
											   new char[] { 'B','1','M','M','1','B','B','B' }};

			int[] click = new int[] { 0, 0 };

			InternalTest(board, click, expected);
		}

		void InternalTest(char[][] board, int[] click, char[][] expected)
		{
			char[][] actual = Minesweeper.UpdateBoard(board, click);
			AssertHelper.AssertMatrixes(expected, actual);
		}
	}
}
