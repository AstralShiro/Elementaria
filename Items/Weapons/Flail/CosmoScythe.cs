using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Projectiles.Weapons.Flail;

namespace Elementaria.Items.Weapons.Flail
{
	public class CosmoScythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmo Scythe");
			//Tooltip.SetDefault("Pulls enemies towards you");

		}
		public override void SetDefaults()
		{
			item.width = 54;
			item.height = 54;
			item.rare = ItemRarityID.Orange;
			item.noMelee = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 16;
			item.useTime = 16;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 1, 20, 0);
			item.damage = 14;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<CosmoScytheProj>();
			item.shootSpeed = 18f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.melee = true;
			item.channel = true;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 direction9 = new Vector2(speedX, speedY);
			Projectile.NewProjectile(position, direction9, type, damage, knockBack, player.whoAmI, direction9.X, direction9.Y);
			return false;
		}
	}
}