using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class ShuffleAnArrayTests
	{
		[Fact]
		public void ShuffleAnArrayTests1()
		{
			int[] original = new int[] { 1, 2, 3 };
			InternalTest(original);
		}

		[Fact]
		public void ShuffleAnArrayTests2()
		{
			int[] original = new int[] { };
			InternalTest(original);
		}

		[Fact]
		public void ShuffleAnArrayTests3()
		{
			int[] original = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
			InternalTest(original);
		}

		void InternalTest(int[] original)
		{
			ShuffleAnArray solution = new ShuffleAnArray(original);
			int[] shuffle = solution.Shuffle();
			Assert.Equal<int>(original.Length, shuffle.Length);
			int[] reset = solution.Reset();
			Assert.Equal<int>(original.Length, reset.Length);
			int[] shuffle2 = solution.Shuffle();
			Assert.Equal<int>(original.Length, shuffle2.Length);
		}
	}
}
