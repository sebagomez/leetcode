using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/reorder-data-in-log-files/
	/// </summary>
	public class ReorderDataLogFiles
	{
		public static string[] ReorderLogFiles(string[] logs)
		{
			Dictionary<string, int> letterLogs = new Dictionary<string, int>();
			Queue<string> digLogs = new Queue<string>();

			for (int i = 0; i <logs.Length; i++)
			{
				string line = logs[i];
				int space = line.IndexOf(" ");
				string head = line.Substring(0, space);
				string data = line.Substring(space + 1);
				string key = data.Replace(" ", "");

				if (data[0] < 58)
				{
					digLogs.Enqueue(line);
				}
				else
				{
					letterLogs[$"{data}:{head}"] = i;
				}
			}

			string[] ordered = new string[logs.Length];
			int index = 0;
			foreach (string key in letterLogs.Keys.OrderBy(s => s))
			{
				ordered[index] = logs[letterLogs[key]];
				index++;
			}

			foreach (string item in digLogs)
			{
				ordered[index] = item;
				index++;
			}

			return ordered;
		}
	}
}
