using System.Numerics;

namespace HackerRankEuler158
{
	public static class Calculator
	{
		public static BigInteger SumOfMaxes(InputModel input)
		{
			BigInteger sumOfMaxes = 0;

			for (int i = 0; i < input.NumberOfQueries; i++)
			{
				BigInteger max = 0;
				for (int n = 1; n <= input.AlphabetSize; n++)
				{
					int mi = input.NumberOfCharactersLexicographicallyComingAfterNeighbours[i];
					BigInteger p = MaxPValue(input.AlphabetSize, n, mi);
					//System.Console.WriteLine($"n={n} | mi={mi} | p={p}");
					if (p > max)
						max = p;
				}

				//System.Console.WriteLine($"Max={max}");
				sumOfMaxes += max;
			}

			return sumOfMaxes;
		}

		public static BigInteger MaxPValue(int N, int n, int m)
		{
			var combination = QuickMath.Combination(N, n);
			var eulerian = QuickMath.EulerianTriangleNumber(n, m);
			return combination * eulerian; 
		}
	}
}
