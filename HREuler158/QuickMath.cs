using System;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRankEuler158
{
	public static class QuickMath
	{
		private static Dictionary<int, BigInteger> _factorials = new Dictionary<int, BigInteger>() { { 0, new BigInteger(1) } };

		/// <summary>
		/// Gets the Eulerian number from Euler's triangle for column = 2.
		/// </summary>
		public static double EulerianTriangleColumnTwoNumber(int n)
		{
			// formula from http://mathworld.wolfram.com/EulerianNumber.html: Special cases are given by < n; 1 > = 2 ^ n - n - 1
			return Math.Pow(2, n) - n - 1;
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
