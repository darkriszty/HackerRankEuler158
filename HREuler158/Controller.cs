using System;
using System.Diagnostics;
using System.Numerics;

namespace HackerRankEuler158
{
	public class Controller
	{
		public void Solve()
		{
			var input = new InputReader().ReadInput(Console.In);

			Stopwatch sw = Stopwatch.StartNew();

			BigInteger sum = 0;

			for (int n = 1; n <= input.AlphabetSize; n++)
			{
				BigInteger max = 0;
				for (int i = 0; i < input.NumberOfQueries; i++)
				{
					int mi = input.NumberOfCharactersLexicographicallyComingAfterNeighbours[i];
					BigInteger p = Calculator.MaxPValue(input.AlphabetSize, n, mi);
					if (p > max)
						max = p;
				}
				sum += max;
			}

			sw.Stop();
			Console.WriteLine(sum);
			Console.WriteLine($"Duration: {sw.Elapsed.TotalSeconds} seconds.");
		}
	}
}
