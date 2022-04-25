using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using Terraria.ID;

namespace Elementaria.Items.Placeable.AncestralBiome
{
	public class AncestralSand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancestral Grass");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = TileType<Tiles.AncestralBiome.BlocksTile.AncestralSandTile>();
		}
	}
}