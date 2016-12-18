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
		public string Fact_ReturnsExpectedValue(int n)
		{
			return HackerRankEuler158.QuickMath.Factorial(n).ToString();
		}

		[TestCase(26, 3, ExpectedResult = "2600")]
		[TestCase(26, 17, ExpectedResult = "3124550")]
		[TestCase(55, 25, ExpectedResult = "3085851035479212")]
		[TestCase(55, 27, ExpectedResult = "3824345300380220")]
		[TestCase(55, 40, ExpectedResult = "11899700525790")]
		[TestCase(80, 40, ExpectedResult = "107507208733336176461620")]
		[TestCase(1500, 1000, ExpectedResult = "98010513044822919834407342078238239157186727586439781144418266253357798614326731613867071445415360139050763348777436107629999592084166534088385225622816961675507827371501303248023952245574590017845282159263100212480872360068509433124385593841191804557601213955653337688570435422501226993482092868405683701669235947844925661098604727643099468550419961004099635651249338198098248645967339936333684932921501644321120")]
		public string Combination_ReturnsExpectedValue(int n, int k)
		{
			return HackerRankEuler158.QuickMath.Combination(n, k).ToString();
		}

		[TestCase(1, 0, ExpectedResult = "1")]
		[TestCase(2, 0, ExpectedResult = "1")]
		[TestCase(2, 1, ExpectedResult = "1")]
		[TestCase(3, 0, ExpectedResult = "1")]
		[TestCase(3, 1, ExpectedResult = "4")]
		[TestCase(3, 2, ExpectedResult = "1")]
		[TestCase(4, 1, ExpectedResult = "11")]
		[TestCase(5, 5, ExpectedResult = "0")]
		[TestCase(7, 5, ExpectedResult = "120")]
		[TestCase(9, 4, ExpectedResult = "156190")]
		[TestCase(12, 3, ExpectedResult = "10187685")]
		[TestCase(12, 5, ExpectedResult = "162512286")]
		[TestCase(12, 6, ExpectedResult = "162512286")]
		[TestCase(33, 1, ExpectedResult = "8589934558")]
		public string EulerianTriangleColumnTwoNumber_ReturnsExpectedValue(int n, int m)
		{
			return HackerRankEuler158.QuickMath.EulerianTriangleNumber(n, m).ToString();
		}
	}
}
