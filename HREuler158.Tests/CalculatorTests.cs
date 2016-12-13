using HackerRankEuler158;
using NUnit.Framework;

namespace HREuler158.Tests
{
	[TestFixture]
	public class CalculatorTests
	{
		[TestCase(2, 1, 0, ExpectedResult = "2")]
		[TestCase(2, 2, 0, ExpectedResult = "1")]
		[TestCase(2, 2, 1, ExpectedResult = "1")]
		[TestCase(26, 3, 1, ExpectedResult = "10400")]
		[TestCase(26, 4, 1, ExpectedResult = "164450")]
		public string PValue_ReturnsExpectedValue(int N, int n, int m)
		{
			return Calculator.MaxPValue(N, n, m).ToString();
		}
	}
}
