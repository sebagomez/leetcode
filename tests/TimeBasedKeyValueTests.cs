using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.TimeBasedKeyValue;

namespace LeetcodeTests
{
	
	public class TimeBasedKeyValueTests
	{
		[Fact]
		public void TimeBasedKeyValueTests1()
		{
			TimeMap kv = new TimeMap();
			kv.Set("foo", "bar", 1);
			string val = kv.Get("foo", 1);
			Assert.Equal("bar", val);
			val = kv.Get("foo", 3);
			Assert.Equal("bar", val);
			kv.Set("foo", "bar2", 4);
			val = kv.Get("foo", 4); 
			Assert.Equal("bar2", val);
			val = kv.Get("foo", 5); 
			Assert.Equal("bar2", val);
		}

		[Fact]
		public void TimeBasedKeyValueTests2()
		{
			TimeMap kv = new TimeMap();
			kv.Set("love", "high", 10);
			kv.Set("love", "low", 20);
			string val = kv.Get("love", 5);
			Assert.Equal("", val);
			val = kv.Get("love", 10);
			Assert.Equal("high", val);
			val = kv.Get("love", 15);
			Assert.Equal("high", val);
			val = kv.Get("love", 20);
			Assert.Equal("low", val);
			val = kv.Get("love", 25);
			Assert.Equal("low", val);
		}
	}
}
