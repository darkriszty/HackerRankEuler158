using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRankEuler158
{
	public class Program
	{
		const int N = 26;
		static int[] orderedAlphabet;

		static void initAlphabet()
		{
			orderedAlphabet = new int[N];
			for (int i = 0; i < N; i++)
				orderedAlphabet[i] = i + 1;
		}

		static int p(int n, int m)
		{
			int sum = 0;

			int[] comparedCharacters = new int[n];

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					for (int k = 0; k < N; k++)
					{
						comparedCharacters[0] = i;
						comparedCharacters[1] = j;
						comparedCharacters[2] = k;

						if (!allDistinct(comparedCharacters))
							continue;

						if (isRightNeighbourBiggerThanLeftExactlyGivenTimes(comparedCharacters, m))
						{
							sum++;
							Console.WriteLine($"BINGO {i} {j} {k}");
						}
					}
				}
			}
			return sum;
		}

		static bool isRightNeighbourBiggerThanLeftExactlyGivenTimes(int[] comparedCharacters, int howManyTimes)
		{
			int times = 0;
			for (int i = 0; i < comparedCharacters.Length - 1; i++)
			{
				if (comparedCharacters[i + 1] > comparedCharacters[i])
					times++;
				// small optimization: no need to count further if it's already exceeded
				if (times > howManyTimes)
					break;
			}

			return times == howManyTimes;
		}

		static bool allDistinct(int[] comparedCharacters)
		{
			return comparedCharacters.Distinct().Count() == comparedCharacters.Count();
		}

		//8875
		public static void Main(string[] args)
		{
			Console.WriteLine(p(3, 1));
		}
	}
}
