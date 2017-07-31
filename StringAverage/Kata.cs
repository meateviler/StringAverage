using System.Collections.Generic;
using System.Linq;

namespace StringAverage
{
	public class Kata
	{
		private static Dictionary<string, int> stringToInt = new Dictionary<string, int>()
		{
			{"zero",0},
			{"one",1},
			{"two",2},
			{"three",3},
			{"four",4},
			{"five",5},
			{"six",6},
			{"seven",7},
			{"eight",8},
			{"nine",9},
		};

		public static string AverageString(string str)
		{
			if (str.Trim() == string.Empty)
				return "n/a";
			var numString = str.Split(' ');
			var sum = 0;
			foreach (var numStr in numString)
			{
				if (!stringToInt.ContainsKey(numStr))
					return "n/a";
			}
			foreach (var numStr in numString)
			{
				sum += ParseInt(numStr.ToLower());
			}

			return ParseIntToString(sum / numString.Length);
		}

		private static string ParseIntToString(int p)
		{
			return stringToInt.FirstOrDefault(x => x.Value==p).Key;
		}

		private static int ParseInt(string numStr)
		{
			return stringToInt[numStr];
		}
	}
}