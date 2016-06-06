using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
