using LeetCode;
using LeetCode.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	[TestClass]
	public class PalindromeLinkedListTests
	{
		[TestMethod]
		public void PalindromeLinkedListTests1()
		{
			int[] array = new int[] { 1, 2 };
			InternalTest(array, false);
		}

		[TestMethod]
		public void PalindromeLinkedListTests2()
		{
			int[] array = new int[] { 1, 2, 2, 1 };
			InternalTest(array, true);
		}

		[TestMethod]
		public void PalindromeLinkedListTests3()
		{
			int[] array = new int[] { 1, 0, 1 };
			InternalTest(array, true);
		}

		void InternalTest(int[] array, bool expected)
		{
			bool actual = PalindromeLinkedList.IsPalindrome(ListNode.FromArray(array));
			Assert.AreEqual<bool>(expected, actual);
		}
	}
}
