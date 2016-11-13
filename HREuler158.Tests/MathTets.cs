using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankEuler158;

namespace HREuler158.Tests
{
	[TestClass]
	public class MathTets
	{
		[TestMethod]
		public void Factorial_10_3628800()
		{
			uint fact = HackerRankEuler158.Math.Factorial(10);

			Assert.AreEqual(3628800U, fact);
		}

		[TestMethod]
		public void Combination_Objects26Sample3_2600()
		{
			uint comb = HackerRankEuler158.Math.Combination(26, 3);

			Assert.AreEqual(2600U, comb);
		}

		[TestMethod]
		public void Combination_Objects26Sample17_2600()
		{
			uint comb = HackerRankEuler158.Math.Combination(26, 17);

			Assert.AreEqual(3124550U, comb);
		}
	}
}
