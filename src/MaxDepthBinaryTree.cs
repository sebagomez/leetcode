using LeetCode.Helpers;
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
