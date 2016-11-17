using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankEuler158
{
	public class BigNumber
	{
		private IEnumerable<byte> _innerValue;

		public string Value
		{
			get { return string.Join(string.Empty, _innerValue).TrimStart('0'); }
		}

		public BigNumber(int number)
		{
			InitValue(number.ToString());
		}

		public BigNumber(string number)
		{
			InitValue(number);
		}

		public BigNumber(BigNumber other)
		{
			_innerValue = other._innerValue;
		}

		public BigNumber(byte[] values)
		{
			_innerValue = values;
		}

		private void InitValue(string number)
		{
			_innerValue = number.Select(x => byte.Parse(x.ToString()));
		}
		private void InitValue(byte[] numbers)
		{
			_innerValue = numbers.AsEnumerable();
		}

		public static BigNumber operator + (BigNumber left, BigNumber right)
		{
			return left.Add(right);
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

		public static BigNumber operator * (BigNumber left, BigNumber right)
		{
			BigNumber smaller = left;
			BigNumber bigger = right;
			if (smaller > bigger)
				Swap(ref smaller, ref bigger);

			BigNumber productSum = new BigNumber(0);
			for (BigNumber i = new BigNumber(0); i < smaller; i++)
				productSum += bigger;

			return productSum;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;

			BigNumber b = obj as BigNumber;
			if ((System.Object)b == null)
				return false;

			return this.Equals(b);
		}

		public bool Equals(BigNumber b)
		{
			if ((object)b == null)
				return false;

			return string.Compare(Value, b.Value) == 0;
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		private BigNumber Add(BigNumber number)
		{
			byte[] longer = _innerValue.ToArray();
			byte[] shorter = number._innerValue.ToArray();
			if (longer.Length < shorter.Length)
				Swap(ref longer, ref shorter);

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

		private static void Swap<T>(ref T lhs, ref T rhs)
		{
			T temp;
			temp = lhs;
			lhs = rhs;
			rhs = temp;
		}
	}
}
