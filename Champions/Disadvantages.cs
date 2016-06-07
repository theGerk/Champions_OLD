using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions
{
	public abstract class Disadvantage : ChampionsBaseClass
	{
		public abstract int Points { get; }
	}
}
