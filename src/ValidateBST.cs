using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ValidateBST
	{
		public static bool IsValidBST(TreeNode root)
		{
			return TraverseBST(root, long.MinValue, long.MaxValue);
		}

		static bool TraverseBST(TreeNode root, long minVal, long maxVal)
		{
			if (root == null)
				return true;

			if (root.val <= minVal || root.val >= maxVal)
				return false;


			return TraverseBST(root.left, minVal, root.val) &&
				   TraverseBST(root.right, root.val, maxVal);
		}
	}
}
