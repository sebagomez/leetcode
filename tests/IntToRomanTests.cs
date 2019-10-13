using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class IntToRomanTests
	{
		[Fact]
		public void TestCase1()
		{
			InternalTest(3, "III");
		}

		[Fact]
		public void TestCase2()
		{
			InternalTest(4, "IV");
		}

		[Fact]
		public void TestCase3()
		{
			InternalTest(9, "IX");
		}

		[Fact]
		public void TestCase4()
		{
			InternalTest(58, "LVIII");
		}

		[Fact]
		public void TestCase5()
		{
			InternalTest(1994, "MCMXCIV");
		}

		void InternalTest(int num, string expected)
		{
			string result = IntToRoman.Solve(num);
			Assert.Equal(expected, result);
		}
	}
}
