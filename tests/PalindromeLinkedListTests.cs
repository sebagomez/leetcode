using LeetCode;
using LeetCode.Helpers;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class PalindromeLinkedListTests
	{
		[Fact]
		public void PalindromeLinkedListTests1()
		{
			int[] array = new int[] { 1, 2 };
			InternalTest(array, false);
		}

		[Fact]
		public void PalindromeLinkedListTests2()
		{
			int[] array = new int[] { 1, 2, 2, 1 };
			InternalTest(array, true);
		}

		[Fact]
		public void PalindromeLinkedListTests3()
		{
			int[] array = new int[] { 1, 0, 1 };
			InternalTest(array, true);
		}

		void InternalTest(int[] array, bool expected)
		{
			bool actual = PalindromeLinkedList.IsPalindrome(ListNode.FromArray(array));
			Assert.Equal<bool>(expected, actual);
		}
	}
}
