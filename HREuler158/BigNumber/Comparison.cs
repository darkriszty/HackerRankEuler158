namespace HackerRankEuler158
{
	public partial class BigNumber
	{
		private static bool LeftLessThanRight(BigNumber left, BigNumber right)
		{
			string leftVal = string.Join(string.Empty, left.ValueAsBytes);
			string rightVal = string.Join(string.Empty, right.ValueAsBytes);

			bool bothNegative = left._isNegative && right._isNegative;

			if (left._isNegative && !right._isNegative)
				return true;
			if (!left._isNegative && right._isNegative)
				return false;

			if (leftVal.Length < rightVal.Length)
			{
				if (bothNegative)
					return false;
				else
					return true;
			}
			if (leftVal.Length > rightVal.Length)
			{
				if (bothNegative)
					return true;
				else
					return false;
			}

			for (int i = 0; i < leftVal.Length; i++)
			{
				byte leftByte = byte.Parse(leftVal[i].ToString());
				byte rightByte = byte.Parse(rightVal[i].ToString());

				if (bothNegative && leftByte < rightByte)
					return false;
				else if (leftByte < rightByte)
					return true;
			}

			return false;
		}
	}
}
