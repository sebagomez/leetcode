using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class ImplementStrStrTests
	{
		[Fact]
		public void ImplementStrStrTests1()
		{
			InternalTest("hello", "ll", 2);
		}

		[Fact]
		public void ImplementStrStrTests2()
		{
			InternalTest("aaaaa", "bba", -1);
		}

		[Fact]
		public void ImplementStrStrTests3()
		{
			InternalTest("a", "a", 0);
		}

		[Fact]
		public void ImplementStrStrTests4()
		{
			InternalTest("mississippi", "pi", 9);
		}

		void InternalTest(string str1, string str2, int expected)
		{
			int actual = ImplementStrStr.StrStr(str1, str2);
			Assert.Equal<int>(expected, actual);
		}
	}
}
