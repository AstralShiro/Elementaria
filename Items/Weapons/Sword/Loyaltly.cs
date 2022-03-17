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

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            Vector2 pos = item.Center -  Main.screenPosition;
            Texture2D texture = Main.itemTexture[item.type];
            Texture2D spot = ModContent.GetTexture("Elementaria/Textures/Spotlight");
            float alpha = 0.8f;
            float s = 0.5f * scale;

            for (int i = 0; i < 6; i++)
            {
                spriteBatch.Draw(
                    spot,
                    pos,
                    null,
                    Color.Lerp(Color.White, Color.LightYellow, (float)i / 3) * alpha,
                    0f,
                    new Vector2(spot.Width, spot.Height) / 2,
                    s * (1f + ((float)Math.Sin((Main.GlobalTime * 2) + (MathHelper.PiOver4 * i)) * 0.15f)),
                    SpriteEffects.None,
                    0f);
                s *= 2;
                alpha *= 0.9f;
            }
            spriteBatch.Draw(texture, pos, null, Color.White, -MathHelper.PiOver4, new Vector2(texture.Width, texture.Height) / 2, scale, SpriteEffects.None, 0f);
            return false;
        }
    }
}