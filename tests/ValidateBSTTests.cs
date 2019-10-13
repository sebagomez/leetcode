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
	
	public class ValidateBSTTests
	{
		[Fact]
		public void ValidateBSTTests1()
		{
			int?[] tree = new int?[] { 2, 1, 3 };
			InternalTest(tree, true);
		}

		[Fact]
		public void ValidateBSTTests2()
		{
			int?[] tree = new int?[] { 5, 1, 4, null, null, 3, 6 };
			InternalTest(tree, false);
		}

		[Fact]
		public void ValidateBSTTests3()
		{
			int?[] tree = new int?[] { 1, 1 };
			InternalTest(tree, false);
		}

		[Fact]
		public void ValidateBSTTests4()
		{
			int?[] tree = new int?[] { 10, 5, 15, null, null, 6, 20 };
			InternalTest(tree, false);
		}

		[Fact]
		public void ValidateBSTTests5()
		{
			int?[] tree = new int?[] { 3, 1, 5, 0, 2, 4, 6 };
			InternalTest(tree, true);
		}

		[Fact]
		public void ValidateBSTTests6()
		{
			int?[] tree = new int?[] { 2147483647 };
			InternalTest(tree, true);
		}

		void InternalTest(int?[] tree, bool expected)
		{
			TreeNode root = TreeNode.Get(tree);
			bool actual = ValidateBST.IsValidBST(root);
			Assert.Equal<bool>(expected, actual);
		}
	}
}
