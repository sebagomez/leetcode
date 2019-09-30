using System.Collections.Generic;
using LeetCode;
using LeetCode.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class MergeKSortedListTests
	{
		[TestMethod]
		public void MergeKSortedListTests1()
		{
			List<ListNode> lists = new List<ListNode>
			{
				ListNode.FromArray(new int[] {1,4,5 }),
				ListNode.FromArray(new int[] {1,3,4 }),
				ListNode.FromArray(new int[] {2,6 })
			};

			InternalTest(lists.ToArray(), "1->1->2->3->4->4->5->6");

		}

		void InternalTest(ListNode[] lists, string expected)
		{
			ListNode result = MergeKSortedList.MergeKLists(lists);
			Assert.AreEqual(expected, result.ToString());
		}
	}
}
