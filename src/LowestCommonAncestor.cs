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
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }

			public static TreeNode InsertLevelNode(int[] tree, TreeNode root, int i)
			{
				if (i < tree.Length && tree[i] != int.MinValue)
				{
					TreeNode temp = new TreeNode(tree[i]);
					root = temp;

					//insert left child
					root.left = InsertLevelNode(tree, root.left, 2 * i + 1);

					//insert right child
					root.right = InsertLevelNode(tree, root.right, 2 * i + 2);
				}

				return root;
			}

			public override string ToString()
			{
				return val.ToString();
			}

		}

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
