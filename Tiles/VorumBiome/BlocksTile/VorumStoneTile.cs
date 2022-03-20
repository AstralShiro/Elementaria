using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Elementaria.Tiles.VorumBiome.BlocksTile
{
	public class VorumStoneTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			//drop = ItemType<Items.Placeable.VorumBiome.VorumStone>();
			AddMapEntry(new Color(79, 79, 79));
		}
	}
}