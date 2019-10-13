using LeetCode;
using LeetCode.Helpers;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeTests.Helpers;

namespace LeetcodeTests
{
	
	public class RemoveNthNodeTests
	{
		[Fact]
		public void RemoveNthNodeTests1()
		{
			ListNode head = ListNode.FromArray(new int[] { 1, 2, 3, 4, 5 });
			ListNode expected = ListNode.FromArray(new int[] { 1, 2, 3, 5 });
			InternalTest(head, 2, expected);
		}

		[Fact]
		public void RemoveNthNodeTests2()
		{
			ListNode head = ListNode.FromArray(new int[] { 1 });
			ListNode expected = ListNode.FromArray(new int[] { });
			InternalTest(head, 1, expected);
		}

		[Fact]
		public void RemoveNthNodeTests3()
		{
			ListNode head = ListNode.FromArray(new int[] { 1, 2 });
			ListNode expected = ListNode.FromArray(new int[] { 1 });
			InternalTest(head, 1, expected);
		}

		void InternalTest(ListNode head, int n, ListNode expected)
		{
			ListNode actual = RemoveNthNode.RemoveNthFromEnd(head, n);
			AssertHelper.AssertListNode(expected, actual);
		}
	}
}
