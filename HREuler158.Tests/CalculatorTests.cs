using HackerRankEuler158;
using NUnit.Framework;
using System.Collections.Generic;

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
		public string MaxPValue_ReturnsExpectedValue(int N, int n, int m)
		{
			return Calculator.MaxPValue(N, n, m).ToString();
		}

		private static IEnumerable<TestCaseData> _sumOfMaxesData = new []
		{
			new TestCaseData(
				new InputModel()
				{
					AlphabetSize = 2,
					NumberOfQueries = 2,
					NumberOfCharactersLexicographicallyComingAfterNeighbours = new [] { 0, 1 }
				}
			).Returns("3"),
			new TestCaseData(
				new InputModel()
				{
					AlphabetSize = 26,
					NumberOfQueries = 1,
					NumberOfCharactersLexicographicallyComingAfterNeighbours = new [] { 1 }
				}
			).Returns("409511334375"),
			new TestCaseData(
				new InputModel()
				{
					AlphabetSize = 370,
					NumberOfQueries = 1,
					NumberOfCharactersLexicographicallyComingAfterNeighbours = new [] { 113 }
				}
			).Returns("1129486192863670815372730620783152644645169144247331854650104890934035038415521631432743889282750822808904404152554392419100015462010749396855372214202134439383005223993275853659632338481662941604983330613726645748743220498005100211093730252494710152488313297130400883899674846529159641866613001987231791119378875444258492747772042912756321688460087879204313606440801985809559552544736627756954418383722891987501053820677434636345597889080568477548141061047068163094255641064091257005512102976283023161469868080296772380837979049654271185843505158957683435991574363104033686113208248875901951735636904366399852613949380041396808107903157018417249032123262350144516972365274229892284882967614181398937449987742209157797396847422776501855821264609860903760")
		};
		[Test, TestCaseSource(nameof(_sumOfMaxesData))]
		public string SumOfMaxes_ReturnsExpectedValue(InputModel input)
		{
			return Calculator.SumOfMaxes(input).ToString();
		}
	}
}
