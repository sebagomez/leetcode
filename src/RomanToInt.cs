using System;

namespace LeetCode
{
	public class RomanToInt
	{
		//Symbol Value
		//I             1
		//V             5
		//X             10
		//L             50
		//C             100
		//D             500
		//M             1000
		public static int Solve(string s)
		{
			int result = 0;
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				switch (c)
				{
					case 'M':
						result += 1000;
						break;
					case 'D':
						result += 500;
						break;
					case 'C':
						if ((i + 1) < s.Length && (s[i + 1] == 'D' || s[i + 1] == 'M'))
							result -= 100;
						else
							result += 100;
						break;
					case 'L':
						result += 50;
						break;
					case 'X':
						if ((i + 1) < s.Length && (s[i + 1] == 'L' || s[i + 1] == 'C'))
							result -= 10;
						else
							result += 10;
						break;
					case 'V':
						result += 5;
						break;
					case 'I':
						if ((i + 1) < s.Length && (s[i + 1] == 'V' || s[i + 1] == 'X'))
							result -= 1;
						else
							result += 1;
						break;
					default:
						throw new Exception($"Invalid Roman character: {c}");
				}
			}

			return result;
		}

	}
}
