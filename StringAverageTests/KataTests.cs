using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringAverage;

namespace StringAverage.Tests
{
	[TestFixture()]
	public class KataTests
	{
		[TestCase("", ExpectedResult = "n/a", TestName = "Empty_Should_be_n/a")]
		[TestCase("five four", ExpectedResult = "four", TestName = "five four_Should_be_four")]
		[TestCase("one one eight one", ExpectedResult = "two", TestName = "one one eight one_Should_be_two")]
		[TestCase("zero nine five two", ExpectedResult = "four", TestName = "zero nine five two_Should_be_four")]
		[TestCase("four six two three", ExpectedResult = "three", TestName = "four six two three_Should_be_three")]
		[TestCase("one two three four five", ExpectedResult = "three", TestName = "one two three four five_Should_be_three")]
		[TestCase("zero zero zero zero zero", ExpectedResult = "zero", TestName = "zero zero zero zero zero five_Should_be_zero")]
		[TestCase("four six nine tphunt two six", ExpectedResult = "n/a", TestName = "four six nine tphunt two six_Should_be_n/a")]
		public string AverageStringTest(string input)
		{
			return Kata.AverageString(input);
		}
	}
}