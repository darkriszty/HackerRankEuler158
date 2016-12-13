using System.Numerics;

namespace HackerRankEuler158
{
	public static class Calculator
	{
		public static BigInteger MaxPValue(int N, int n, int m)
		{
			var combination = QuickMath.Combination(N, n);
			var eulerian = QuickMath.EulerianTriangleNumber(n, m);
			return combination * eulerian; 
		}
	}
}
