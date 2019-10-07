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
	public class ShuffleAnArrayTests
	{
		[TestMethod]
		public void ShuffleAnArrayTests1()
		{
			int[] original = new int[] { 1, 2, 3 };
			InternalTest(original);
		}

		[TestMethod]
		public void ShuffleAnArrayTests2()
		{
			int[] original = new int[] { };
			InternalTest(original);
		}

		[TestMethod]
		public void ShuffleAnArrayTests3()
		{
			int[] original = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
			InternalTest(original);
		}

		void InternalTest(int[] original)
		{
			ShuffleAnArray solution = new ShuffleAnArray(original);
			int[] shuffle = solution.Shuffle();
			Assert.AreEqual<int>(original.Length, shuffle.Length);
			int[] reset = solution.Reset();
			Assert.AreEqual<int>(original.Length, reset.Length);
			int[] shuffle2 = solution.Shuffle();
			Assert.AreEqual<int>(original.Length, shuffle2.Length);
		}
	}
}
