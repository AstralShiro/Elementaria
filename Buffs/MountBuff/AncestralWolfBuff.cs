using Terraria;
using Terraria.ModLoader;

namespace Elementaria.Buffs.MountBuff
{
	public class AncestralWolfBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Ancestral Wolf");
			Description.SetDefault("You are blessed from the moon.");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(ModContent.MountType<Mounts.AncestralWolf>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
