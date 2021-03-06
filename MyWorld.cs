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
using System;
using System.Linq;
using System.Diagnostics.Contracts;
using Terraria.GameContent.Biomes;
using Terraria.Utilities;

using Elementaria.Walls;
using Elementaria.Tiles.AncestralBiome.Minerals;
using Elementaria.Tiles.AncestralBiome.BlocksTile;

namespace Elementaria
{
	public class MyWorld : ModWorld
	{
		//Ancestral Biomje
		int AncestralTiles = 0;
		public static bool essenceMessage = false;
		public static bool downedButterveilAncestral = false;
		private int Meme;
		private int WillGenn = 0;
		public static int ZoneAncestral;

		public static bool AncestralBiome = false;

		int SpawnPointX = Main.spawnTileX;
		int SpawnPointY = Main.spawnTileY;
		public override void ResetNearbyTileEffects() 
		{
			AncestralTiles= 0;
		}
		public override TagCompound Save()
		{
			TagCompound data = new TagCompound();
			var downed = new List<string>();
			if (downedButterveilAncestral)
				downed.Add("butterveilAncestral");
				data.Add("downed", downed);

			TagCompound droppedGlyphTag = new TagCompound();
			return data;
		}
		public override void Load(TagCompound tag)
		{
			var downed = tag.GetList<string>("downed");
			downedButterveilAncestral = downed.Contains("butterveilAncestral");
		}
		public override void LoadLegacy(BinaryReader reader)
		{
			int loadVersion = reader.ReadInt32();
			if (loadVersion == 0) {
				BitsByte flags = reader.ReadByte();
				BitsByte flags1 = reader.ReadByte();
				BitsByte flags2 = reader.ReadByte();
				BitsByte flags3 = reader.ReadByte();
				BitsByte flags4 = reader.ReadByte();

				downedButterveilAncestral = flags[0];
			}
			else {
				mod.Logger.Error("Unknown loadVersion: " + loadVersion);
			}
		}
		public override void NetSend(BinaryWriter writer)
		{
			BitsByte bosses1 = new BitsByte(downedButterveilAncestral);
			writer.Write(bosses1);
		}
		public override void NetReceive(BinaryReader reader)
		{
			BitsByte bosses1 = reader.ReadByte();
			BitsByte bosses2 = reader.ReadByte();

			downedButterveilAncestral = bosses1[0];
		}
		public override void Initialize()
		{
			if (downedButterveilAncestral)
				AncestralBiome = true;
			else
				AncestralBiome = false;
			if (Main.hardMode)
			
			if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
				essenceMessage = true;
			else
				essenceMessage = false;
			
			downedButterveilAncestral = false;
		}


		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight) {
			// Because world generation is like layering several images ontop of each other, we need to do some steps between the original world generation steps.

			// The first step is an Ore. Most vanilla ores are generated in a step called "Shinies", so for maximum compatibility, we will also do this.
			// First, we find out which step "Shinies" is.
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1) {
				// Next, we insert our step directly after the original "Shinies" step. 
				// ExampleModOres is a method seen below.
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Astrum Ore", AstrumOreGen));
			}
		}

		private void AstrumOreGen(GenerationProgress progress) {
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes. 
			progress.Message = "Elementaria Ores gen";

			// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
			// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
			for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++) {
				// The inside of this for loop corresponds to one single splotch of our Ore.
				// First, we randomly choose any coordinate in the world by choosing a random x and y value.
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

				// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), ModContent.TileType<AstrumOreTile>());

				// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
				// Tile tile = Framing.GetTileSafely(x, y);
				// if (tile.active() && tile.type == TileID.SnowBlock)
				// {
				// 	WorldGen.TileRunner(.....);
				// }
			}
		}
		public override void TileCountsAvailable(int[] tileCounts)
		{
			AncestralTiles = tileCounts[ModContent.TileType<AncestralGrassTile>()] + tileCounts[ModContent.TileType<AncestralStoneTile>()];
		}
	}
}