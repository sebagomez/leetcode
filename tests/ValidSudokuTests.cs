﻿using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class ValidSudokuTests
	{

		[Fact]
		public void ValidSudokuTests1()
		{
			char[][] board = new char[][] { new char[]{'5', '3', '.', '.', '7', '.', '.', '.', '.'},
											new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
											new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
											new char[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
											new char[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
											new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
											new char[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
											new char[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
											new char[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
			InternalTest(board, true);
		}

		[Fact]
		public void ValidSudokuTests2()
		{
			char[][] board = new char[][] { new char[]{'8', '3', '.', '.', '7', '.', '.', '.', '.'},
											new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
											new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
											new char[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
											new char[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
											new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
											new char[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
											new char[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
											new char[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
			InternalTest(board, false);
		}

		void InternalTest(char[][] board, bool expected)
		{
			bool actual = ValidSudoku.IsValidSudoku(board);
			Assert.Equal<bool>(expected, actual);
		}
	}
}
