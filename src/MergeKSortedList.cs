using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class MergeKSortedList
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }

			public ListNode(string list)
			{
				string[] values = list.Split(new char[] { ',' });
				ListNode last = null;
				foreach (string v in values)
				{
					if (last == null)
					{
						val = int.Parse(v);
						last = this;
					}
					else
					{
						ListNode child = new ListNode(int.Parse(v));
						last.next = child;
						last = child;
					}
				}
			}

			public override string ToString()
			{
				return $"{val}{(next != null ? "->" + next.ToString() : string.Empty)}";
			}
		}

		public static ListNode MergeKLists(ListNode[] lists)
		{
			Dictionary<int, ListNode> index = new Dictionary<int, ListNode>();
			for (int i = 0; i < lists.Length; i++)
			{
				index[i] = lists[i];
			}

			int min = int.MaxValue;
			ListNode root = null;
			ListNode last = null;

			while (index.Any( kv => kv.Value != null))
			{
				foreach (int i in index.Keys)
				{
					if(index[i] != null)
						min = Math.Min(min, index[i].val);
				}

				foreach (int i in index.Keys)
				{
					if (index[i] != null && index[i].val == min)
					{
						index[i] = index[i].next;
						break;
					}
				}

				if (root == null)
				{
					root = new ListNode(min);
					last = root;
				}
				else
				{
					ListNode child = new ListNode(min);
					last.next = child;
					last = child;
				}
				min = int.MaxValue;
			}

			return root;
		}
	}
}
