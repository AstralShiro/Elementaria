using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

namespace Elementaria.Items.Materials
{
	public class ArcanumHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Butterveil, The arcanum Heart");
			Tooltip.SetDefault("Heart of the Dark cosmo, can be used to craft one Crafting Station TSS");
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