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
		public bool ZoneDirtLayerHeightMod;
		public bool ZoneJungleMod;

		///Event
		public bool GoblinInvasion;

		public override void UpdateBiomes()
		{
			ZoneDirtLayerHeightMod = player.ZoneDirtLayerHeight;
			ZoneJungleMod = player.ZoneJungle;

			
		}
	}
}