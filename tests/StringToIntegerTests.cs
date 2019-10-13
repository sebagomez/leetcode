using LeetCode;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
	
	public class StringToIntegerTests
	{
		[Fact]
		public void StringToIntegerTests1()
		{
			InternalTest("42",42);
		}

		[Fact]
		public void StringToIntegerTests2()
		{
			InternalTest("   -42", -42);
		}

		[Fact]
		public void StringToIntegerTests3()
		{
			InternalTest("4193 with words", 4193);
		}

		[Fact]
		public void StringToIntegerTests4()
		{
			InternalTest("-91283472332", int.MinValue);
		}

		[Fact]
		public void StringToIntegerTests5()
		{
			InternalTest("+1", 1);
		}

		[Fact]
		public void StringToIntegerTests6()
		{
			InternalTest(" + 0 123", 0);
		}

		void InternalTest(string str, int expected)
		{
			int actual = StringToInteger.MyAtoi(str);
			Assert.Equal<int>(expected, actual);
		}
	}
}
