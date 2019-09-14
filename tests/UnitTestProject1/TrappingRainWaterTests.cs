﻿using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	[TestClass]
	public class TrappingRainWaterTests
	{
		[TestMethod]
		public void TrappingRainWaterTests1()
		{
			int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
			InternalTest(height, 6);
		}

		[TestMethod]
		public void TrappingRainWaterTests2()
		{
			int[] height = new int[] {  };
			InternalTest(height, 0);
		}

		void InternalTest(int[] height, int expected)
		{
			int actual = TrappingRainWater.Trap(height);
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
