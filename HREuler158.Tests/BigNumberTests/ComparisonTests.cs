using HackerRankEuler158;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HREuler158.Tests.BigNumberTests
{
	[TestClass]
	public class ComparisonTests
	{
		[TestMethod]
		public void LessAndGreater_OneDigit_LeftLTRight()
		{
			BigNumber left = new BigNumber(4);
			BigNumber right = new BigNumber(5);
			bool leftLessThanRight = left < right;
			bool leftGreaterThanRight = left > right;

			Assert.AreEqual(true, leftLessThanRight);
			Assert.AreEqual(false, leftGreaterThanRight);
		}

		[TestMethod]
		public void LessAndGreater_TwoDigit_LeftLTRight()
		{
			BigNumber left = new BigNumber(33);
			BigNumber right = new BigNumber(99);
			bool leftLessThanRight = left < right;
			bool leftGreaterThanRight = left > right;

			Assert.AreEqual(true, leftLessThanRight);
			Assert.AreEqual(false, leftGreaterThanRight);
		}

		[TestMethod]
		public void LessAndGreater_MixedDigitSecondLonger_LeftGTRight()
		{
			BigNumber left = new BigNumber(333);
			BigNumber right = new BigNumber(4564567);
			bool leftLessThanRight = left < right;
			bool leftGreaterThanRight = left > right;

			Assert.AreEqual(true, leftLessThanRight);
			Assert.AreEqual(false, leftGreaterThanRight);
		}

		[TestMethod]
		public void LessAndGreater_MixedDigitFirstLonger_LeftLTRight()
		{
			BigNumber left = new BigNumber("8797987899");
			BigNumber right = new BigNumber(456456);
			bool leftLessThanRight = left < right;
			bool leftGreaterThanRight = left > right;

			Assert.AreEqual(false, leftLessThanRight);
			Assert.AreEqual(true, leftGreaterThanRight);
		}

		[TestMethod]
		public void LessAndGreater_LongEqualDigits_LeftEQRight()
		{
			BigNumber left = new BigNumber("11111111111111111111");
			BigNumber right = new BigNumber("11111111111111111111");
			bool leftLessThanRight = left < right;
			bool leftGreaterThanRight = left > right;

			Assert.AreEqual(false, leftLessThanRight);
			Assert.AreEqual(false, leftGreaterThanRight);
		}

		[TestMethod]
		public void LessAndGreater_TwoDigit_LeftEQRight()
		{
			BigNumber left = new BigNumber(73);
			BigNumber right = new BigNumber(73);
			bool leftLessThanRight = left < right;
			bool leftGreaterThanRight = left > right;

			Assert.AreEqual(false, leftLessThanRight);
			Assert.AreEqual(false, leftGreaterThanRight);
		}
	}
}
