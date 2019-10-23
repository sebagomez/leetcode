using Leetcode;
using LeetCode.Helpers;
using LeetcodeTests.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class LowestCommonAncestorBinaryTreeTests
	{
		[Fact]
		public void LowestCommonAncestorBinaryTreeTests1()
		{
			TreeNode root = TreeNode.Get(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });
			TreeNode p = TreeNode.Get(new int?[] { 5 });
			TreeNode q = TreeNode.Get(new int?[] { 1 });
			TreeNode expected = TreeNode.Get(new int?[] { 3 });
			InternalTest(root, p, q, expected);
		}

		[Fact]
		public void LowestCommonAncestorBinaryTreeTests2()
		{
			TreeNode root = TreeNode.Get(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });
			TreeNode p = TreeNode.Get(new int?[] { 5 });
			TreeNode q = TreeNode.Get(new int?[] { 4 });
			TreeNode expected = TreeNode.Get(new int?[] { 5 });
			InternalTest(root, p, q, expected);
		}

		void InternalTest(TreeNode root, TreeNode p, TreeNode q, TreeNode expected)
		{
			TreeNode actual = LowestCommonAncestorBinaryTree.LowestCommonAncestor(root, p, q);
			AssertHelper.AssertTreeNode(expected, actual);
		}
	}
}
