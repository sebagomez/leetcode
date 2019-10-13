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
	
	public class MergeTwoSortedListsTests
	{
		[Fact]
		public void MergeTwoSortedListsTests1()
		{
			ListNode l1 = ListNode.FromArray(new int[] { 1, 2, 4 });
			ListNode l2 = ListNode.FromArray(new int[] { 1, 3, 4 });
			ListNode expected = ListNode.FromArray(new int[] { 1, 1, 2, 3, 4, 4 });
			InternalTest(l1, l2, expected);
		}

		void InternalTest(ListNode l1, ListNode l2, ListNode expected)
		{
			ListNode actual = MergeTwoSortedLists.MergeTwoLists(l1, l2);
			AssertHelper.AssertListNode(expected, actual);
		}
	}
}
