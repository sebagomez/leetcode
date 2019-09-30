using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	//https://leetcode.com/problems/minimum-height-trees/
	public class MinimumHeightTrees
	{
		public static IList<int> FindMinHeightTrees(int n, int[][] edges)
		{
			if (n < 2)
				return new List<int> { 0 };
			else if (n == 2)
				return new List<int> { edges[0][0], edges[0][1] };

			Dictionary<int, List<int>> aux = new Dictionary<int, List<int>>();
			for (int i = 0; i < edges.GetLength(0); i++)
			{
				if (!aux.ContainsKey(edges[i][0]))
					aux[edges[i][0]] = new List<int>();

				aux[edges[i][0]].Add(edges[i][1]);

				if (!aux.ContainsKey(edges[i][1]))
					aux[edges[i][1]] = new List<int>();

				aux[edges[i][1]].Add(edges[i][0]);
			}

			do
			{
				//Remove leaves
				aux = aux.Where(pair => pair.Value.Count > 1)
							.ToDictionary(pair => pair.Key, pair => pair.Value);

				//Remove steps to leaves
				foreach (var key in aux.Keys)
				{
					for (int i = aux[key].Count - 1; i >= 0; i--)
					{
						if (!aux.ContainsKey(aux[key][i]))
							aux[key].RemoveAt(i);
					}
				}


			} while (aux.Count > 2);

			List<int> t2 = new List<int>();
			int max = -1;
			foreach (var key in aux.Keys)
			{
				int count = aux[key].Count;
				if (count > max)
				{
					t2.Clear();
					t2.Add(key);
					max = count;
				}
				else if (count == max)
				{
					t2.Add(key);
				}
			}

			return t2;
		}
	}
}
