using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Elementaria
{
	// ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
	// several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
	public class ElementariaPlayer : ModPlayer
	{
		///Biome
		public bool ZoneOverworldHeight;
		public bool ZoneCrimson;
		public bool ZoneCorrupt;
		public bool ZoneSnow;
		public bool ZoneDungeon;

		public override void UpdateBiomes()
		{
			ZoneOverworldHeight = player.ZoneOverworldHeight;

			ZoneCorrupt = player.ZoneCorrupt;

			ZoneCrimson = player.ZoneCrimson;

			ZoneSnow = player.ZoneSnow;

			ZoneDungeon = player.ZoneDungeon;

		}
	}
}