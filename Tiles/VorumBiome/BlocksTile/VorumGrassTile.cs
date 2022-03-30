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
		int HouseTile = TileID.Dirt;
		int HouseTileItem = ItemID.DirtBlock;
		int distance = 1;
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
			AddMapEntry(new Color(255, 120, 70));
		}
		public override int SaplingGrowthType(ref int style) 
		{
			style = 0;
			return ModContent.TileType<VorumTreeSaplingTile>();
		}

		public override void RandomUpdate(int i, int j)
		{
			int LocationX = i;
			int LocationY = j;
			for (int x = LocationX - distance; x <= LocationX + distance; x++)
			{
				for (int y = LocationY - distance; y <= LocationY + distance; y++)
				{
					if (Vector2.Distance(new Vector2(LocationX, LocationY), new Vector2(x, y)) <= distance)
					{
						if (Main.tile[x, y].type == HouseTile)
						{
							if (Main.tile[x + 1, y].active() && Main.tile[x, y - 1].active() && Main.tile[x - 1, y].active() && Main.tile[x, y + 1].active() && Main.tile[x + 1, y + 1].active() && Main.tile[x - 1, y - 1].active() && Main.tile[x - 1, y + 1].active() && Main.tile[x + 1, y - 1].active())
							{
							}
							else
							{
								if (Main.rand.Next(1) == 0)
								{
									Main.tile[x, y].type = (ushort)mod.TileType("VorumGrassTile");;
								}
							}
						}
					}
				}
			}
		}
		public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
		{
			WorldGen.PlaceTile(i, j, (ushort)HouseTile);
		}
	}
}