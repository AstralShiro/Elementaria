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

namespace Elementaria.NPCs.Bosses.Butterveils.SecondTransf
{
    //[AutoloadBossHead]
    public class ButterveilSecondTransf : ModNPC
    {
        private Player player;
        private float speed;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Butterveil, The ancestral");

        }

        public override void SetDefaults()
        {
            npc.aiStyle = 5;
            npc.lifeMax = 3500;
            npc.damage = 10;
            npc.defense = 10;
            npc.knockBackResist = 0f;
            npc.width = 162;
            npc.height = 150;
            npc.value = Item.buyPrice(0, 15, 00, 00);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = false;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/HitIceBoss");
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCDeath/DeathIceBoss");
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/ElementalMusic");
            bossBag = mod.ItemType("IceBossBag");
            npc.netAlways = true;
            Main.npcFrameCount[npc.type] = 6;

        }

        public override bool PreNPCLoot()
        {
            return true;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.5f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.5f);
        }

             public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 0.15000000596046448;
            npc.frameCounter %= (double)Main.npcFrameCount[npc.type];
            int num = (int)npc.frameCounter;
            npc.frame.Y = num * frameHeight;

            //harpy rotation
            npc.rotation = npc.velocity.X * 0.05f;
        }
    }
}