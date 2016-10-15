namespace HackerRankEuler158
{
	public class SumMaxMValueCalculator
    {
		private readonly CharsLexicographicallyAfterNeighborCalculator _calculator;

		public SumMaxMValueCalculator(CharsLexicographicallyAfterNeighborCalculator calculator)
		{
			_calculator = calculator;
		}

		public int GetValue(ProblemInputModel input)
		{
			int sum = 0;
			for (int n = 1; n <= input.AlphabetSize; n++)
			{
				int maxForM = 0;
				foreach (int m in input.NumberOfCharactersLexicographicallyComingAfterNeighbours)
				{
					int newMValue = _calculator.GetNumberOfStrings(n, m);
					if (newMValue > maxForM)
						maxForM = newMValue;
				}
				sum += maxForM;
			}
			return sum;
		}
    }
}
