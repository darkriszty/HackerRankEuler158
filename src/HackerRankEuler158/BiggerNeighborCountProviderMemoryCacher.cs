using System.Collections.Generic;

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
			string cacheKey = GetCacheKey(comparedCharacters);
			int totalRightNeighborsBiggerThanLeft = 0;

			if (_cache.ContainsKey(cacheKey))
			{
				totalRightNeighborsBiggerThanLeft = _cache[cacheKey];
				return totalRightNeighborsBiggerThanLeft;
			}

			totalRightNeighborsBiggerThanLeft = _source.TotalRightNeighborsBiggerThanLeft(comparedCharacters);
			_cache[cacheKey] = totalRightNeighborsBiggerThanLeft;
			return totalRightNeighborsBiggerThanLeft;
		}

		private string GetCacheKey(int[] comparedCharacters)
		{
			return string.Join("", comparedCharacters);
		}
	}
}
