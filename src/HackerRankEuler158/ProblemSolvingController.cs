using System;

namespace HackerRankEuler158
{
	public class ProblemSolvingController
	{
		public void Solve()
		{
			var input = new InputReader().ReadInput(Console.In);

			var calculator1 = new CharsLexicographicallyAfterNeighborCalculator(
				input.AlphabetSize,
				new BiggerNeighborCountProviderMemoryCacher(
					new BiggerNeighborCountProvider()
				)
			);
			var calculator2 = new SumMaxMValueCalculator(calculator1);

			int sum = calculator2.GetValue(input);

			Console.WriteLine(sum);
		}
	}
}
