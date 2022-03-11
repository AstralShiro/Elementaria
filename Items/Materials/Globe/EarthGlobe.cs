using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

namespace Elementaria.Items.Materials.Globe
{
	public class EarthGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Earth Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Earth Elemental Core");
		}

		public override void SetDefaults() {
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Orange;
		}
	}
}