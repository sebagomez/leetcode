using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/maximum-depth-of-binary-tree/
	/// </summary>
	public class MaxDepthBinaryTree
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

				node.left = GetNodes(array, pos == 0 ? 1 : (int)(Math.Pow(2D, (double)pos) + 1D));
				node.right = GetNodes(array, pos == 0 ? 2 : (int)(Math.Pow(2D, (double)pos) + 2D));

				return node;
			}
		}

		public static int MaxDepth(TreeNode root)
		{
			return GetMaxDepth(root, 0);
		}

		static int GetMaxDepth(TreeNode root,int maxSoFar)
		{
			if (root == null)
				return maxSoFar;

			maxSoFar++;
			return Math.Max(GetMaxDepth(root.left, maxSoFar), GetMaxDepth(root.right, maxSoFar));
		}
	}
}
