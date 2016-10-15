using System;
using System.Threading;

namespace HackerRankEuler158
{
	public class Program
	{
		const int N = 26;
		static int[] _orderedAlphabet;

		static void InitAlphabet()
		{
			_orderedAlphabet = new int[N];
			for (int i = 0; i < N; i++)
				_orderedAlphabet[i] = i + 1;
		}

		static int pRecursive(int[] alphabet, int currentLength, int[] comparedCharacters, int m)
		{
			if (currentLength == 0)
				return isRightNeighbourBiggerThanLeftExactlyGivenTimes(comparedCharacters, m) ? 1 : 0;

			int sum = 0;
			for (int i = 0; i <= alphabet.Length - currentLength; i++)
			{
				//Write(comparedCharacters); Thread.Sleep(5);
				comparedCharacters[comparedCharacters.Length - currentLength] = alphabet[i];
				sum = sum + pRecursive(alphabet, currentLength - 1, comparedCharacters, m);
			}
			return sum;
		}

		static void Write(int[] comparedCharacters)
		{
			string chars = string.Join(" ", comparedCharacters);
			Console.WriteLine(chars);
		}

		static int p(int n, int m)
		{
			InitAlphabet();
			int[] comparedCharacters = new int[n];

			int sum = pRecursive(_orderedAlphabet, n, comparedCharacters, m);

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

		public static void Main(string[] args)
		{
			Console.WriteLine(p(3, 1));
		}
	}
}
