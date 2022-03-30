using Microsoft.Xna.Framework;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Items.Animals;

namespace Elementaria.NPCs.VorumBiome.Animals
{
	/// <summary>
	/// This file shows off a critter npc. The unique thing about critters is how you can catch them with a bug net.  
	/// The important bits are: Main.npcCatchable, npc.catchItem, and item.makeNPC
	/// We will also show off adding an item to an existing RecipeGroup (see ExampleMod.AddRecipeGroups)
	/// </summary>
	internal class CosmoBunnyNPC : ModNPC
	{
			public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cosmo Bunny");
			Main.npcFrameCount[npc.type] = 7;
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 18;
			npc.damage = 0;
			npc.defense = 0;
			npc.lifeMax = 5;
			npc.dontCountMe = true;
			npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath4;
			Main.npcCatchable[npc.type] = true;
			npc.catchItem = (short)ModContent.ItemType<CosmoBunny>();
			npc.knockBackResist = .45f;
			npc.aiStyle = NPCID.Bunny;
			npc.npcSlots = 0;
			npc.friendly = true;
			npc.dontTakeDamageFromHostiles = false;
			npc.noGravity = false;
			aiType = NPCID.Bunny;
		}

		public override bool? CanBeHitByItem(Player player, Item item) {
			return true;
		}

		public override bool? CanBeHitByProjectile(Projectile projectile) {
			return true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.Overworld.Chance * 0.1f;
		}

		public override void AI()
		{
			npc.spriteDirection = npc.direction;
		}
		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter += 0.15f;
			npc.frameCounter %= Main.npcFrameCount[npc.type];
			int frame = (int)npc.frameCounter;
			npc.frame.Y = frame * frameHeight;
		}
	}
}