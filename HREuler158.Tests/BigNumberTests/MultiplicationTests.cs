using HackerRankEuler158;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HREuler158.Tests.BigNumberTests
{
	[TestClass]
	public class MultiplicationTests
	{
		[TestMethod]
		public void Multiply_OneDigit_CorrectMultiplication()
		{
			BigNumber left = new BigNumber(2);
			BigNumber right = new BigNumber(4);
			BigNumber result = left * right;

			Assert.AreEqual("8", result.Value);
		}

		[TestMethod]
		public void Multiply_OneDigit_CorrectMultiplicationResultingDoubleDigit()
		{
			BigNumber left = new BigNumber(8);
			BigNumber right = new BigNumber(9);
			BigNumber result = left * right;

			Assert.AreEqual("72", result.Value);
		}

		[TestMethod]
		public void Multiply_TwoDigit_CorrectMultiplicationResultingThreeDigits()
		{
			BigNumber left = new BigNumber(18);
			BigNumber right = new BigNumber(25);
			BigNumber result = left * right;

			Assert.AreEqual("450", result.Value);
		}

		[TestMethod]
		public void Multiply_TwoDigit_CorrectMultiplicationResultingFourDigits()
		{
			BigNumber left = new BigNumber(88);
			BigNumber right = new BigNumber(99);
			BigNumber result = left * right;

			Assert.AreEqual("8712", result.Value);
		}

		[TestMethod]
		public void Multiply_MixedDigitsFirstLonger_CorrectMultiplication()
		{
			BigNumber left = new BigNumber(987654);
			BigNumber right = new BigNumber(123);
			BigNumber result = left * right;

			Assert.AreEqual("121481442", result.Value);
		}

		[TestMethod]
		public void Multiply_MixedDigitsSecondLonger_CorrectMultiplication()
		{
			BigNumber left = new BigNumber(123);
			BigNumber right = new BigNumber(987654);
			BigNumber result = left * right;

			Assert.AreEqual("121481442", result.Value);
		}

		[TestMethod]
		public void Multiply_SixDigitNumbers_CorrectMultiplication()
		{
			BigNumber left = new BigNumber(987654);
			BigNumber right = new BigNumber(987654);
			BigNumber result = left * right;

			Assert.AreEqual("975460423716", result.Value);
		}
	}
}
