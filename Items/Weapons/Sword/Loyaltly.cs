using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;
using System;

namespace Elementaria.Items.Weapons.Sword
{
	public class Loyaltly : ModItem
	{
	 public int currentAttack = 1;
        public override string Texture => "Elementaria/Items/Weapons/Sword/Loyaltly";
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Loyaltly"); 
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.width = item.height = 60;
            item.damage = 60;
            item.melee = true;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useAnimation = item.useTime = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.shootSpeed = 1f;
            item.rare = ItemRarityID.Yellow;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<Projectiles.Sword.Loyaltly>();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int dir = currentAttack;
            currentAttack = -currentAttack;
            Projectile.NewProjectile(position, new Vector2(speedX, speedY), type, damage, knockBack, player.whoAmI, 0, dir);
            return false;
        }
    }
}
