using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class SortList
	{
		public static ListNode Solve(ListNode head)
		{
			List<ListNode> aux = new List<ListNode>();
			while (head != null)
			{
				aux.Add(head);
				head = head.next;
			}

			ListNode root = null;
			foreach (ListNode node in aux)
			{
				node.next = null;
				if (root == null)
				{
					root = node;
					continue;
				}

				if (node.val <= root.val)
				{
					node.next = root;
					root = node;
				}
				else
				{
					ListNode index = root;
					while (index.next != null && node.val > index.next.val)
						index = index.next;

					ListNode tmp = index.next;
					index.next = node;
					node.next = tmp;
				}

			}

			return root;
		}
	}
}
