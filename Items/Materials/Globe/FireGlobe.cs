using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Materials.Globe
{
	public class FireGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fire Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Fire Elemental Core");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 5));
		}

		public override void SetDefaults() {
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Red;
		}
	}
}