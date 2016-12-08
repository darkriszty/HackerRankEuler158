using NUnit.Framework;

namespace HREuler158.Tests
{
	[TestFixture]
	public class QuickMathTets
	{
		[TestCase(0, ExpectedResult = "1")]
		[TestCase(1, ExpectedResult = "1")]
		[TestCase(2, ExpectedResult = "2")]
		[TestCase(22, ExpectedResult = "1124000727777607680000")]
		public string Fact_ReturnsCorrectValue(int n)
		{
			return HackerRankEuler158.QuickMath.Factorial(n).ToString();
		}

		[TestCase(26, 3, ExpectedResult = "2600")]
		[TestCase(26, 17, ExpectedResult = "3124550")]
		public string Combination_ReturnsCorrectValue(int n, int k)
		{
			return HackerRankEuler158.QuickMath.Combination(n, k).ToString();
		}

		[TestCase(0, ExpectedResult = "0")]
		[TestCase(1, ExpectedResult = "0")]
		[TestCase(2, ExpectedResult = "1")]
		[TestCase(3, ExpectedResult = "4")]
		[TestCase(4, ExpectedResult = "11")]
		[TestCase(33, ExpectedResult = "8589934558")]
		public string EulerianTriangleColumnTwoNumber_ReturnsCorrectValue(int n)
		{
			return HackerRankEuler158.QuickMath.EulerianTriangleColumnTwoNumber(n).ToString();
		}
	}
}
