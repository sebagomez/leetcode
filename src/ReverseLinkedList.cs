using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ReverseLinkedList
	{

		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }

			public static ListNode FromArray(int[] array)
			{
				ListNode head = null;
				for (int i = array.Length - 1; i >= 0; i--)
				{
					ListNode node = new ListNode(array[i])
					{
						next = head
					};
					head = node;
				}

				return head;
			}

			public override string ToString()
			{
				return val.ToString();
			}
		}

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
