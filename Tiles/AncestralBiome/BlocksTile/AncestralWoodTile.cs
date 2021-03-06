using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Elementaria.Items.Placeable.Decoration;
using Elementaria.Tiles.AncestralBiome.BlocksTile.AncestralTree;

namespace Elementaria.Tiles.AncestralBiome.BlocksTile
{
	public class AncestralWoodTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			drop = ItemType<AncestralWood>();
			AddMapEntry(new Color(80, 175, 210));
			SetModTree(new AncestralTreeTile());
		}
	}
}