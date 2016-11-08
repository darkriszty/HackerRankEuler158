using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankEuler158
{
	public class BiggerNeighborCountProviderMemoryCacher : IBiggerNeighborCountProvider
	{
		private const int CACHE_SIZE = 1000000;
		private Dictionary<string, int> _cache = new Dictionary<string, int>(CACHE_SIZE);
		private readonly IBiggerNeighborCountProvider _source;

		public BiggerNeighborCountProviderMemoryCacher(IBiggerNeighborCountProvider source)
		{
			_source = source;
		}

		public int TotalRightNeighborsBiggerThanLeft(int[] comparedCharacters)
		{
			int piecesLength = (int)Math.Ceiling((decimal)comparedCharacters.Length / 3);
			var pieces = Split(comparedCharacters, piecesLength);
			int sum = 0;
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
					totalRightNeighborsBiggerThanLeft = _source.TotalRightNeighborsBiggerThanLeft(piece);

					// don't add everything into memory
					if (piece.Length % 3 == 0)
						_cache[cacheKey] = totalRightNeighborsBiggerThanLeft;
				}

				sum += totalRightNeighborsBiggerThanLeft;
			}

			return sum;
		}

		private IEnumerable<int[]> Split(int[] comparedCharacters, int size)
		{
			for (var i = 0; i < (float)comparedCharacters.Length / size; i++)
				yield return comparedCharacters.Skip(i * size).Take(size).ToArray();
		}

		private string GetCacheKey(int[] comparedCharacters)
		{
			return string.Join("", comparedCharacters);
		}
	}
}
