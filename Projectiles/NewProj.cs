using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Projectiles.Weapons.Swords;

namespace Elementaria.Projectiles
{
	class NewProj : ModProjectile
	{
		int timer = 0;
		bool launch = false;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tenebrous");
		}
		public override void SetDefaults()
		{
			projectile.width = projectile.height = 4;
			projectile.aiStyle = 112;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.melee = true;
			projectile.extraUpdates = 100;
			projectile.penetrate = -1;
			projectile.timeLeft = 200;

			projectile.tileCollide = false;

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
					int dust = Dust.NewDust(projectilePosition, 1, 1, 198, 0f, 0f, 0, default(Color), 1f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].position = projectilePosition;
					Main.dust[dust].scale = (float)Main.rand.Next(70, 110) * 0.013f;
					Main.dust[dust].velocity *= 0.2f;
				}
			}
		}
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
			int projectiles = 12; //Change this number to however many you'd like (Even 100, if you want, though I don't recommend it)
			float radius = 50f; //change to a value to change the radius of the circle.
			for(int i = 0; i < projectiles; i++)
			{
				Projectile.NewProjectile( target.Center+(Vector2.One.RotatedBy(MathHelper.ToRadians(i*(360/projectiles))))*radius, Vector2.Zero, ModContent.ProjectileType<TenebrousProj2>(), 20, 0f, projectile.owner, 120);
			}
		}

        public override void Kill(int timeLeft)
        {

        }
	}
}
