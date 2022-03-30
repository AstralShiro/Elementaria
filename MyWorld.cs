using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

using Elementaria.Tiles.VorumBiome.BlocksTile;

namespace Elementaria
{
	public class MyWorld : ModWorld
	{
		//Vorum Biomje
		int VorumTiles = 0;

		public static int ZoneVorum;

		public static bool vorumBiome = false;

		int SpawnPointX = Main.spawnTileX;
		int SpawnPointY = Main.spawnTileY;
		public override void ResetNearbyTileEffects() 
		{
			VorumTiles= 0;
		}
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{

			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
			}

			int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("gen"));
			if (genIndex == -1)
			{
				return;
			}

			tasks.Insert(genIndex + 1, new PassLegacy("Umbral Biome", delegate (GenerationProgress progress)
			{
				progress.Message = "Umbral.....";
				for (int i = 0; i < Main.maxTilesX / 900; i++)       //900 is how many biomes. the bigger is the number = less biomes
				{
					int X = WorldGen.genRand.Next(1, Main.maxTilesX - 100);
					int Y = WorldGen.genRand.Next((int)WorldGen.worldSurface - 100, Main.maxTilesY - 200);
					int TileType = mod.TileType("VorumGrassTile");   //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block

                	WorldGen.TileRunner(X, Y, 300, WorldGen.genRand.Next(100, 200), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.
					for (int k = 0; k < 750; k++)                     //750 is the ore spawn rate. the bigger is the number = more ore spawns
					{
						int Xo = X + Main.rand.Next(-240, 240);
						int Yo = Y + Main.rand.Next(-240, 240);
						if (Main.tile[Xo, Yo].type == mod.TileType("VorumStoneTile"))   //this is the tile where the ore will spawn
						{

							/*{
								WorldGen.TileRunner(Xo, Yo, (double)WorldGen.genRand.Next(5, 10), WorldGen.genRand.Next(5, 10), mod.TileType("EcliptiumOre"), false, 0f, 0f, false, true);  //   5, 10 is how big is the ore veins.    mod.TileType("CustomOreTile") is the custom ore tile,  if u want a vanila ore just do this: TileID.Cobalt, for cobalt spawn
							}*/
						}
					}
				}
			}));
		}

		public override void TileCountsAvailable(int[] tileCounts)
		{
			VorumTiles = tileCounts[ModContent.TileType<VorumGrassTile>()] + tileCounts[ModContent.TileType<VorumStoneTile>()];
		}
	}
}