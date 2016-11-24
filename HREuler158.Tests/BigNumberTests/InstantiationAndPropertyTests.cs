using HackerRankEuler158;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HREuler158.Tests.BigNumberTests
{
	[TestClass]
	public class InstantiationAndPropertyTests
	{
		[TestMethod]
		public void Value_CopyConstructor_TakesSign()
		{
			BigNumber x = new BigNumber(new byte[] { 1, 2 }, true);
			BigNumber y = new BigNumber(x);

			Assert.AreEqual("-12", y.Value);
		}

		[TestMethod]
		public void Value_PositiveFromInt_UnsignedValue()
		{
			BigNumber x = new BigNumber(4);

			Assert.AreEqual("4", x.Value);
		}

		[TestMethod]
		public void Value_NegativeFromInt_ValueWithSign()
		{
			BigNumber x = new BigNumber(-88);

			Assert.AreEqual("-88", x.Value);
		}

		[TestMethod]
		public void Value_PositiveFromString_UnsignedValue()
		{
			BigNumber x = new BigNumber("44");

			Assert.AreEqual("44", x.Value);
		}

		[TestMethod]
		public void Value_NegativeFromString_ValueWithSign()
		{
			BigNumber x = new BigNumber("-288");

			Assert.AreEqual("-288", x.Value);
		}

		[TestMethod]
		public void Value_PositiveFromBytes_UnsignedValue()
		{
			BigNumber x = new BigNumber(new byte[] { 1, 2 });

			Assert.AreEqual("12", x.Value);
		}

		[TestMethod]
		public void Value_NegativeFromFromByte_ValueWithSign()
		{
			BigNumber x = new BigNumber(new byte[] { 9 }, true);

			Assert.AreEqual("-9", x.Value);
		}
	}
}
