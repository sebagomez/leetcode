using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class BinaryTreeMaxPathSum
	{
		public static int MaxPathSum(TreeNode root)
		{
			int maxSoFar = int.MinValue;
			int treeValue = GetMaxSubTree(root, ref maxSoFar);

			return maxSoFar;
		}

		private static int GetMaxSubTree(TreeNode node, ref int maxSoFar)
		{
			if (node == null)
				return 0;

			int left = Math.Max(GetMaxSubTree(node.left, ref maxSoFar), 0);
			int right = Math.Max(GetMaxSubTree(node.right, ref maxSoFar), 0);

			maxSoFar = Math.Max(maxSoFar, left + right + node.val);

			return node.val + Math.Max(left, right);
		}
	}
}
