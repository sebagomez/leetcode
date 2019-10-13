using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class RemoveNthNode
	{
		public static ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			Stack<ListNode> stack = new Stack<ListNode>();
			ListNode aux = head;
			while (aux != null)
			{
				stack.Push(aux);
				aux = aux.next;
			}

			//the first one
			if (n == stack.Count)
			{
				if (n == 1)
					return null;
				head.val = head.next.val;
				head.next = head.next.next;
				return head;
			}

			//the last one
			if (n == 1)
			{
				aux = stack.Pop();
				aux = stack.Pop();
				aux.next = null;
				return head;
			}

			int count = 1;
			while (count <= n)
			{
				aux = stack.Pop();
				count++;
			}

			aux.val = aux.next.val;
			aux.next = aux.next.next;

			return head;
		}
	}
}
