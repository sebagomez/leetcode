using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Helpers
{
	public class AssertHelper
	{
		public static void AssertArrays(int[] expected, int[] actual)
		{
			Assert.AreEqual<int>(expected.Length, actual.Length);
			for (int i = 0; i < actual.Length; i++)
			{
				Assert.AreEqual<int>(expected[i], actual[i]);
			}
		}
	}
}
