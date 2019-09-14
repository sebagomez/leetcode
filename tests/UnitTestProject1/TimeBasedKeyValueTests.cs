using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.TimeBasedKeyValue;

namespace UnitTestProject1
{
	[TestClass]
	public class TimeBasedKeyValueTests
	{
		[TestMethod]
		public void TimeBasedKeyValueTests1()
		{
			TimeMap kv = new TimeMap();
			kv.Set("foo", "bar", 1);
			string val = kv.Get("foo", 1);
			Assert.AreEqual<string>("bar", val);
			val = kv.Get("foo", 3);
			Assert.AreEqual<string>("bar", val);
			kv.Set("foo", "bar2", 4);
			val = kv.Get("foo", 4); 
			Assert.AreEqual<string>("bar2", val);
			val = kv.Get("foo", 5); 
			Assert.AreEqual<string>("bar2", val);
		}

		[TestMethod]
		public void TimeBasedKeyValueTests2()
		{
			TimeMap kv = new TimeMap();
			kv.Set("love", "high", 10);
			kv.Set("love", "low", 20);
			string val = kv.Get("love", 5);
			Assert.AreEqual<string>("", val);
			val = kv.Get("love", 10);
			Assert.AreEqual<string>("high", val);
			val = kv.Get("love", 15);
			Assert.AreEqual<string>("high", val);
			val = kv.Get("love", 20);
			Assert.AreEqual<string>("low", val);
			val = kv.Get("love", 25);
			Assert.AreEqual<string>("low", val);
		}
	}
}
