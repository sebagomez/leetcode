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
	public class SymmetricTreeTests
	{
		[TestMethod]
		public void SymmetricTreeTests1()
		{
			int?[] tree = new int?[] { 1, 2, 2, 3, 4, 4, 3 };
			InternalTest(tree, true);
		}

		[TestMethod]
		public void SymmetricTreeTests2()
		{
			int?[] tree = new int?[] { 1, 2, 2, null, 3, null, 3 };
			InternalTest(tree, false);
		}

		[TestMethod]
		public void SymmetricTreeTests3()
		{
			int?[] tree = new int?[] { 4, -57, -57, null, 67, 67, null, null, null, null, -97, -97 };
			InternalTest(tree, true);
		}

		void InternalTest(int?[] tree, bool expected)
		{
			TreeNode root = TreeNode.Get(tree);
			bool actual = SymmetricTree.IsSymmetric(root);
			Assert.AreEqual<bool>(expected, actual);
		}
	}
}
