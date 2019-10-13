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
	
	public class SymmetricTreeTests
	{
		[Fact]
		public void SymmetricTreeTests1()
		{
			int?[] tree = new int?[] { 1, 2, 2, 3, 4, 4, 3 };
			InternalTest(tree, true);
		}

		[Fact]
		public void SymmetricTreeTests2()
		{
			int?[] tree = new int?[] { 1, 2, 2, null, 3, null, 3 };
			InternalTest(tree, false);
		}

		[Fact]
		public void SymmetricTreeTests3()
		{
			int?[] tree = new int?[] { 4, -57, -57, null, 67, 67, null, null, null, null, -97, -97 };
			InternalTest(tree, true);
		}

		void InternalTest(int?[] tree, bool expected)
		{
			TreeNode root = TreeNode.Get(tree);
			bool actual = SymmetricTree.IsSymmetric(root);
			Assert.Equal<bool>(expected, actual);
		}
	}
}
