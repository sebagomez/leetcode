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
	
	public class LowestCommonAncestorTests
	{
		[Fact]
		public void LowestCommonAncestorTests1()
		{
			TreeNode expected = new TreeNode(3);
			InternalTest(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 }, 5, 1, expected);
		}

		[Fact]
		public void LowestCommonAncestorTests2()
		{
			TreeNode expected = new TreeNode(5);
			InternalTest(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 }, 5, 4, expected);
		}

		void InternalTest(int?[] tree, int p, int q, TreeNode expected)
		{
			TreeNode root = TreeNode.Get(tree);
			TreeNode nodeP = new TreeNode(p);
			TreeNode nodeQ = new TreeNode(q);
			TreeNode actual = LowestCommonAncestor.Solve(root, nodeP, nodeQ);
			Assert.Equal<int>(expected.val, actual.val);
		}
	}
}
