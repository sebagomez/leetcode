using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/merge-k-sorted-lists/
	/// </summary>
	public class MergeKSortedList
	{
		public static ListNode MergeKLists(ListNode[] lists)
		{
			Dictionary<int, ListNode> index = new Dictionary<int, ListNode>();
			for (int i = 0; i < lists.Length; i++)
				index[i] = lists[i];

			ListNode current = null;
			ListNode root = null;
			bool done = false;
			while (!done)
			{
				int min = int.MaxValue;
				done = true;
				for (int i = 0; i < index.Count; i++)
				{
					if (index[i] != null)
					{
						min = Math.Min(index[i].val, min);
						done = false;
					}

				}

				for (int i = 0; i < index.Count; i++)
				{
					if (index[i] != null && index[i].val == min)
					{
						if (root == null)
							root = index[i];

						if (current != null)
							current.next = index[i];

						current = index[i];
						index[i] = index[i].next;
					}
				}
			}

			return root;
		}
	}
}
