using System.Diagnostics;

namespace HackerRankEuler158
{
	public class Program
	{
		// https://www.hackerrank.com/contests/projecteuler/challenges/euler158
		public static void Main(string[] args)
		{
			/* Input example
			 * 2 2
			 * 0 1
			 * Result: 3
			 */
			Stopwatch sw = Stopwatch.StartNew();
			var controller = new ProblemSolvingController();
			controller.Solve();
			sw.Stop();
			System.Console.WriteLine($"Duration: {sw.Elapsed.TotalSeconds} seconds.");
		}
	}
}
