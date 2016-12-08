using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace HREuler158.Tests
{
	[TestClass]
	public class QuickMathTets
	{
		[TestMethod]
		public void Factorial_23_1124000727777607680000()
		{
			BigInteger fact = HackerRankEuler158.QuickMath.Factorial(22);

			Assert.AreEqual("1124000727777607680000", fact.ToString());
		}


		[TestMethod]
		public void Combination_Objects26Sample3_2600()
		{
			BigInteger comb = HackerRankEuler158.QuickMath.Combination(26, 3);

			Assert.AreEqual(2600, comb);
		}

		[TestMethod]
		public void Combination_Objects26Sample17_2600()
		{
			BigInteger comb = HackerRankEuler158.QuickMath.Combination(26, 17);

			Assert.AreEqual(3124550, comb);
		}

		[TestMethod]
		public void EulerianNumber_33_8589934558()
		{
			double comb = HackerRankEuler158.QuickMath.EulerianTriangleColumnTwoNumber(33);

			Assert.AreEqual(8589934558, comb);
		}
	}
}
