using System;
using System.Linq;

namespace HackerRankEuler158
{
	public class Utils
	{
		public static void Swap<T>(ref T lhs, ref T rhs)
		{
			T temp;
			temp = lhs;
			lhs = rhs;
			rhs = temp;
		}

		public static Tuple<byte[], byte[], int> PrepareForAddition(BigNumber lhs, BigNumber rhs)
		{
			byte[] left = lhs.ValueAsBytes.ToArray();
			byte[] right = rhs.ValueAsBytes.ToArray();

			int maxLength = System.Math.Max(left.Length, right.Length);

			left = PadZero(left, maxLength);
			right = PadZero(right, maxLength);

			return Tuple.Create(left, right, maxLength);
		}

		public static byte[] PadZero(byte[] arrayToPad, int maxLength)
		{
			if (arrayToPad.Length < maxLength)
			{
				byte[] newLeft = new byte[maxLength];
				int startAt = newLeft.Length - arrayToPad.Length;
				Buffer.BlockCopy(arrayToPad, 0, newLeft, startAt, arrayToPad.Length);
				return newLeft;
			}

			return arrayToPad;
		}
	}
}
