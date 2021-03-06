using Terraria;
using Terraria.ModLoader;

namespace Elementaria.Buffs.MountBuff
{
	public class EarthWolfBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Earth Wolf");
			Description.SetDefault("You are blessed from the moon.");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(ModContent.MountType<Mounts.EarthWolf>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
