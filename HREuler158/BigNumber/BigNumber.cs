using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankEuler158
{
	public partial class BigNumber
	{
		private IEnumerable<byte> _innerValue;
		private bool _isNegative;

		public string Value
		{
			get
			{
				string sign = _isNegative ? "-" : string.Empty;
				string result = string.Concat(sign, string.Join(string.Empty, _innerValue).TrimStart('0'));
				return string.IsNullOrWhiteSpace(result)
					? "0"
					: result;
			}
		}

		internal IEnumerable<byte> ValueAsBytes
		{
			get { return _innerValue; }
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
			_isNegative = other._isNegative;
		}

		public BigNumber(byte[] values, bool isNegative = false)
		{
			_innerValue = values;
			_isNegative = isNegative;
		}

		private void InitValue(string number)
		{
			if (string.IsNullOrWhiteSpace(number)) throw new ArgumentException(nameof(number));
			_isNegative = number.StartsWith("-");
			int skip = _isNegative ? 1 : 0;
			_innerValue = number.Skip(skip).Select(x => byte.Parse(x.ToString()));
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

		public override string ToString()
		{
			return Value;
		}
	}
}
