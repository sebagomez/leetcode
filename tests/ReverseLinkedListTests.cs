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
	
	public class ReverseLinkedListTests
	{
		[Fact]
		public void ReverseLinkedListTests1()
		{
			int[] head = new int[] { 1, 2, 3, 4, 5 };
			int[] tail = new int[] { 5, 4, 3, 2, 1 };

			InternalTest(ListNode.FromArray(head), ListNode.FromArray(tail));
		}

		[Fact]
		public void ReverseLinkedListTests2()
		{
			int[] head = new int[] { };
			int[] tail = new int[] { };

			InternalTest(ListNode.FromArray(head), ListNode.FromArray(tail));
		}

		void InternalTest(ListNode head, ListNode expected)
		{
			ListNode actual = ReverseLinkedList.ReverseList(head);
			AssertHelper.AssertListNode(expected, actual);
		}
	}
}
