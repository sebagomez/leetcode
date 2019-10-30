using Leetcode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetcodeTests
{
	public class ImplementTrieTests
	{
		[Fact]
		public void ImplementTrieTests1()
		{
			ImplementTrie trie = new ImplementTrie();

			trie.Insert("apple");
			bool result = trie.Search("apple");   // returns true
			Assert.True(result);
			result = trie.Search("app");     // returns false
			Assert.False(result);
			result = trie.StartsWith("app"); // returns true
			Assert.True(result);
			trie.Insert("app");
			result = trie.Search("app");     // returns true
			Assert.True(result);
		}
	}
}
