using Leetcode;
using LeetcodeTests.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class SurroundedRegionsTests
	{
		[Fact]
		public void SurroundedRegionsTests1()
		{
			char[][] board = new char[][] { new char[] { 'X', 'X', 'X', 'X' },
											new char[] { 'X', 'O', 'O', 'X' },
											new char[] { 'X', 'X', 'O', 'X' },
											new char[] { 'X', 'O', 'X', 'X' }};

			char[][] expected = new char[][] { new char[] { 'X', 'X', 'X', 'X' },
											   new char[] { 'X', 'X', 'X', 'X' },
											   new char[] { 'X', 'X', 'X', 'X' },
											   new char[] { 'X', 'O', 'X', 'X' }};

			InternalTest(board, expected);
		}

		[Fact]
		public void SurroundedRegionsTests2()
		{
			char[][] board = new char[][] { new char[] { 'O','X','O','X','O','X','O' },
											new char[] { 'O','X','O','O','X','O','O' },
											new char[] { 'X','O','O','X','X','X','O' },
											new char[] { 'X','X','O','O','O','O','X' },
											new char[] { 'X','X','O','O','O','O','O' },
											new char[] { 'X','O','O','X','X','X','X' },
											new char[] { 'X','X','O','X','O','X','O' }};

			char[][] expected = new char[][] { new char[] { 'O','X','O','X','O','X','O'},
			   								   new char[] { 'O','X','O','O','X','O','O'},
											   new char[] { 'X','O','O','X','X','X','O'},
											   new char[] { 'X','X','O','O','O','O','X'},
											   new char[] { 'X','X','O','O','O','O','O'},
											   new char[] { 'X','O','O','X','X','X','X'},
											   new char[] { 'X','X','O','X','O','X','O'}};
			InternalTest(board, expected);
		}

		//[["O","X","O","X","O","X","O"],["O","X","O","O","X","O","O"],["X","O","O","X","X","X","O"],["X","X","O","O","O","O","X"],["X","X","O","O","O","O","O"],["X","O","O","X","X","X","X"],["X","X","O","X","O","X","O"]]
		//[["O","X","O","X","O","X","O"],["O","X","O","O","X","X","O"],["X","O","O","X","X","X","O"],["X","X","O","O","O","O","X"],["X","X","O","O","O","O","O"],["X","O","O","X","X","X","X"],["X","X","O","X","O","X","O"]]

		void InternalTest(char[][] board, char[][] expected)
		{
			SurroundedRegions.Solve(board);
			AssertHelper.AssertMatrixes(expected, board);
		}
	}
}
