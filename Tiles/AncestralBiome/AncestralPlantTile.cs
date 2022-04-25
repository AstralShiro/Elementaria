using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace Elementaria.Tiles.AncestralBiome
{
	public class AncestralPlantTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1xX);
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
			TileObjectData.newTile.CoordinateWidth = 16;
			
			TileObjectData.newTile.Width = 2;
			TileObjectData.newTile.Height = 3;

			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Vicious Plant");
			AddMapEntry(new Color(107, 90, 64), name);
			adjTiles = new int[] { TileID.Sunflower };

			drop = ItemType<Items.Placeable.AncestralBiome.AncestralPlant>();
		}

	}
}