using System.Collections.Generic;

namespace HackerRankEuler158
{
	public static class Math
	{
		private static Dictionary<int, uint> _factorials = new Dictionary<int, uint>() { { 1, 1U } };

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
			int lastNominator = nominatorAndsAtDifference ? nAndKDifference : k;

			uint nominator = 1;
			for (int i = n; i > lastNominator; i--)
				nominator = nominator * (uint)i;

			uint denominator = nominatorAndsAtDifference
				? Factorial(k)
				: Factorial(nAndKDifference);

			return nominator / denominator;
		}

		public static uint Factorial(int x)
		{
			if (_factorials.ContainsKey(x))
				return _factorials[x];

			uint fact = (uint)x * Factorial(x - 1);

			_factorials[x] = fact;
			return fact;
		}
	}
}
