using System;
using System.Diagnostics;
using System.Numerics;

namespace HackerRankEuler158
{
	public class Controller
	{
		public void Solve()
		{
			var input = new InputReader().ReadInput(Console.In);

			Stopwatch sw = Stopwatch.StartNew();
			BigInteger sum = Calculator.SumOfMaxes(input);
			sw.Stop();

			Console.WriteLine(sum);
			Console.WriteLine($"Duration: {sw.Elapsed.TotalSeconds} seconds.");
		}
	}
}
