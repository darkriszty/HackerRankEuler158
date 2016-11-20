using System.Collections.Generic;
using System.Linq;

namespace HackerRankEuler158
{
	public partial class BigNumber
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
	}
}
