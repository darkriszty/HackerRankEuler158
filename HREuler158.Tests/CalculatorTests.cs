using HackerRankEuler158;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HREuler158.Tests
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void P_1And0_2()
		{
			var p = Calculator.P(1, 0);

			Assert.AreEqual(2, p);
		}
	}
}
