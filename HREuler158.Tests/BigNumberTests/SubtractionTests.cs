using HackerRankEuler158;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HREuler158.Tests.BigNumberTests
{
	[TestClass]
	public class SubtractionTests
	{
		[TestMethod]
		public void Subtract_OneDigit_CorrectSubtraction()
		{
			BigNumber left = new BigNumber(5);
			BigNumber right = new BigNumber(4);
			BigNumber result = left - right;

			Assert.AreEqual("1", result.Value);
		}

		[TestMethod]
		public void Subtract_OneDigit_CorrectNegativeSubtraction()
		{
			BigNumber left = new BigNumber(3);
			BigNumber right = new BigNumber(5);
			BigNumber result = left - right;

			Assert.AreEqual("-2", result.Value);
		}

		[TestMethod]
		public void Subtract_TwoDigit_CorrectSubtraction()
		{
			BigNumber left = new BigNumber(11);
			BigNumber right = new BigNumber(11);
			BigNumber result = left - right;

			Assert.AreEqual("0", result.Value);
		}

		[TestMethod]
		public void Subtract_OneDigitWithCarry_CorrectSubtraction()
		{
			BigNumber left = new BigNumber(18);
			BigNumber right = new BigNumber(9);
			BigNumber result = left - right;

			Assert.AreEqual("9", result.Value);
		}

		[TestMethod]
		public void Subtract_OneDigitWithCarry_CorrectNegativeSubtraction()
		{
			BigNumber left = new BigNumber(9);
			BigNumber right = new BigNumber(18);
			BigNumber result = left - right;

			Assert.AreEqual("-9", result.Value);
		}

		[TestMethod]
		public void Subtract_FirstNumberWithoutCarry_CorrectSubtraction()
		{
			BigNumber left = new BigNumber(999);
			BigNumber right = new BigNumber(88);
			BigNumber result = left - right;

			Assert.AreEqual("911", result.Value);
		}

		[TestMethod]
		public void Subtract_SecondNumberLongerWithCarry_CorrectNegativeSubtraction()
		{
			BigNumber left = new BigNumber(88);
			BigNumber right = new BigNumber(999);
			BigNumber result = left - right;

			Assert.AreEqual("-911", result.Value);
		}

		[TestMethod]
		public void Subtract_SecondNumberNegative_CorrectAddition()
		{
			BigNumber left = new BigNumber(88);
			BigNumber right = new BigNumber(-9999);
			BigNumber result = left - right;

			Assert.AreEqual("10087", result.Value);
		}
	}
}
