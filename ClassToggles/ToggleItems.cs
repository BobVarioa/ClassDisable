using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace ClassDisable.ClassToggles
{
	class ThrowingToggle : BaseToggleItem
	{
		public ThrowingToggle()
		{
			ItemName = "Class Lock : Throwing";
			Description = "Use this to nullify all throwing damage.\nUse this again to turn it off.";
			DamageType = DamageClass.Throwing;
			MessageLost = "Your throwing abilities are nullified";
			MessageGain = "Your throwing abilities have came back";
		}
	}

	class SummonToggle : BaseToggleItem
	{
		public SummonToggle()
		{
			ItemName = "Class Lock : Summon";
			Description = "Use this to nullify all summoning damage.\nUse this again to turn it off.";
			DamageType = DamageClass.Summon;
			MessageLost = "Your summoning abilities are nullified";
			MessageGain = "Your summoning abilities have came back";
		}
	}

	class RangedToggle : BaseToggleItem
	{
		public RangedToggle()
		{
			ItemName = "Class Lock : Ranged";
			Description = "Use this to nullify all ranged damage.\nUse this again to turn it off.";
			DamageType = DamageClass.Ranged;
			MessageLost = "Your ranged abilities are nullified";
			MessageGain = "Your ranged abilities have came back";
		}
	}

	class MeleeToggle : BaseToggleItem
	{
		public MeleeToggle()
		{
			ItemName = "Class Lock : Melee";
			Description = "Use this to nullify all melee damage.\nUse this again to turn it off.";
			DamageType = DamageClass.Melee;
			MessageLost = "Your melee abilities are nullified";
			MessageGain = "Your melee abilities have came back";
		}
	}

	class MagicToggle : BaseToggleItem
	{
		public MagicToggle()
		{
			ItemName = "Class Lock : Magic";
			Description = "Use this to nullify all magic damage.\nUse this again to turn it off.";
			DamageType = DamageClass.Magic;
			MessageLost = "Your magical abilities are nullified";
			MessageGain = "Your magical abilities have came back";
		}
	}

	class AllToggle : BaseToggleItem
	{
		public AllToggle()
		{
			ItemName = "Class Lock : All";
			Description = "Use this to nullify all player produced damage.\nUse this again to turn it off.";
			DamageType = DamageClass.Generic;
			MessageLost = "Your abilities are nullifed";
			MessageGain = "Your abilities have been normalized";

		}
	}
}
