using LeetCode;
using LeetCode.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	[TestClass]
	public class MaxDepthBinaryTreeTests
	{
		[TestMethod]
		public void MaxDepthBinaryTreeTests1()
		{
			int?[] tree = new int?[] { 3, 9, 20, null, null, 15, 7 };
			InternalTest(tree, 3);
		}

		void InternalTest(int?[] tree, int expected)
		{
			TreeNode root = TreeNode.Get(tree);
			int actual = MaxDepthBinaryTree.MaxDepth(root);
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
