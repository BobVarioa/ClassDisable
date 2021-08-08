using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using ClassDisable.Utils;

namespace ClassDisable.ClassToggles
{
	public class TogglePlayer : ModPlayer
	{
		public DamageClassDictionary<bool> toggles = new();

		public override void Initialize()
		{
			toggles.Set(DamageClass.Generic, false);
			toggles.Set(DamageClass.Melee, false);
			toggles.Set(DamageClass.Magic, false);
			toggles.Set(DamageClass.Ranged, false);
			toggles.Set(DamageClass.Throwing, false);
			toggles.Set(DamageClass.Summon, false);
		}

		/*
		public override TagCompound Save()
		{
			TagCompound tag = toggles.Serialize();
			tag["version"] = Mod.Version.ToString();
			return tag;
		}

		public override void Load(TagCompound tag)
		{
			if (tag.ContainsKey("version") && tag.GetString("version") == Mod.Version.ToString()) {
				foreach (KeyValuePair<string, object> pair in tag)
				{
					toggles.Set(pair.Key, tag.GetBool(pair.Key));
				}
			}
			
		}
		*/

		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
		{
			return new[] {
				new Item(ModContent.ItemType<MagicToggle>()),
				new Item(ModContent.ItemType<MeleeToggle>()),
				new Item(ModContent.ItemType<RangedToggle>()),
				new Item(ModContent.ItemType<SummonToggle>()),
				new Item(ModContent.ItemType<ThrowingToggle>()),
				new Item(ModContent.ItemType<AllToggle>()),
			};
		}

		public override void ModifyWeaponDamage(Item item, ref StatModifier damage, ref float flat)
		{
			foreach (KeyValuePair<DamageClass, bool> pair in toggles)
			{
				if (pair.Value)
				{
					Player.GetDamage(pair.Key) *= 0;
				}
			}
		}

		public void UseToggleItem(DamageClass damageClass, string messageLost, string messageGain)
		{
			toggles.Set(damageClass, !toggles.Get(damageClass));
			Main.NewText(toggles.Get(damageClass) ? messageLost : messageGain);
		}
	}
}
