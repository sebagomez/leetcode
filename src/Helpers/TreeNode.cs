using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helpers
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }

		public static TreeNode Get(int?[] array)
		{
			return GetNodes(array, 0);
		}

		public override string ToString()
		{
			return val.ToString();
		}

		static TreeNode GetNodes(int?[] array, int pos)
		{
			TreeNode node;
			if (pos < array.Length && array[pos].HasValue)
				node = new TreeNode(array[pos].Value);
			else
				return null;

			node.left = GetNodes(array, 2 * pos + 1);
			node.right = GetNodes(array, 2 * pos + 2);

			return node;
		}
	}
}
