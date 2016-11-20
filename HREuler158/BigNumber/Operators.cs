namespace HackerRankEuler158
{
	public partial class BigNumber
	{
		public static BigNumber operator + (BigNumber left, BigNumber right)
		{
			return left.Add(right);
		}

		public static BigNumber operator * (BigNumber left, BigNumber right)
		{
			return left.Multiply(right);
		}

		public static BigNumber operator ++ (BigNumber val)
		{
			BigNumber one = new BigNumber(1);
			return val.Add(one);
		}

		public static bool operator < (BigNumber left, BigNumber right)
		{
			if (left == right)
				return false;
			return LeftLessThanRight(left, right);
		}

		public static bool operator > (BigNumber left, BigNumber right)
		{
			if (left == right)
				return false;
			return !LeftLessThanRight(left, right);
		}

		public static bool operator == (BigNumber left, BigNumber right)
		{
			if (ReferenceEquals(left, right))
				return true;

			if (((object)left == null) || ((object)right == null))
				return false;

			return left.Equals(right);
		}

		public static bool operator != (BigNumber left, BigNumber right)
		{
			return !(left == right);
		}

		public static implicit operator BigNumber(int i)
		{
			return new BigNumber(i);
		}
	}
}
