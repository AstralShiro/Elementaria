using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

using Elementaria.Projectiles;

namespace Elementaria.Items.Weapons.Sword
{
	class TestWeapon : ModItem
	{
		public override void SetDefaults()
		{
			item.width = item.height = 54;
            item.damage = 15;
            item.melee = true;
            item.knockBack = 4;
            item.crit = 10;
            item.useAnimation = 25;
            item.useTime = 25;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shootSpeed = 8f;
            item.rare = ItemRarityID.Purple;
            item.autoReuse = true;
			item.useTurn = false;

			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/DarkMagicSound");
			
            item.shoot = ModContent.ProjectileType<LightEnergy>();
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(position.X, position.Y, speedX - 1, speedY - 1, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}
    }
}