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
	public class FloodFillTests
	{
		[TestMethod]
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
			Assert.AreEqual<int>(expected.GetLength(0), actual.GetLength(0));
			for (int i = 0; i < image.GetLength(0); i++)
			{
				for (int j = 0; j < image[i].GetLength(0); j++)
				{
					Assert.AreEqual<int>(expected[i][j], actual[i][j], $"Wrong color at {i}{j}");
				}
			}
		}
	}
}
