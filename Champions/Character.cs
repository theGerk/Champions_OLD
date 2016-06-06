using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Champions
{
	public class Character
	{
		public BigInteger BasePoints { get; set; }

		public BigInteger MaximumDisadvantagePoints { get; set; }

		public BigInteger PointsEarned { get; set; }

		public List<ExternalPointAllocator> PointsSpentExternally { get; set; }

		public Characteristics[] Characteristics { get; set; }
	}

	public struct Characteristics
	{
		IncreaseablePower
	}

	public class ExternalPointAllocator
	{
		public ExternalPointAllocator(string whatTo)
		{ WhatTo = whatTo; }
		public ExternalPointAllocator(BigInteger points, string whatTo)
		{ PointsAllocated = points; WhatTo = whatTo; }

		public BigInteger PointsAllocated { get; set; }

		public string WhatTo { get; set; }
	}
	
	abstract public class PowerBase
	{
		public string Name { get; set; }

		public string Explanation { get; set; }

		public abstract int RealCost { get; }

		public List<Advantage> Advantages { get; set; }

		public List<> Limitations { get; set; }
	}

	public struct Advantage
	{
		public enum Name {
			AffectsDesolidified,
			AreaEffect,

		}

		public string Description { get; set; }

		public string Explanation { get; set; }
	}

	public class IncreaseablePower : PowerBase
	{

	}

	public class SettablePower : PowerBase
	{

	}

	public struct PowerSetting
	{
		string Description
	}
}
