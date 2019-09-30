using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	//https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
	public class LowestCommonAncestor
	{
		public static TreeNode Solve(TreeNode root, TreeNode p, TreeNode q)
		{
			List<TreeNode> parentsP = new List<TreeNode>();
			TreeNode nodeP = FindNode(root, p.val, parentsP);
			List<TreeNode> parentsQ = new List<TreeNode>();
			TreeNode nodeQ = FindNode(root, q.val, parentsQ);

			foreach (TreeNode treeNode in parentsP)
			{
				if (parentsQ.Contains(treeNode))
					return treeNode;
			}

			return null;
		}

		private static TreeNode FindNode(TreeNode root, int node, List<TreeNode> parents)
		{
			if (root != null)
			{
				TreeNode found = FindNode(root.left, node, parents);
				if (found != null)
				{
					parents.Add(root);
					return found;
				}

				if (root.val == node)
				{
					parents.Add(root);
					return root;
				}
				found = FindNode(root.right, node, parents);
				if (found != null)
				{
					parents.Add(root);
					return found;
				}
			}

			return null;
		}

	}


}
