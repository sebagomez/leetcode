using LeetCode.Helpers;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests.Helpers
{
	public class AssertHelper
	{
		public static void AssertArrays(int[] expected, int[] actual)
		{
			Assert.Equal<int>(expected.Length, actual.Length);
			for (int i = 0; i < actual.Length; i++)
			{
				Assert.Equal<int>(expected[i], actual[i]);
			}
		}

		public static void AssertListNode(ListNode expected, ListNode actual)
		{
			while (actual != null || expected != null)
			{
				Assert.Equal<int>(expected.val, actual.val);
				expected = expected.next;
				actual = actual.next;
			}

			Assert.Null(actual);
			Assert.Null(expected);
		}
	}
}
