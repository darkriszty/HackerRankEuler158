namespace HackerRankEuler158
{
	public partial class BigNumber
	{
		private BigNumber Add(BigNumber number)
		{
			var normalized = Utils.PrepareForAddition(this, number);
			byte[] left = normalized.Item1;
			byte[] right = normalized.Item2;
			int maxLength = normalized.Item3;


			int n = maxLength + 1;
			byte[] result = new byte[n];

			byte lastCarry = 0;
			for (int i = left.Length - 1; i >= 0; i--)
			{
				byte digitSum = (byte)(left[i] + right[i] + lastCarry);
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
