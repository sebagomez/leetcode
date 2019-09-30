using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class SymmetricTree
	{
		public static bool IsSymmetric(TreeNode root)
		{
			return IsMirror(root, root);
		}

		static bool IsMirror(TreeNode t1, TreeNode t2)
		{
			if (t1 == null && t2 == null)
				return true;

			if (t1 == null || t2 == null)
				return false;

			if (t1.val != t2.val)
				return false;

			return IsMirror(t1.left, t2.right) && IsMirror(t1.right, t2.left);
		}
	}
}
