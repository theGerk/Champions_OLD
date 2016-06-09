using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions
{
	/// <summary>
	/// This is for anything to describe the rules of the book.
	/// </summary>
	namespace Framework
	{
		/// <summary>
		/// The Base for all framework types
		/// </summary>
		public abstract class FrameworkBase
		{
			/// <summary>
			/// The name of the power, modifier, part of a power or so on...
			/// </summary>
			public string Name { get; }

			/// <summary>
			/// The explanation for what this does
			/// </summary>
			public string Explanation { get; }
		}

		/// <summary>
		/// The base for any power, talent, disad, and so on
		/// </summary>
		public class Component:FrameworkBase
		{
			/// <summary>
			/// the Base cost for anything (for example Public ID ony has a base cost of 10, and nothing else
			/// </summary>
			public int BaseCost { get; }

			/// <summary>
			/// All options on what can be bought under this
			/// </summary>
			public Option[] Options { get; }
		}

		/// <summary>
		/// Any part of a power or anything that gives you options on how many points to put in
		/// ex: Hunted would have 1 of these for how powerfull the hunter is, 1 for how often and so on... 
		/// </summary>
		public class Option:FrameworkBase
		{
			/// <summary>
			/// Setting		=> has discrete values that only one of which can be used.
			/// Incremental => can be bought over and over again for the same cost.
			/// </summary>
			public enum OptionType { Setting, Incremental };

			/// <summary>
			/// The type of this option
			/// </summary>
			public OptionType Type { get; }


			/// <summary>
			/// How the points can be allocated, if this is incremental then it will be 1 length array
			/// </summary>
			public PointAllocation[] PointAlloc { get; }
		}

		/// <summary>
		/// A single place where points can be put
		/// ex: EB would have one with cost = 5, and CostApplication = Additive, for putting more points into the power.
		/// </summary>
		public class PointAllocation:FrameworkBase
		{
			/// <summary>
			/// The cost of one level or the overall cost if it's a pure setting
			/// </summary>
			public decimal Cost { get; }

			/// <summary>
			/// If we multiply the cost by this or add it in (watched has a x 0.5 cost that is multiplicative)
			/// Multiplicative costs are allways applied last.
			/// </summary>
			public CostType CostApplication { get; }


			public enum CostType { Multiplicitive, Additive };
		}
	}
}
