using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ShuffleAnArray
	{
		int[] m_original;
		Random m_random = new Random();

		public ShuffleAnArray(int[] nums)
		{
			m_original = new int[nums.Length];
			for (int i = 0; i < nums.Length; i++)
				m_original[i] = nums[i];
		}

		public int[] Reset()
		{
			return m_original;
		}

		public int[] Shuffle()
		{
			if (m_original.Length == 0)
				return m_original;

			int[] shuffle = new int[m_original.Length];

			for (int i = 0; i < m_original.Length; i++)
			{
				int index = m_random.Next(m_original.Length);
				while (shuffle[index] != 0)
					index = m_random.Next(m_original.Length);

				shuffle[index] = m_original[i];
			}

			return shuffle;
		}
	}
}
