using HackerRankEuler158;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HREuler158.Tests
{
	[TestClass]
	public class BigNumberTests
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
			BigNumber left  = new BigNumber("11111111111111111111");
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

		[TestMethod]
		public void Add_OneDigit_CorrectAddition()
		{
			BigNumber left = new BigNumber(4);
			BigNumber right = new BigNumber(5);
			BigNumber result = left + right;

			Assert.AreEqual("9", result.Value);
		}

		[TestMethod]
		public void Add_TwoDigit_CorrectAddition()
		{
			BigNumber left = new BigNumber(11);
			BigNumber right = new BigNumber(11);
			BigNumber result = left + right;

			Assert.AreEqual("22", result.Value);
		}

		[TestMethod]
		public void Add_OneDigitWithCarry_CorrectAddition()
		{
			BigNumber left = new BigNumber(9);
			BigNumber right = new BigNumber(8);
			BigNumber result = left + right;

			Assert.AreEqual("17", result.Value);
		}

		[TestMethod]
		public void Add_FirstNumberLongerWithCarry_CorrectAddition()
		{
			BigNumber left = new BigNumber(999);
			BigNumber right = new BigNumber(88);
			BigNumber result = left + right;

			Assert.AreEqual("1087", result.Value);
		}

		[TestMethod]
		public void Add_SecondNumberLongerWithCarry_CorrectAddition()
		{
			BigNumber left = new BigNumber(88);
			BigNumber right = new BigNumber(999);
			BigNumber result = left + right;

			Assert.AreEqual("1087", result.Value);
		}

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
