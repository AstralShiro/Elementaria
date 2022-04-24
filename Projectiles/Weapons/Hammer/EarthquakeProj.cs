using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Projectiles.Weapons.Hammer
{
	class EarthquakeProj : ModProjectile
	{
		int timer = 0;
		bool launch = false;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earthquacke");
		}
		public override void SetDefaults()
		{
			projectile.width = projectile.height = 4;
			projectile.aiStyle = 135;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.melee = true;
			projectile.extraUpdates = 100;
			projectile.penetrate = -1;
			projectile.timeLeft = 200;

			projectile.damage = 15;
			
		}
		public override string Texture => "Terraria/Projectile_" + ProjectileID.None;
		public override void AI()
		{
			projectile.localAI[0] += 1f;
			if (projectile.localAI[0] > 9f)
			{
				for (int i = 0; i < 4; i++)
				{
					Vector2 projectilePosition = projectile.position;
					projectilePosition -= projectile.velocity * ((float)i * 0.25f);
					projectile.alpha = 255;
					// Important, changed 173 to 178!
					int dust = Dust.NewDust(projectilePosition, 1, 1, 174, 0f, 0f, 0, default(Color), 1f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].position = projectilePosition;
					Main.dust[dust].scale = (float)Main.rand.Next(70, 110) * 0.013f;
					Main.dust[dust].velocity *= 0.2f;
				}
			}
		}
        public override void Kill(int timeLeft)
        {

        }
	}
}
