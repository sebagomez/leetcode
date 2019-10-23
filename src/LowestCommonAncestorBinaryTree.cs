using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class LowestCommonAncestorBinaryTree
	{
		public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
		{
			List<TreeNode> listP = new List<TreeNode>();
			List<TreeNode> listQ = new List<TreeNode>();
			GetPathList(root, p, listP);
			GetPathList(root, q, listQ);

			int i = 0;
			TreeNode lca = listP[i];
			while (i < listP.Count && i < listQ.Count && listP[i].val == listQ[i].val)
			{
				lca = listP[i];
				i++;
			}

			return lca;
		}

		private static bool GetPathList(TreeNode current, TreeNode destination, List<TreeNode> list)
		{
			if (current == null)
				return false;

			list.Add(current);

			if (current.val == destination.val)
				return true;

			bool found = GetPathList(current.left, destination, list);
			if (!found)
				found = GetPathList(current.right, destination, list);

			if (!found)
				list.Remove(current);

			return found;
		}
	}
}
