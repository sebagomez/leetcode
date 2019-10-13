using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class RomanToIntTests
	{
		[Fact]
		public void TestCase1()
		{
			InternalTest("III", 3);
		}

		[Fact]
		public void TestCase2()
		{
			InternalTest("IV", 4);
		}

		[Fact]
		public void TestCase3()
		{
			InternalTest("IX", 9);
		}

		[Fact]
		public void TestCase4()
		{
			InternalTest("LVIII", 58);
		}

		[Fact]
		public void TestCase5()
		{
			InternalTest("MCMXCIV", 1994);
		}

		void InternalTest(string roman, int expected)
		{
			int result = RomanToInt.Solve(roman);
			Assert.Equal(expected, result);
		}
	}
}
