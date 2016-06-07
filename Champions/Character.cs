using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Champions.Modifier;

namespace Champions
{
	public class Character : ChampionsBaseClass
	{
		public BigInteger BasePoints { get; set; }

		public BigInteger MaximumDisadvantagePoints { get; set; }

		public BigInteger PointsEarned { get; set; }

		public List<ExternalPointAllocator> PointsSpentExternally { get; set; }

		public Characteristics Characteristics { get; set; }

		public List<Disadvantage> Disadvantages { get; set; }
	}



	public struct Characteristics
	{
	}

	public class ExternalPointAllocator : ChampionsBaseClass
	{
		public ExternalPointAllocator(string whatTo)
		{ WhatTo = whatTo; }
		public ExternalPointAllocator(BigInteger points, string whatTo)
		{ PointsAllocated = points; WhatTo = whatTo; }

		public BigInteger PointsAllocated { get; set; }

		public string WhatTo { get; set; }
	}
	
	abstract public class PowerBase : ChampionsBaseClass
	{
		public string Name { get; set; }

		public string Explanation { get; set; }

		public abstract int RealCost { get; set; }

		public List<Advantage> Advantages { get; set; }

		public List<Limitation> Limitations { get; set; }
	}
}
