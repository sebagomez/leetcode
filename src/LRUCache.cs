using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
	public class LRUCache
	{
		readonly Dictionary<int, int> m_dict = new Dictionary<int, int>();
		readonly int m_capacity = 0;
		readonly LinkedList<int> m_cache;

		public LRUCache(int capacity)
		{
			m_capacity = capacity;
			m_cache = new LinkedList<int>();
		}

		public int Get(int key)
		{
			if (m_dict.ContainsKey(key))
			{
				if (m_cache.Contains(key))
					m_cache.Remove(key);
				m_cache.AddLast(key);
				return m_dict[key];
			}
				
			return -1;
		}

		public void Put(int key, int value)
		{
			if (m_dict.Count == m_capacity && !m_dict.ContainsKey(key))
			{
				int old = m_cache.First.Value;
				m_cache.Remove(old);
				m_dict.Remove(old);
			}

			if (m_cache.Contains(key))
				m_cache.Remove(key);
			m_cache.AddLast(key);

			m_dict[key] = value;
		}
	}
}
