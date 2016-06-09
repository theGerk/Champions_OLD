using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions
{
	namespace Modifier
	{
		abstract public class Modifier : ChampionsBaseClass
		{
			abstract public string Name { get; }

			abstract public string Description { get; }

			abstract public decimal Amount { get; }
		}

		abstract public class Advantage : Modifier
		{ }

		abstract public class Limitation : Modifier
		{ }
	}
}
