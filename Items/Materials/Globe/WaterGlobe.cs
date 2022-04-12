using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Materials.Globe
{
	public class WaterGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Water Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Water Elemental Core");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 7));
		}

		public override void SetDefaults() {
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Green;
		}
	}
}