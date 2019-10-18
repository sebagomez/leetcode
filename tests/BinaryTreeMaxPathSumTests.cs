using Leetcode;
using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class BinaryTreeMaxPathSumTests
	{
		[Fact]
		public void BinaryTreeMaxPathSumTests01()
		{
			TreeNode root = TreeNode.Get(new int?[] { 1, 2, 3 });
			InternalTest(root, 6);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests02()
		{
			TreeNode root = TreeNode.Get(new int?[] { -10, 9, 20, null, null, 15, 7 });
			InternalTest(root, 42);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests03()
		{
			TreeNode root = TreeNode.Get(new int?[] { -3 });
			InternalTest(root, -3);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests04()
		{
			TreeNode root = TreeNode.Get(new int?[] { 1, 2 });
			InternalTest(root, 3);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests05()
		{
			TreeNode root = TreeNode.Get(new int?[] { 2, -1 });
			InternalTest(root, 2);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests06()
		{
			TreeNode root = TreeNode.Get(new int?[] { 1, -2, 3 });
			InternalTest(root, 4);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests07()
		{
			TreeNode root = TreeNode.Get(new int?[] { 1, -2, -3, 1, 3, -2, null, -1 });
			InternalTest(root, 3);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests08()
		{
			TreeNode root = TreeNode.Get(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 });
			InternalTest(root, 49);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests09()
		{
			TreeNode root = TreeNode.Get(new int?[] { 1, 1, 1, 1, 1, 1, 1 });
			InternalTest(root, 5);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests10()
		{
			TreeNode root = TreeNode.Get(new int?[] { 10, 9, 20, null, null, 15, 7 });
			InternalTest(root, 54);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests11()
		{
			TreeNode root = TreeNode.Get(new int?[] { 2, -1, -2 });
			InternalTest(root, 2);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests12()
		{
			TreeNode root = TreeNode.Get(new int?[] { -1, 5, null, 4, null, null, 2, -4 });
			InternalTest(root, 9);
		}

		[Fact]
		public void BinaryTreeMaxPathSumTests13()
		{
			TreeNode root = TreeNode.Get(new int?[] { 9, 6, -3, null, null, -6, 2, null, null, 2, null, -6, -6, -6 });
			InternalTest(root, 15);
		}

		void InternalTest(TreeNode root, int expected)
		{
			int actual = BinaryTreeMaxPathSum.MaxPathSum(root);
			Assert.Equal(expected, actual);
		}
	}
}
