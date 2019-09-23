using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	[TestClass]
	public class ReverseStringTests
	{
		[TestMethod]
		public void ReverseStringTests1()
		{
			char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };
			char[] expected = new char[] { 'o', 'l', 'l', 'e', 'h' };
			InternalTest(s, expected);
		}

		[TestMethod]
		public void ReverseStringTests2()
		{
			char[] s = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
			char[] expected = new char[] { 'h', 'a', 'n', 'n', 'a', 'H' };
			InternalTest(s, expected);
		}

		void InternalTest(char[] s, char[] expected)
		{
			ReverseString.Solve(s);
			Assert.AreEqual<int>(expected.Length, s.Length);
			for (int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual<char>(expected[i], s[i]);
			}
		}
	}
}
