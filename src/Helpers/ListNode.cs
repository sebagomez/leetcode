using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helpers
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
			return $"{val}{(next != null ? "->" + next.ToString() : string.Empty)}";
		}
	}
}
