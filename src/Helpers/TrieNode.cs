using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helpers
{
	public class TrieNode
	{
		public bool IsEnd;
		public int index;
		public Dictionary<char, TrieNode> Neighbors;

		public TrieNode()
		{
			this.IsEnd = false;
			this.Neighbors = new Dictionary<char, TrieNode>();
		}

	}
}
