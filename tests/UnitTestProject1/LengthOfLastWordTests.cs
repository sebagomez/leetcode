using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class LengthOfLastWordTests
	{
		[TestMethod]
		public void Test1()
		{
			InternalTest("Hello World", 5);
		}

		void InternalTest(string line, int expected)
		{
			int value = LengthOfLastWord.FindLengthOfLastWord(line);
			Assert.AreEqual<int>(value, expected, $"The last word of {line} returned {value}, and {expected} was expected");
		}
	}
}
