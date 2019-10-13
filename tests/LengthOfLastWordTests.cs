using LeetCode;
using Xunit;

namespace LeetcodeTests
{
	
	public class LengthOfLastWordTests
	{
		[Fact]
		public void Test1()
		{
			InternalTest("Hello World", 5);
		}

		void InternalTest(string line, int expected)
		{
			int value = LengthOfLastWord.FindLengthOfLastWord(line);
			Assert.Equal<int>(expected, value);
		}
	}
}
