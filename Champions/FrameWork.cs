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
		/// Class containing a rule set for the game
		/// </summary>
		public class Rules
		{
			public IList<Skill> Skills { get; set; }
			public IList<Component> Perks { get; set; }
			public IList<Component> Talents { get; set; }
			public IList<Component> Powers { get; set; }
			public IList<Framework> FrameWorks { get; set; }
		}

		/// <summary>
		/// The Base for all framework types
		/// </summary>
		public abstract class FrameworkBase
		{
			/// <summary>
			/// The name of the power, modifier, part of a power or so on...
			/// </summary>
			public string Name { get; set; }

			/// <summary>
			/// The explanation for what this does
			/// </summary>
			public string Explanation { get; set; }
		}

		/// <summary>
		/// Class for powers, disads, skills and so on
		/// </summary>
		public class Component:FrameworkBase
		{
			/// <summary>
			/// the Base cost for anything (for example Public ID ony has a base cost of 10, and nothing else)
			/// </summary>
			public int BaseCost { get; set; }

			/// <summary>
			/// All options on what can be bought under this
			/// </summary>
			public IList<Option> Options { get; set; }
		}

		/// <summary>
		/// Class to describe a skill
		/// </summary>
		public class Skill:Component
		{
			/// <summary>
			/// Types of skills
			/// </summary>
			public enum SkillType { Background, Combat, General, IntBased, DexBased, PreBased }

			/// <summary>
			/// What type of skill this is.
			/// </summary>
			public SkillType Type { get; set; }

			/// <summary>
			/// Constructor sets defaults for skills
			/// </summary>
			public Skill()
			{
				BaseCost = 1;

				Options = new Option[1];
				Options[0].Type = Option.OptionType.Incremental;
				Options[0].PointAlloc = new PointAllocation[1];
				Options[0].PointAlloc[0].Cost = 2;
				Options[0].PointAlloc[0].CostApplication = PointAllocation.CostType.Additive;
			}
		}

		/// <summary>
		/// Class for power frameworks
		/// </summary>
		public class Framework:Component
		{
			public enum FrameworkTypes { ElementalControl, Multipower, VariablePowerPool }

			public FrameworkTypes Type;
		}

		/// <summary>
		/// Any part of a power or anything that gives you options on how many points to put in.
		/// ex: Hunted would have 1 of these for how powerfull the hunter is, 1 for how often and so on... 
		/// </summary>
		public class Option
		{
			/// <summary>
			/// Setting		=> has discrete values that only one of which can be used.
			/// Incremental => can be bought over and over again for the same cost.
			/// </summary>
			public enum OptionType { Setting, Incremental };

			/// <summary>
			/// The type of this option
			/// </summary>
			public OptionType Type { get; set; }


			/// <summary>
			/// How the points can be allocated, if this is incremental then it will be 1 length array
			/// </summary>
			public IList<PointAllocation> PointAlloc { get; set; }
		}

		/// <summary>
		/// A single place where points can be put
		/// ex: EB would have one with cost = 5, and CostApplication = Additive, for putting more points into the power.
		/// </summary>
		public class PointAllocation
		{
			/// <summary>
			/// The cost of one level or the overall cost if it's a pure setting
			/// </summary>
			public decimal Cost { get; set; }

			/// <summary>
			/// If we multiply the cost by this or add it in (watched has a x 0.5 cost that is multiplicative)
			/// Multiplicative costs are allways applied last.
			/// </summary>
			public CostType CostApplication { get; set; }

			/// <summary>
			/// an enum for how the cost is applied
			/// </summary>
			public enum CostType { Multiplicitive, Additive };
		}
	}
}
