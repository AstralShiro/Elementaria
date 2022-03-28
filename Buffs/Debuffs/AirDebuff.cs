using Terraria;
using Terraria.ModLoader;

namespace Elementaria.Buffs.Debuffs
{
	public class AirDebuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Blighted Flames");
			Main.buffNoTimeDisplay[Type] = false;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.stepSpeed -= 2;

			if (Main.rand.NextBool(2)) {
				int dust = Dust.NewDust(npc.position, npc.width, npc.height, 61);
				Main.dust[dust].scale = 3f;
				Main.dust[dust].noGravity = true;
			}
		}
	}
}