﻿using System.IO;
using System.Linq;

namespace HackerRankEuler158
{
	public class InputReader
	{
		public ProblemInputModel ReadInput(TextReader reader)
		{
			ProblemInputModel result = null;
			while (result == null)
			{
				result = ReadInputInner(reader);
			}
			return result;
		}

		private ProblemInputModel ReadInputInner(TextReader reader)
		{
			// read N and q from the first line
			string[] firstLine = reader.ReadLine().Split(' ');
			if (firstLine.Length != 2)
				return null;

			int alphabetSize = int.Parse(firstLine[0]);
			int numberOfQueries = int.Parse(firstLine[1]);

			// read q numbers from the next line
			string[] secondLine = reader.ReadLine().Split(' ');
			if (secondLine.Length != numberOfQueries)
				return null;

			int[] mValues = secondLine.Select(str => int.Parse(str)).ToArray();

			return new ProblemInputModel
			{
				AlphabetSize = alphabetSize,
				NumberOfQueries = numberOfQueries,
				NumberOfCharactersLexicographicallyComingAfterNeighbours = mValues
			};
		}
	}
}
