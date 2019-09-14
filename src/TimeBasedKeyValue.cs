using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/time-based-key-value-store/
	/// </summary>
	public class TimeBasedKeyValue
	{
		public class TimeMap
		{
			public class TimeValue
			{
				public string Value { get; set; }
				public int Timestamp { get; set; }
				public TimeValue(string value, int timestamp)
				{
					Value = value;
					Timestamp = timestamp;
				}
			}

			Dictionary<string, List<TimeValue>> values;
			/** Initialize your data structure here. */
			public TimeMap()
			{
				values = new Dictionary<string, List<TimeValue>>();
			}

			public void Set(string key, string value, int timestamp)
			{
				if (!values.ContainsKey(key))
				{
					values[key] = new List<TimeValue> { new TimeValue(value, timestamp) };
				}
				else
				{
					values[key].Add(new TimeValue(value, timestamp));
				}
			}

			public string Get(string key, int timestamp)
			{
				if (!values.ContainsKey(key))
					return "";

				List<TimeValue> list = values[key];


				int start = 0;
				int end = list.Count - 1;
				if (timestamp < list[start].Timestamp)
					return "";

				if (timestamp > list[end].Timestamp)
					return list[end].Value;
				
				int mid = 0;
				int currTimestamp = 0;
				while (start <= end)
				{
					mid = (start + end) / 2;
					currTimestamp = list[mid].Timestamp;
					if (currTimestamp == timestamp)
					{
						return list[mid].Value;
					}
					else if (timestamp < currTimestamp)
					{
						end = mid - 1;
					}
					else if (timestamp > currTimestamp)
					{
						start = mid + 1;
					}
				}
				return list[end].Timestamp > list[start].Timestamp ? list[start].Value : list[end].Value;
			}
		}
	}
}
