
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
using Elementaria.UI;

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
        public override void Load()
        {
            ClassBarUltimate = RegisterHotKey("Use Ancient Power", "V");
            {             
                if (Main.netMode != NetmodeID.Server)
                {
                    mainUserInterface = new UserInterface();
                    mainUIState = new MainUIState();
                    mainUIState.Activate();
                    mainUserInterface.SetState(mainUIState);

                    resourceBarUI = new UserInterface();
                    resourceBar = new ResourceBar();
                    resourceBar.Activate();
                    resourceBarUI.SetState(resourceBar);
                }
            }
        }
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
        internal MainUIState mainUIState;
        internal UserInterface mainUserInterface;

        internal ResourceBar resourceBar;
        internal UserInterface resourceBarUI;

        private GameTime _lastUpdateUiGameTime;
        public override void UpdateUI(GameTime gameTime)
        {
            _lastUpdateUiGameTime = gameTime;
            if (mainUserInterface?.CurrentState != null)
                mainUserInterface.Update(gameTime);

            if (resourceBarUI?.CurrentState != null)
                resourceBarUI.Update(gameTime);
        }
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            //https://github.com/tModLoader/tModLoader/wiki/Vanilla-Interface-layers-values
            int interfaceLayer = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (interfaceLayer != -1)
            {
                layers.Insert(interfaceLayer, new LegacyGameInterfaceLayer(
                    "ElementsOfLife: MainUserInterface",
                    delegate
                    {
                        if (_lastUpdateUiGameTime != null && mainUserInterface?.CurrentState != null)
                        {
                            mainUserInterface.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
                        }
                        return true;
                    },
                       // If an UIElement (attached to our UI) needs to be rescaled along the game's UI Scale and Zoom, the ScaleType needs to be InterfaceScaleType.Game
                       InterfaceScaleType.UI));
            }

            int resourceBarIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Resource Bars"));
            if (resourceBarIndex != -1)
            {
                layers.Insert(resourceBarIndex, new LegacyGameInterfaceLayer(
                    "ElementsOfLife: Class Resource Bar",
                    delegate {
                        if (_lastUpdateUiGameTime != null && resourceBarUI?.CurrentState != null)
                        {
                            resourceBarUI.Draw(Main.spriteBatch, new GameTime());
                        }
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}

