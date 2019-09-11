﻿using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.LowestCommonAncestor;

namespace UnitTestProject1
{
	[TestClass]
	public class LowestCommonAncestorTests
	{
		[TestMethod]
		public void LowestCommonAncestorTests1()
		{
			TreeNode expected = new TreeNode(3);
			InternalTest(new int[] { 3, 5, 1, 6, 2, 0, 8, int.MinValue, int.MinValue, 7, 4 }, 5, 1, expected);
		}

		[TestMethod]
		public void LowestCommonAncestorTests2()
		{
			TreeNode expected = new TreeNode(5);
			InternalTest(new int[] { 3, 5, 1, 6, 2, 0, 8, int.MinValue, int.MinValue, 7, 4 }, 5, 4, expected);
		}

		void InternalTest(int[] tree, int p, int q, TreeNode expected)
		{
			TreeNode root = TreeNode.InsertLevelNode(tree, null, 0);
			TreeNode nodeP = new TreeNode(p);
			TreeNode nodeQ = new TreeNode(q);
			TreeNode actual = LowestCommonAncestor.Solve(root, nodeP, nodeQ);
			Assert.AreEqual<int>(expected.val, actual.val);
		}
	}
}
