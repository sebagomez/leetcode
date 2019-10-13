using System.Collections.Generic;
using LeetCode;
using LeetCode.Helpers;
using Xunit;

namespace LeetcodeTests
{
	
	public class MergeKSortedListTests
	{
		[Fact]
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
			Assert.Equal(expected, result.ToString());
		}
	}
}
