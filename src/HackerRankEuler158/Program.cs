using System;
using System.Threading;

namespace HackerRankEuler158
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var calculator = new CharsLexicographicallyAfterNeighborCalculator(26);
			Console.WriteLine(calculator.GetNumberOfStrings(3, 1));
		}
	}
}
