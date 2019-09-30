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
	public class ReverseLinkedListTests
	{
		[TestMethod]
		public void ReverseLinkedListTests1()
		{
			int[] head = new int[] { 1, 2, 3, 4, 5 };
			int[] tail = new int[] { 5, 4, 3, 2, 1 };

			InternalTest(ListNode.FromArray(head), ListNode.FromArray(tail));
		}

		[TestMethod]
		public void ReverseLinkedListTests2()
		{
			int[] head = new int[] { };
			int[] tail = new int[] { };

			InternalTest(ListNode.FromArray(head), ListNode.FromArray(tail));
		}

		void InternalTest(ListNode head, ListNode expected)
		{
			ListNode actual = ReverseLinkedList.ReverseList(head);
			while (actual != null || expected != null)
			{
				Assert.AreEqual<int>(expected.val, actual.val);
				expected = expected.next;
				actual = actual.next;
			}

			Assert.IsNull(actual, "There are more nodes in actual");
			Assert.IsNull(expected, "There are more nodes in expected");
		}
	}
}
