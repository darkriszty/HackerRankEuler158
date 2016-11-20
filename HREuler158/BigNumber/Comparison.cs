namespace HackerRankEuler158
{
	public partial class BigNumber
	{
		private static bool LeftLessThanRight(BigNumber left, BigNumber right)
		{
			string leftVal = left.Value;
			string rightVal = right.Value;
			if (leftVal.Length < rightVal.Length)
				return true;

			if (leftVal.Length > rightVal.Length)
				return false;

			for (int i = 0; i < leftVal.Length; i++)
			{
				byte leftByte = byte.Parse(leftVal[i].ToString());
				byte rightByte = byte.Parse(rightVal[i].ToString());

				if (leftByte < rightByte)
					return true;
			}

			return false;
		}
	}
}
