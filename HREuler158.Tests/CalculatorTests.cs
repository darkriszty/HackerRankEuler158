using HackerRankEuler158;
using NUnit.Framework;

namespace HREuler158.Tests
{
	[TestFixture]
	public class CalculatorTests
	{
		[TestCase(1, 0, ExpectedResult = "2")]
		[TestCase(2, 0, ExpectedResult = "1")]
		[TestCase(2, 1, ExpectedResult = "1")]
		[TestCase(3, 27, ExpectedResult = "10400")]
		public string P_ReturnsCorrectValue(int n, int m)
		{
			return Calculator.P(n, m).ToString();
		}
	}
}
