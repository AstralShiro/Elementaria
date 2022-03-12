using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

using Elementaria;

namespace Elementaria
{
	public class Elementaria : Mod
	{
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
                return;
            }
            if (Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ZoneDirtLayerHeightMod)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Forest");
                priority = MusicPriority.BiomeMedium;
            }
            if (Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ZoneJungleMod)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle");
                priority = MusicPriority.BiomeMedium;
            }
        }
    }
}