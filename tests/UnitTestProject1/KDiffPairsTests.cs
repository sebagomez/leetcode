using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class KDiffPairsTests
	{
		[TestMethod]
		public void KDiffPairsTest1()
		{
			InternalTest(new int[] { 3, 1, 4, 1, 5 }, 2, 2);
		}

		[TestMethod]
		public void KDiffPairsTest2()
		{
			InternalTest(new int[] { 1, 2, 3, 4, 5 }, 1, 4);
		}

		[TestMethod]
		public void KDiffPairsTest3()
		{
			InternalTest(new int[] { 1, 3, 1, 5, 4 }, 0, 1);
		}

		[TestMethod]
		public void KDiffPairsTest4()
		{
			InternalTest(new int[] { -1, 1 }, 2, 1);
		}

		[TestMethod]
		public void KDiffPairsTest5()
		{
			InternalTest(new int[] { 1, 2, 3, 4, 5 }, -1, 0);
		}

		void InternalTest(int[] array, int k, int expected)
		{
			int value = KDiffPairs.FindPairs(array, k);
			Assert.AreEqual<int>(value, expected, $"For {array} {expected} were expected and returned {value}");
		}
	}
}
