using HackerRankEuler158;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HREuler158.Tests.BigNumberTests
{
	[TestClass]
	public class AdditionTests
	{
		[TestMethod]
		public void Add_ZeroPlusZero_Zero()
		{
			BigNumber left = new BigNumber(0);
			BigNumber right = new BigNumber(0);
			BigNumber result = left + right;

			Assert.AreEqual("0", result.Value);
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
		public void Add_FirstNumberNegative_ResultPositive()
		{
			BigNumber left = new BigNumber(-8);
			BigNumber right = new BigNumber(9);
			BigNumber result = left + right;

			Assert.AreEqual("1", result.Value);
		}

		[TestMethod]
		public void Add_SecondNumberNegative_ResultPositive()
		{
			BigNumber left = new BigNumber(8);
			BigNumber right = new BigNumber(-7);
			BigNumber result = left + right;

			Assert.AreEqual("1", result.Value);
		}

		[TestMethod]
		public void Add_FirstNumberNegative_ResultNegative()
		{
			BigNumber left = new BigNumber(-8);
			BigNumber right = new BigNumber(12);
			BigNumber result = left + right;

			Assert.AreEqual("-4", result.Value);
		}

		[TestMethod]
		public void Add_SecondNumberNegative_ResultNegative()
		{
			BigNumber left = new BigNumber(8);
			BigNumber right = new BigNumber(-10);
			BigNumber result = left + right;

			Assert.AreEqual("-2", result.Value);
		}

		[TestMethod]
		public void Add_BothNegative_ResultNegative()
		{
			BigNumber left = new BigNumber(-98);
			BigNumber right = new BigNumber(-89);
			BigNumber result = left + right;

			Assert.AreEqual("-187", result.Value);
		}

		[TestMethod]
		public void Add_FirstNumberNegative_ResultZero()
		{
			BigNumber left = new BigNumber(-8);
			BigNumber right = new BigNumber(8);
			BigNumber result = left + right;

			Assert.AreEqual("0", result.Value);
		}

		[TestMethod]
		public void Add_SecondNumberNegative_ResultZero()
		{
			BigNumber left = new BigNumber(10);
			BigNumber right = new BigNumber(-10);
			BigNumber result = left + right;

			Assert.AreEqual("0", result.Value);
		}
	}
}
