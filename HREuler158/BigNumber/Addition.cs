using System;
using System.Linq;

namespace HackerRankEuler158
{
	public partial class BigNumber
	{
		private BigNumber Add(BigNumber number)
		{
			byte[] longer = _innerValue.ToArray();
			byte[] shorter = number._innerValue.ToArray();
			if (longer.Length < shorter.Length)
				Utils.Swap(ref longer, ref shorter);

			int n = longer.Length + 1;
			byte[] shorterPadded = new byte[longer.Length];
			int startAt = shorterPadded.Length - shorter.Length;
			Buffer.BlockCopy(shorter, 0, shorterPadded, startAt, shorter.Length);

			byte[] result = new byte[n];

			byte lastCarry = 0;
			for (int i = longer.Length - 1; i >= 0; i--)
			{
				byte digitSum = (byte)(longer[i] + shorterPadded[i] + lastCarry);
				byte resultDigit = 0;
				byte carry = 0;

				if (digitSum > 9)
				{
					resultDigit = (byte)(digitSum % 10);
					carry = 1;
				}
				else
				{
					resultDigit = digitSum;
				}

				result[--n] = resultDigit;

				lastCarry = carry;
			}
			if (lastCarry > 0)
				result[0] = lastCarry;
			return new BigNumber(result);
		}
	}
}
