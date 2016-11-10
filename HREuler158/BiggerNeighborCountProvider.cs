namespace HackerRankEuler158
{
	public class BiggerNeighborCountProvider
	{
		public int TotalRightNeighborsBiggerThanLeft(int[] comparedCharacters)
		{
			int times = 0;
			for (int i = 0; i < comparedCharacters.Length - 1; i++)
			{
				if (comparedCharacters[i + 1] > comparedCharacters[i])
					times++;
			}

			return times;
		}
	}
}
