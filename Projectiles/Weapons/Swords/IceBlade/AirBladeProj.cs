using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Shaders;

namespace Elementaria.Projectiles.Weapons.Swords.IceBlade
{
    public class AirBladeProj : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Air bolt");
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;

            projectile.friendly = true;
            projectile.hostile = false;
            
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.timeLeft = 90;
        }
        public override Color? GetAlpha(Color lightColor)
		{
			return new Color(20, 140, 250, 100);
		}
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            {
            if (Main.rand.NextBool(3))
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.height, projectile.width, ModContent.DustType<IceNpcDust>(),
                    projectile.velocity.X * .2f, projectile.velocity.Y * .2f, 150, Scale: 1.2f);
                dust.velocity += projectile.velocity * 0.3f;
                dust.velocity *= 0.2f;
            }
            }
        }
    }
}