using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class MergeTwoSortedLists
	{
		public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			ListNode root = null;
			ListNode current = null;
			ListNode min = l1 != null && l2 != null ? l1.val <= l2.val ? l1 : l2 : l1 != null ? l1 : l2;
			while (l1 != null || l2 != null)
			{
				if (l1 != null && l2 != null)
				{
					if (l1.val <= l2.val)
					{
						if (root == null)
							root = l1;

						if (current == null)
							current = l1;
						else
						{
							current.next = l1;
							current = current.next;
						}

						l1 = l1.next;
					}
					else
					{
						if (root == null)
							root = l2;
						if (current == null)
							current = l2;
						else
						{
							current.next = l2;
							current = current.next;
						}
						l2 = l2.next;
					}
					continue;
				}

				if (l2 == null)
				{
					if (root == null)
						root = l1;

					if (current == null)
						current = l1;
					else
					{
						current.next = l1;
						current = current.next;
					}
					l1 = l1.next;
					continue;
				}

				if (l1 == null)
				{
					if (root == null)
						root = l2;
					if (current == null)
						current = l2;
					else
					{
						current.next = l2;
						current = current.next;
					}
					l2 = l2.next;
					continue;
				}
			}

			return root;
		}
	}
}
