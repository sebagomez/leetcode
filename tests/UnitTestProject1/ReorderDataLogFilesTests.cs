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
	public class ReorderDataLogFilesTests
	{
		[TestMethod]
		public void ReorderDataLogFilesTests1()
		{
			string[] logs = new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
			string[] expected = new string[] { "let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6" };
			InternalTest(logs, expected);
		}

		[TestMethod]
		public void ReorderDataLogFilesTests2()
		{
			string[] logs = new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
			string[] expected = new string[] { "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7" };
			InternalTest(logs, expected);
		}

		[TestMethod]
		public void ReorderDataLogFilesTests3()
		{
			string[] logs = new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo", "a2 act car" };
			string[] expected = new string[] { "a2 act car", "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7" };
			InternalTest(logs, expected);
		}

		[TestMethod]
		public void ReorderDataLogFilesTests4()
		{
			string[] logs = new string[] { "j mo", "5 m w", "g 07", "o 2 0", "t q h" };
			string[] expected = new string[] { "5 m w", "j mo", "t q h", "g 07", "o 2 0" };
			InternalTest(logs, expected);
		}

		void InternalTest(string[] logs, string[] expected)
		{
			string[] actual = ReorderDataLogFiles.ReorderLogFiles(logs);
			Assert.AreEqual<int>(expected.Length, actual.Length);
			for (int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual<string>(expected[i], actual[i], $"Expected '{expected[i]}' and got '{actual[i]}'");
			}
		}
	}
}
