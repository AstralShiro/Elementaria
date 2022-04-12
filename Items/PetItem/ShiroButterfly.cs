using Elementaria.Buffs.PetBuff;
using Elementaria.Projectiles.PetsProj;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.PetItem
{
	public class ShiroButterfly : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiro butterfly");
			Tooltip.SetDefault("Summons a light blue and pink butterfly");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Fish);
			item.shoot = ModContent.ProjectileType<ShiroButterflyProj>();
			item.buffType = ModContent.BuffType<ShiroButterflyBuff>();
			item.UseSound = SoundID.NPCDeath6;
			item.rare = ItemRarityID.Expert;
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}

		public override bool CanUseItem(Player player)
		{
			return player.miscEquips[0].IsAir;
		}
	}
}