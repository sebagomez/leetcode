using System.Text;

namespace LeetCode
{
	public class AddArrays
    {
		public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			ListNode head = new ListNode(0);
			ListNode aux = head;
			int sum = 0, extra = 0;
			while (l1 != null || l2 != null)
			{
				sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + extra;
				ListNode node = new ListNode(sum % 10);
				extra = sum / 10;
				aux.next = node;
				aux = node;
				l1 = l1?.next;
				l2 = l2?.next;
			}

			if (extra != 0)
				aux.next = new ListNode(extra);

			return head.next;
		}
	}

	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }

		public ListNode(int[] array)
		{
			bool root = true;
			ListNode child = null;
			foreach (int value in array)
			{
				ListNode aux = null;
				if (root)
				{
					val = value;
					root = false;
					child = this;
				}
				else
				{
					aux = new ListNode(value);
					child.next = aux;
					child = aux;
				}
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder($"[{val}");
			ListNode child = next;
			while (child != null)
			{
				builder.Append($",{child.val}");
				child = child.next;
			}
			builder.Append("]");

			return builder.ToString();
		}

	}
}
