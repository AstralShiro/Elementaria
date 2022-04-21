using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

using Elementaria.Items.Materials.Globe;
using Elementaria.Items.Materials;
using Elementaria.Items;

namespace Elementaria.NPCs
{
    public class GlobalNpc : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.AngryBones)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.AngryBonesBig)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.AngryBonesBigHelmet)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.AngryBonesBigMuscle)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.AnomuraFungus)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Antlion)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.WalkingAntlion)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.FlyingAntlion)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BabySlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Bee)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlackSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlazingWheel)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BloodCrawler)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlueJellyfish)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlueSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BoneSerpentHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CaveBat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CochinealBeetle)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Crab)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Crawdad)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Crawdad2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Crimera)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BigCrimera)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CursedSkull)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CyanBeetle)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DarkCaster)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Demon)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DemonEye)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DemonEye2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DemonEyeOwl)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DemonEyeSpaceship)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GreenEye)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GreenEye2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.PurpleEye)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.PurpleEye2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SleepyEye)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SleepyEye2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DevourerHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DoctorBones)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DungeonGuardian)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DungeonSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.EaterofSouls)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.FaceMonster)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.FireImp)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.ZombieEskimo)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.FungiBulb)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Ghost)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GiantShelly)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GiantShelly2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GiantWormHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GoblinScout)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GraniteFlyer)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GraniteGolem)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GreenSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Harpy)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AirGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Hellbat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GreekSkeleton)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Hornet)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IceBat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IceSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.JungleBat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.JungleSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.LacBeetle)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.LavaSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.ManEater)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.MeteorHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.MotherSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.MushiLadybug)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Nymph)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Pinky)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.PinkJellyfish)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Piranha)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.PurpleSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Raven)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RedSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander3)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander4)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander5)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander6)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander7)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander8)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Salamander9)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SandSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SeaSnail)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Shark)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Skeleton)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SkeletonAlien)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SkeletonAstonaut)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SkeletonTopHat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Snatcher)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SnowFlinx)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SpikeBall)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SpikedIceSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SpikedJungleSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Squid)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Tim)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.TombCrawlerHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.UndeadMiner)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.UndeadViking)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.VoodooDemon)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Vulture)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.WallCreeper)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.YellowSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Zombie)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.AnglerFish)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.AngryTrapper)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Arapaima)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.ArmoredSkeleton)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.ArmoredViking)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DesertBeast)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlackRecluse)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BloodFeeder)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BloodJelly)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CultistArcherBlue)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CultistArcherWhite)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlueArmoredBones)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlueArmoredBonesMace)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlueArmoredBonesNoPants)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BlueArmoredBonesSword)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BoneLee)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.ChaosElemental)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Clinger)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BigMimicCorruption)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CorruptSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Corruptor)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Crimslime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CrimsonAxe)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BigMimicCrimson)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CursedHammer)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DarkMummy)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Derpling)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DesertDjinn)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DiabolistRed)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DiabolistWhite)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DiggerHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DesertGhoulHallow)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DuneSplicerHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DungeonSpirit)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.EnchantedSword)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.FloatyGross)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.FlyingSnake)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.FungoFish)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Gastropod)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DesertGhoul)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GiantBat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GiantCursedSkull)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GiantFlyingFox)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GiantFungiBulb)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GiantTortoise)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.GreenJellyfish)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BigMimicHallow)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.HellArmoredBones)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.HellArmoredBonesMace)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.HellArmoredBonesSpikeShield)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.HellArmoredBonesSword)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Herpling)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.HoppinJack)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IceElemental)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Mimic)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IceTortoise)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IchorSticker)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IcyMerman)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IlluminantBat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IlluminantSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.JungleCreeper)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DesertLamiaDark)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DesertLamiaLight)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Lavabat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.LightMummy)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0,2));
            }
            if (npc.type == NPCID.Lihzahrd)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.LihzahrdCrawler)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CultistDevote)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.MartianDrone)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AirGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Medusa)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.MossHornet)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Moth)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Mummy)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Necromancer)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.NecromancerArmored)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Paladin)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.PigronCorruption)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.PigronCrimson)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.PigronHallow)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Pixie)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.PossessedArmor)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RaggedCaster)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RedDevil)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RuneWizard)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RustyArmoredBonesAxe)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RustyArmoredBonesFlail)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RustyArmoredBonesSword)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RustyArmoredBonesSwordNoArmor)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.ScorpionBlack)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SkeletonArcher)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SkeletonCommando)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SkeletonSniper)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Slimeling)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Slimer)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Slimer2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.TacticalSkeleton)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DemonTaxCollector)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.ToxicSludge)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Unicorn)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DesertGhoulCorruption)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DesertGhoulCrimson)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.WanderingEye)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Werewolf)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Wolf)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Wraith)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.WyvernHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AirGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BloodZombie)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Clown)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CorruptBunny)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CorruptGoldfish)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CorruptPenguin)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Drippler)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.TheGroom)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.TheBride)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CrimsonBunny)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CrimsonGoldfish)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CrimsonPenguin)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.AngryNimbus)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.FlyingFish)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.IceGolem)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.RainbowSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.ZombieRaincoat)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.UmbrellaSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Tumbleweed)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SandsharkHallow)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SandsharkCrimson)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SandsharkCorrupt)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SandShark)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.BrainofCthulhu)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.DukeFishron)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.EaterofWorldsHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.EyeofCthulhu)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.Golem)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.KingSlime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.CultistBoss)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.MoonLordCore)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AirGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThunderGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HallowGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<MoonLordHeart>());
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<TokenS>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<TokenN>(), Main.rand.Next(0, 2));

            }
            if (npc.type == NPCID.Plantera)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.QueenBee)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SkeletronHead)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.SkeletronPrime)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.TheDestroyer)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EarthGlobe>(), Main.rand.Next(0, 2));
            }
            if (npc.type == NPCID.WallofFlesh)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FireGlobe>(), Main.rand.Next(0, 2));
            }

            //Modded NPCs
            
        }
    }
}