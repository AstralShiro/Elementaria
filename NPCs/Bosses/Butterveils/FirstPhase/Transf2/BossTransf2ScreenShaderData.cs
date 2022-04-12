using System;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;

namespace Elementaria.NPCs.Bosses
{
    public class BossTransf2ScreenShaderData : ScreenShaderData
    {
        private int BossTransf2Index;

        public BossTransf2ScreenShaderData(string passName)
            : base(passName)
        {
        }

        private void UpdateVikingIndex()
        {
            int BossTransf2Tpye = ModLoader.GetMod("Elementaria").NPCType("BossTransf2");
            if (BossTransf2Index >= 0 && Main.npc[BossTransf2Index].active && Main.npc[BossTransf2Index].type == BossTransf2Tpye)
            {
                return;
            }
            BossTransf2Index = -1;
            for (int i = 0; i < Main.npc.Length; i++)
            {
                if (Main.npc[i].active && Main.npc[i].type == BossTransf2Tpye)
                {
                    BossTransf2Index = i;
                    break;
                }
            }
        }

        public override void Apply()
        {
            UpdateVikingIndex();
            if (BossTransf2Index != -1)
            {
                UseTargetPosition(Main.npc[BossTransf2Index].Center);
            }
            base.Apply();
        }
    }
}