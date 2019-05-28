using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class RomanToIntTests
	{
		[TestMethod]
		public void TestCase1()
		{
			InternalTest("III", 3);
		}

		[TestMethod]
		public void TestCase2()
		{
			InternalTest("IV", 4);
		}

		[TestMethod]
		public void TestCase3()
		{
			InternalTest("IX", 9);
		}

		[TestMethod]
		public void TestCase4()
		{
			InternalTest("LVIII", 58);
		}

		[TestMethod]
		public void TestCase5()
		{
			InternalTest("MCMXCIV", 1994);
		}

		void InternalTest(string roman, int expected)
		{
			int result = RomanToInt.Solve(roman);
			Assert.AreEqual(expected, result);
		}
	}
}
