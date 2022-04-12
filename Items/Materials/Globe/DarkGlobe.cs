using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace Elementaria.Items.Materials.Globe
{
	public class DarkGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dark Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Dark Elemental Core");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 6));
		}

		public override void SetDefaults() {
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.LightPurple;
		}
	}
}