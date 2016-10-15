﻿using System;

namespace HackerRankEuler158
{
	public class CharsLexicographicallyAfterNeighborCalculator
	{
		private readonly int _alphabetSize;
		private int[] _orderedAlphabet;

		public CharsLexicographicallyAfterNeighborCalculator(int alphabetSize)
		{
			if (alphabetSize < 2 || alphabetSize > 700) throw new ArgumentOutOfRangeException(nameof(alphabetSize));

			_alphabetSize = alphabetSize;
		}

		/// <summary>
		/// Get the number of strings of length <paramref name="n"/> where exactly <paramref name="m"/> 
		/// characters come lexicographically after their neighbours to the left.
		/// </summary>
		/// <param name="n">The string lenghts to generate/check.</param>
		/// <param name="m">The number of characters that come lexicographically after their neighbors to the left.</param>
		public int GetNumberOfStrings(int n, int m)
		{
			InitAlphabet();
			int[] comparedCharacters = new int[n];

			int sum = GetNumberOfStringsRecursive(_orderedAlphabet, n, comparedCharacters, m);

			return sum;
		}

		private int GetNumberOfStringsRecursive(int[] alphabet, int currentLength, int[] comparedCharacters, int m)
		{
			if (currentLength == 0)
				return IsRightNeighbourBiggerThanLeftExactlyGivenTimes(comparedCharacters, m) ? 1 : 0;

			int sum = 0;
			for (int i = 0; i <= alphabet.Length - currentLength; i++)
			{
				comparedCharacters[comparedCharacters.Length - currentLength] = alphabet[i];
				sum = sum + GetNumberOfStringsRecursive(alphabet, currentLength - 1, comparedCharacters, m);
			}
			return sum;
		}

		private void InitAlphabet()
		{
			_orderedAlphabet = new int[_alphabetSize];
			for (int i = 0; i < _alphabetSize; i++)
				_orderedAlphabet[i] = i + 1;
		}

		private bool IsRightNeighbourBiggerThanLeftExactlyGivenTimes(int[] comparedCharacters, int exactlyHowManyTimes)
		{
			int times = 0;
			for (int i = 0; i < comparedCharacters.Length - 1; i++)
			{
				if (comparedCharacters[i + 1] > comparedCharacters[i])
					times++;
				// small optimization: no need to count further if it already exceeded the required exact amount
				if (times > exactlyHowManyTimes)
					break;
			}

			return times == exactlyHowManyTimes;
		}
	}
}
