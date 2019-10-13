using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class FloodFillTests
	{
		[Fact]
		public void FloodFillTests1()
		{

			int[][] image = new int[][] { new[] { 1,1,1 },
										  new[] { 1,1,0 },
										  new[] { 1,0,1 }};

			int[][] expected = new int[][] { new[] { 2,2,2 },
											 new[] { 2,2,0 },
											 new[] { 2,0,1 }};
			InternalTest(image, 1, 1, 2, expected);
		}

		void InternalTest(int[][] image, int sr, int sc, int newColor, int[][] expected)
		{
			int[][] actual = FloodFill.Solve(image, sr, sc, newColor);
			Assert.Equal<int>(expected.GetLength(0), actual.GetLength(0));
			for (int i = 0; i < image.GetLength(0); i++)
			{
				for (int j = 0; j < image[i].GetLength(0); j++)
				{
					Assert.Equal<int>(expected[i][j], actual[i][j]);
				}
			}
		}
	}
}
