using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class PlusOneTests
	{
		[Fact]
		public void PlusOneTests1()
		{
			int[] num = new int[] { 1, 2, 3 };
			int[] expected = new int[] { 1, 2, 4 };
			InternalTest(num, expected);
		}

		[Fact]
		public void PlusOneTests2()
		{
			int[] num = new int[] { 9 };
			int[] expected = new int[] { 1, 0 };
			InternalTest(num, expected);
		}

		[Fact]
		public void PlusOneTests3()
		{
			int[] num = new int[] { 4, 3, 2, 1 };
			int[] expected = new int[] { 4, 3, 2, 2 };
			InternalTest(num, expected);
		}

		[Fact]
		public void PlusOneTests4()
		{
			int[] num = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			int[] expected = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };
			InternalTest(num, expected);
		}

		[Fact]
		public void PlusOneTests5()
		{
			int[] num = new int[] { 6, 1, 4, 5, 3, 9, 0, 1, 9, 5, 1, 8, 6, 7, 0, 5, 5, 4, 3 };
			int[] expected = new int[] { 6, 1, 4, 5, 3, 9, 0, 1, 9, 5, 1, 8, 6, 7, 0, 5, 5, 4, 4 };
			InternalTest(num, expected);
		}

		[Fact]
		public void PlusOneTests6()
		{
			int[] num = new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
			int[] expected = new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 7 };
			InternalTest(num, expected);
		}

		void InternalTest(int[] num, int[] expected)
		{
			int[] actual = PlusOne.Solve(num);
			Assert.Equal<int>(expected.Length, actual.Length);
			for (int i = 0; i < actual.Length; i++)
			{
				Assert.Equal<int>(expected[i], actual[i]);
			}
		}
	}
}
