using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Elementaria.Tiles.AncestralBiome.BlocksTile
{
	public class AncestralStoneTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			//drop = ItemType<Items.Placeable.AncestralBiome.AncestralStone>();
			AddMapEntry(new Color(79, 79, 79));
			
			drop = 3;
		}
	}
}