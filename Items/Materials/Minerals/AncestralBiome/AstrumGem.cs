using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Elementaria.Items.Materials.Minerals.AncestralBiome
{
	public class AstrumGem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astrum Gem");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 57;
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.AncestralBiome.Minerals.AstrumGemTile>();
			item.width = 22;
			item.height = 18;
			item.value = 75000;
			item.rare = ItemRarityID.Blue;
		}
	}
}
