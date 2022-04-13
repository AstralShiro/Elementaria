
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;

using Elementaria;

namespace Elementaria
{
	public class Elementaria : Mod
	{
        public Elementaria()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        internal static ModHotKey ClassBarUltimate;
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
                return;
            }
            if (Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ZoneOverworldHeight)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Forest");
                priority = MusicPriority.BiomeMedium;
            }
            if (Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ZoneCrimson)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Crimson");
                priority = MusicPriority.BiomeMedium;
            }
            if (Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ZoneCorrupt)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Corruption");
                priority = MusicPriority.BiomeMedium;
            }
            if (Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ZoneSnow)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Snow");
                priority = MusicPriority.BiomeMedium;
            }
            if (Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ZoneDungeon)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Dungeon");
                priority = MusicPriority.BiomeMedium;
            }
        }
    }
}