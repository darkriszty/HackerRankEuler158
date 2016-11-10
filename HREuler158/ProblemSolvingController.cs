using System;
using System.Diagnostics;

namespace HackerRankEuler158
{
	public class ProblemSolvingController
	{
		public void Solve()
		{
			var input = new InputReader().ReadInput(Console.In);

			var calculator1 = new CharsLexicographicallyAfterNeighborCalculator(
				input.AlphabetSize,
				new ExactBiggerRightNeighborInfoProvider(
					new BiggerNeighborCountProvider()
				)
			);
			var calculator2 = new SumMaxMValueCalculator(calculator1);

			Stopwatch sw = Stopwatch.StartNew();
			int sum = calculator2.GetValue(input);
			sw.Stop();
			Console.WriteLine(sum);
			Console.WriteLine($"Duration: {sw.Elapsed.TotalSeconds} seconds.");
		}
	}
}
