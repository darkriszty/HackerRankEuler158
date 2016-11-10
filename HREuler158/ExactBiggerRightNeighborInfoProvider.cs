using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankEuler158
{
	public class ExactBiggerRightNeighborInfoProvider
	{
		private const int CACHE_SIZE = 1000000;
		private Dictionary<string, int> _cache = new Dictionary<string, int>(CACHE_SIZE);
		private readonly BiggerNeighborCountProvider _exactCountProvider;

		public ExactBiggerRightNeighborInfoProvider(BiggerNeighborCountProvider source)
		{
			_exactCountProvider = source;
		}

		public bool IsRightNeighbourBiggerThanLeftExactlyGivenTimes(int[] comparedCharacters, int exactlyHowManyTimes)
		{
			int sum = GetSum(comparedCharacters);
			return sum == exactlyHowManyTimes;
		}

		private int GetSum(int[] comparedCharacters)
		{
			int half = comparedCharacters.Length / 2;
			var pieces = new int[2][];
			pieces[0] = comparedCharacters.Take(half).ToArray();
			pieces[1] = comparedCharacters.Skip(half).ToArray();

			int sum = 0;

			if (half <= 3)
			{
				foreach (var piece in pieces)
				{
					string cacheKey = GetCacheKey(piece);
					int totalRightNeighborsBiggerThanLeft = 0;

					if (_cache.ContainsKey(cacheKey))
					{
						totalRightNeighborsBiggerThanLeft = _cache[cacheKey];
					}
					else
					{
						totalRightNeighborsBiggerThanLeft = _exactCountProvider.TotalRightNeighborsBiggerThanLeft(piece);
						_cache[cacheKey] = totalRightNeighborsBiggerThanLeft;
					}

					sum += totalRightNeighborsBiggerThanLeft;
				}
			}
			else
			{
				foreach (var piece in pieces)
				{
					sum += GetSum(piece);
				}
			}

			return sum;
		}


		private string GetCacheKey(IEnumerable<int> comparedCharacters)
		{
			return string.Join("|", comparedCharacters);
		}
	}
}
