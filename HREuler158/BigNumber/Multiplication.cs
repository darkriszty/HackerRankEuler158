using System.Collections.Generic;

namespace HackerRankEuler158
{
	public partial class BigNumber
	{
		private BigNumber Multiply(BigNumber right)
		{
			if (this < 10 && right < 10)
				return new BigNumber(int.Parse(this.Value) * int.Parse(right.Value));

			List<BigNumber> numbersToAdd = new List<BigNumber>();

			string lVal = this.Value;
			string rVal = right.Value;

			int outerIterationCount = 0;
			for (int i = rVal.Length - 1; i >= 0; i--)
			{
				byte[] resultOfLoop = new byte[lVal.Length + 1 + outerIterationCount];

				int carry = 0;
				int innerIterationCount = 0;
				for (int j = lVal.Length - 1; j >= 0; j--)
				{
					int multiplyResult = byte.Parse(lVal[j].ToString()) * byte.Parse(rVal[i].ToString());
					int multiplyResultWithCarry = multiplyResult + carry;
					int oneResultDigit = multiplyResultWithCarry % 10;
					resultOfLoop[resultOfLoop.Length - 1 - outerIterationCount - innerIterationCount] = (byte)oneResultDigit;

					carry = multiplyResultWithCarry / 10;
					innerIterationCount++;
				}
				if (carry > 0)
					resultOfLoop[resultOfLoop.Length - 1 - outerIterationCount - innerIterationCount] = (byte)carry;
				outerIterationCount++;
				numbersToAdd.Add(new BigNumber(resultOfLoop));
			}

			BigNumber result = new BigNumber(0);
			foreach (var b in numbersToAdd)
				result += b;
			return result;
		}
	}
}
