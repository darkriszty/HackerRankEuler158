using System.Collections.Generic;

namespace HackerRankEuler158
{
	public static class Math
	{
		private static Dictionary<int, BigNumber> _factorials = new Dictionary<int, BigNumber>() { { 1, new BigNumber(1) } };

		public static uint Combination(int n, int k)
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
			BigNumber lastNominator = new BigNumber(nominatorAndsAtDifference ? nAndKDifference : k);

			BigNumber nominator = new BigNumber(1);
			for (BigNumber i = new BigNumber(n); i > lastNominator; i--)
				nominator = nominator * i;

			BigNumber denominator = nominatorAndsAtDifference
				? Factorial(k)
				: Factorial(nAndKDifference);

			return nominator / denominator;
		}

		public static BigNumber Factorial(int x)
		{
			if (_factorials.ContainsKey(x))
				return _factorials[x];

			BigNumber fact = new BigNumber(x) * Factorial(x - 1);

			_factorials[x] = fact;
			return fact;
		}
	}
}
