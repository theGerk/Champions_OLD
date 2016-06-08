using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Standard
{
	public static class General
	{
		public static bool isDigitOnly(string input)
		{
			return input.All(char.IsDigit);
		}

		public static bool isDigitOnly(char input)
		{
			return char.IsDigit(input);
		}
	}
}

namespace Champions
{
	public static class General
	{
		public static BigInteger getPointsFromValue(BigInteger value, uint costPerPoint, int positiveModifier, int negitiveModifier, BigInteger baseValue, BigInteger BaseActivePoints, BigInteger maxima)
		{
			return 0;
		}

		public static BigInteger getValueFromCost(BigInteger points, uint costPerPoint, int positiveModifier, int negitiveModifier, BigInteger baseValue, BigInteger BaseActivePoints, BigInteger maxima)
		{
			return 0;
		}
	}
}