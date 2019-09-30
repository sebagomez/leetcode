using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.AddArrays;

namespace LeetCode
{
	public class ReverseLinkedList
	{
		public static ListNode ReverseList(ListNode head)
		{
			Stack<ListNode> stack = new Stack<ListNode>();
			while (head != null)
			{
				stack.Push(head);
				head = head.next;
			}

			ListNode tail = null;
			ListNode current = null;
			while (stack.Count != 0)
			{
				ListNode node = stack.Pop();
				if (current != null)
					current.next = node;
				else
					tail = node;
				current = node;
			}
			if (current != null)
				current.next = null;

			return tail;
		}
	}
}
