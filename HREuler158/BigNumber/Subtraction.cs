using System.Linq;

namespace HackerRankEuler158
{
	public partial class BigNumber
	{
		private BigNumber Subtract(BigNumber number)
		{
			bool newSignNegative = !number._isNegative;

			BigNumber numberNegated = new BigNumber(number.ValueAsBytes.ToArray(), newSignNegative);
			return Add(numberNegated);
		}
	}
}
