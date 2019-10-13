using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class ReverseIntegerTests
	{
		[Fact]
		public void TestCase1()
		{
			InternalTest(123, 321);
		}

		[Fact]
		public void TestCase2()
		{
			InternalTest(-123, -321);
		}

		[Fact]
		public void TestCase3()
		{
			InternalTest(120, 21);
		}

		[Fact]
		public void TestCase4()
		{
			InternalTest(1534236469, 0);
		}

		[Fact]
		public void TestCase5()
		{
			InternalTest(-2147483648, 0);
		}

		void InternalTest(int x, int expected)
		{
			int result = ReverseInteger.Reverse(x);
			Assert.Equal(expected, result);
		}
	}
}
