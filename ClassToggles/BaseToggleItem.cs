using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClassDisable.ClassToggles
{
	abstract class BaseToggleItem : ModItem
	{
		public string ItemName;
		public string Description;
		public DamageClass DamageType;
		public string MessageLost;
		public string MessageGain;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault(ItemName);
			Tooltip.SetDefault(Description);
		}

		public override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.consumable = false;
			Item.rare = ItemRarityID.Purple;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.useTime = 10;
			Item.useAnimation = 10;
		}

		public override bool? UseItem(Player player)
		{
			TogglePlayer modPlayer = player.GetModPlayer<TogglePlayer>();
			modPlayer.UseToggleItem(DamageType, MessageLost, MessageGain);
			return true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.DemonAltar)
				.Register();
		}
	}
}
