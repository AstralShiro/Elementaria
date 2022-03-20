using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

using Elementaria.Tiles.VorumBiome.BlocksTile;

namespace Elementaria
{
	public class MyWorld : ModWorld
	{
		//Vorum Biomje
		int VorumTiles = 0;
		int SpawnPointX = Main.spawnTileX;
		int SpawnPointY = Main.spawnTileY;

		public override void TileCountsAvailable(int[] tileCounts)
		{
			VorumTiles = tileCounts[ModContent.TileType<VorumGrassTile>()];
			//+ tileCounts[ModContent.TileType<SpiritStone>()]
			//+ tileCounts[ModContent.TileType<Spiritsand>()]
			//+ tileCounts[ModContent.TileType<SpiritIce>()]
			//+ tileCounts[ModContent.TileType<SpiritGrass>()];
		}
	}
}