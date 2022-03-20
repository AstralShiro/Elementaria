using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Elementaria.Items.Placeable.Decoration;
using Elementaria.Tiles.VorumBiome.BlocksTile.VorumTree;

namespace Elementaria.Tiles.VorumBiome.BlocksTile
{
	public class VorumWoodTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			drop = ItemType<Items.Placeable.Decoration.VorumWood>();
			AddMapEntry(new Color(80, 175, 210));
			SetModTree(new VorumTreeTile());
		}
	}
}