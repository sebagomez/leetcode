using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class ReverseIntegerTests
	{
		[TestMethod]
		public void TestCase1()
		{
			InternalTest(123, 321);
		}

		[TestMethod]
		public void TestCase2()
		{
			InternalTest(-123, -321);
		}

		[TestMethod]
		public void TestCase3()
		{
			InternalTest(120, 21);
		}

		[TestMethod]
		public void TestCase4()
		{
			InternalTest(1534236469, 0);
		}

		[TestMethod]
		public void TestCase5()
		{
			InternalTest(-2147483648, 0);
		}

		void InternalTest(int x, int expected)
		{
			int result = ReverseInteger.Reverse(x);
			Assert.AreEqual(expected, result);
		}
	}
}
