using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.Collections.Specialized;
using Terraria.Localization;

using Elementaria.NPCs.Bosses.Butterveils.FirstPhase.Transf2;

namespace Elementaria.NPCs.Bosses.Butterveils.FirstPhase.Transf1
{
    [AutoloadBossHead]
    public class BossTransf1 : ModNPC
    {
        //Movement
        public float targetX = 0;
        public float targetY = 0;
        public int vMax = 0;
        public float vAccel = 0;
        public float tVel = 0;
        public float vMag = 0;

        //Attack
        
        private int attackTimer = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Butterveil, The ancestral");
            Main.npcFrameCount[npc.type] = 6;
        }

        public override void SetDefaults()
        {
            vMax = 6;
            vAccel = .5f;
            
            npc.width = 162;
            npc.height = 150;

            npc.aiStyle = 0;

            npc.lifeMax = 2000;
            npc.damage = 5;
            npc.defense = 5;

            npc.knockBackResist = 0f;

            npc.value = Item.buyPrice(0, 15, 00, 00);

            npc.npcSlots = 5f;

            npc.boss = true;

            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;

            npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/ButterveilHit");
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCKilled, "Sounds/NPCDeath/ButterveilSoundDeath");
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/ButterveilAir");
            //bossBag = mod.ItemType("IceBossBag");


        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax *0.5f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.5f);
        }

        public override void AI()
        {
            //Light
            Lighting.AddLight(npc.position, .8f, .8f, .8f);
            //Target
            Player player = Main.player[npc.target];
            targetX = player.Center.X;
            targetY = player.Center.Y;

            //Movement
            float dist = (float)(Math.Sqrt((targetX - npc.Center.X)* (targetX - npc.Center.X) + (targetY - npc.Center.Y)* (targetY - npc.Center.Y)));
            tVel = dist / 20;
            if(vMag < vMax && vMag < tVel)
            {
                vMag += vAccel;
            }
            if(vMag > tVel)
            {
                vMag -= vAccel;
            }

            if(dist != 0)
            {
                Vector2 tPos;
                tPos.X = targetX;
                tPos.Y = targetY;
                npc.velocity = npc.DirectionTo(tPos) * vMag;
            }
        }
        public override void NPCLoot()
        {
            NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<BossTransf2>(), 0, 0f, 0f, 0f, 0f);

            // Spawn 2nd Phase
            if (Main.netMode == NetmodeID.SinglePlayer) // Singleplayer
            {
                Main.NewText("You feel melting from the heat.", Color.Red);
            }
            else if (Main.netMode == NetmodeID.Server) // Server
            {
                NetMessage.BroadcastChatMessage(NetworkText.FromLiteral("You feel melting from the heat."), Color.Red);
            }
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            
        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 0.15000000596046448;
            npc.frameCounter %= (double)Main.npcFrameCount[npc.type];
            int num = (int)npc.frameCounter;
            npc.frame.Y = num * frameHeight;

            //harpy rotation
            npc.rotation = npc.velocity.X * 0.01f;
        }
    }
}