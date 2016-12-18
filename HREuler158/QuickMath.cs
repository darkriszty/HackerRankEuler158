using System.Collections.Generic;
using System.Numerics;

namespace HackerRankEuler158
{
	public static class QuickMath
	{
		private static Dictionary<int, BigInteger> _factorials = new Dictionary<int, BigInteger>() { { 0, new BigInteger(1) } };
		private static Dictionary<string, BigInteger> _eularians = new Dictionary<string, BigInteger>()
		{
			{ "0|0", new BigInteger(1) },
			{ "1|0", new BigInteger(1) },
			{ "2|0", new BigInteger(1) },
			{ "2|1", new BigInteger(1) },
			{ "3|0", new BigInteger(1) },
			{ "3|1", new BigInteger(4) },
			{ "3|2", new BigInteger(1) },
		};

		/// <summary>
		/// Gets the Eulerian number from Euler's triangle.
		/// </summary>
		public static BigInteger EulerianTriangleNumber(int n, int m)
		{
			// triangle diagonal and above
			if (m >= n) return 0;
			// just below triangle diagonal
			if (n == m + 1) return 1;
			// first column
			if (m == 0) return 1;

			string key = $"{n}|{m}";
			if (_eularians.ContainsKey(key))
				return _eularians[key];

			var result = (n-m)*EulerianTriangleNumber(n-1, m-1) + (m+1)*EulerianTriangleNumber(n-1, m);
			_eularians[key] = result;
			return result;
		}

		public static BigInteger Combination(int n, int k)
		{
			//     n!     
			// ---------- 
			//  k!(n-k)!  
			//
			//   3    26!     26*25*24*23!   26*25*24
			// C  = ------- = ------------ = --------
			//  26   3!23!       3!*23!          3!
			// 
			//   17    26!      26*25*24*23*22*21*20*19*18*17!     26*25*24*23*22*21*20*19*18
			// C   = ------- = -------------------------------- = ----------------------------
			//   26   17!9!                17!*9!                              9!

			if (k > n)
				return 0;
			
			int nAndKDifference = n - k;
			bool nominatorAndsAtDifference = nAndKDifference > k;
			int lastNominator = nominatorAndsAtDifference ? nAndKDifference : k;

			BigInteger nominator = new BigInteger(1);
			for (int i = n; i > lastNominator; i--)
				nominator = nominator * i;

			BigInteger denominator = nominatorAndsAtDifference
				? Factorial(k)
				: Factorial(nAndKDifference);

			return nominator / denominator;
		}

		public static BigInteger Factorial(int x)
		{
			if (_factorials.ContainsKey(x))
				return _factorials[x];

			BigInteger fact = new BigInteger(x) * Factorial(x - 1);

			_factorials[x] = fact;
			return fact;
		}
	}
}
