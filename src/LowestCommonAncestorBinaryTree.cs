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
			return FindLCARecursive(root, p, q);
		}

		private static TreeNode FindLCARecursive(TreeNode root, TreeNode p, TreeNode q)
		{
			if (root == null)
				return null;

			TreeNode left = FindLCARecursive(root.left, p, q);
			TreeNode right = FindLCARecursive(root.right, p, q);

			if (left != null && right != null)
				return root;

			if (root.val == q.val || root.val == p.val)
				return root;

			return left != null ? left : right;
		}

		public static TreeNode LowestCommonAncestor_solw(TreeNode root, TreeNode p, TreeNode q)
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
