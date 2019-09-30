using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class PalindromeLinkedList
	{
		public static bool IsPalindrome(ListNode head)
		{
			ListNode tmp = head;
			Stack<int> stack = new Stack<int>();
			while (head != null)
			{
				stack.Push(head.val);
				head = head.next;
			}

			while (stack.Count != 0)
			{
				if (stack.Pop() != tmp.val)
					return false;
				tmp = tmp.next;
			}

			return true;
		}
	}
}
