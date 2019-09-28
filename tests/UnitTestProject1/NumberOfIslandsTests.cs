using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	[TestClass]
	public class NumberOfIslandsTests
	{
		[TestMethod]
		public void NumberOfIslandsTests1()
		{
			char[][] grid = new char[][] { new[] { '1','1','1','1','0' },
										   new[] { '1','1','0','1','0' },
										   new[] { '1','1','0','0','0' },
										   new[] { '0','0','0','0','0' }};
			InternalTest(grid, 1);
		}

		[TestMethod]
		public void NumberOfIslandsTests2()
		{
			char[][] grid = new char[][] { new[] { '1','1','0','0','0' },
										   new[] { '1','1','0','0','0' },
										   new[] { '0','0','1','0','0' },
										   new[] { '0','0','0','1','1' }};
			InternalTest(grid, 3);
		}

		[TestMethod]
		public void NumberOfIslandsTests3()
		{
			char[][] grid = new char[][] {  };
			InternalTest(grid, 0);
		}

		[TestMethod]
		public void NumberOfIslandsTests4()
		{
			char[][] grid = new char[][] { new[] { '1','0','1','1','1' },
										   new[] { '1','0','1','0','1' },
										   new[] { '1','1','1','0','1' }};
			InternalTest(grid, 1);
		}

		[TestMethod]
		public void NumberOfIslandsTests5()
		{
			char[][] grid = new char[][] { new[] { '1','1','1' },
										   new[] { '0','1','0' },
										   new[] { '1','1','1'}};
			InternalTest(grid, 1);
		}

		void InternalTest(char[][] grid, int expected)
		{
			int actual = NumberOfIslands.BFSNumIslands(grid);
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
