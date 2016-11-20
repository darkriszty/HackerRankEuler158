using HackerRankEuler158;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HREuler158.Tests.BigNumberTests
{
	[TestClass]
	public class AdditionTests
	{
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
	}
}
