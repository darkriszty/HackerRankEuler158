using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankEuler158
{
	public static class Calculator
	{
		public static BigInteger P(int n, int m)
		{
			var combination = QuickMath.Combination(n, m);
			var eulerian = new BigInteger(QuickMath.EulerianTriangleColumnTwoNumber(n));
			return combination * eulerian; 
		}
	}
}
