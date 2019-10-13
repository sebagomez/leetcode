using LeetCode;
using LeetCode.Helpers;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class MaxDepthBinaryTreeTests
	{
		[Fact]
		public void MaxDepthBinaryTreeTests1()
		{
			int?[] tree = new int?[] { 3, 9, 20, null, null, 15, 7 };
			InternalTest(tree, 3);
		}

		void InternalTest(int?[] tree, int expected)
		{
			TreeNode root = TreeNode.Get(tree);
			int actual = MaxDepthBinaryTree.MaxDepth(root);
			Assert.Equal<int>(expected, actual);
		}
	}
}
