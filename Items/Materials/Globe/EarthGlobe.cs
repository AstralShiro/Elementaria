using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Materials.Globe
{
	public class EarthGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Earth Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Earth Elemental Core");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5,10));
		}

		public override void SetDefaults() {
			item.width = 30;
			item.height = 27;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Orange;
		}
	}
}