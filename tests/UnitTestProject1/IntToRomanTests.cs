using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class IntToRomanTests
	{
		[TestMethod]
		public void TestCase1()
		{
			InternalTest(3, "III");
		}

		[TestMethod]
		public void TestCase2()
		{
			InternalTest(4, "IV");
		}

		[TestMethod]
		public void TestCase3()
		{
			InternalTest(9, "IX");
		}

		[TestMethod]
		public void TestCase4()
		{
			InternalTest(58, "LVIII");
		}

		[TestMethod]
		public void TestCase5()
		{
			InternalTest(1994, "MCMXCIV");
		}

		void InternalTest(int num, string expected)
		{
			string result = IntToRoman.Solve(num);
			Assert.AreEqual(expected, result);
		}
	}
}
