using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Elementaria.Tiles.VorumBiome.BlocksTile.VorumTree;

namespace Elementaria.Tiles.VorumBiome.BlocksTile
{
	public class VorumGrassTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			TileID.Sets.Grass[Type] = true;
			TileID.Sets.NeedsGrassFraming[Type] =true;
			TileID.Sets.NeedsGrassFramingDirt[Type] = TileID.Dirt;

			drop = 2;
			AddMapEntry(new Color(79, 79, 79));
		}
		public override int SaplingGrowthType(ref int style) 
		{
			style = 0;
			return ModContent.TileType<VorumTreeSaplingTile>();
		}
	}
}