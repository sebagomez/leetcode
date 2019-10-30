using Leetcode;
using LeetCode.Helpers;
using LeetcodeTests.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class SortListTests
	{
		[Fact]
		public void SortListTests1()
		{
			ListNode head = ListNode.FromArray(new int[] { 4, 2, 1, 3 });
			ListNode expected = ListNode.FromArray(new int[] { 1, 2, 3, 4 });
			InternalTest(head, expected);
		}

		[Fact]
		public void SortListTests2()
		{
			ListNode head = ListNode.FromArray(new int[] { -1, 5, 3, 4, 0 });
			ListNode expected = ListNode.FromArray(new int[] { -1, 0, 3, 4, 5 });
			InternalTest(head, expected);
		}

		void InternalTest(ListNode head, ListNode expected)
		{
			ListNode actual = SortList.Solve(head);
			AssertHelper.AssertListNode(expected, actual);
		}
	}
}
