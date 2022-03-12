using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

namespace Elementaria.Items.Materials
{
	public class WoFHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wall of Flesh Heart");
			Tooltip.SetDefault("Heart of the King of Hell, can be used to craft one Crafting Station T2");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.maxStack = 1;
			item.value = 100;
			item.rare = ItemRarityID.Expert;
		}
	}
}