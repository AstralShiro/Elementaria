using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.Audio;

namespace Elementaria.Projectiles.Bosses
{
	public class TestProj : ModProjectile
	{	
	int timer = 0;
		public override void SetDefaults()
		{

			projectile.width = projectile.height = 12;
			projectile.hostile = true;
			projectile.aiStyle = 1;
			projectile.timeLeft = 1200;
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
			
			projectile.damage = 20;
		}

        public override void AI()
        {
			if (projectile.localAI[0] == 0f)
            {
                projectile.localAI[0] = 1f;
            }

			projectile.spriteDirection = projectile.velocity.X > 0 ? 1 : -1;
			
			{
				projectile.rotation += 0.2f;
				int num622 = Dust.NewDust(new Vector2(projectile.position.X - projectile.velocity.X, projectile.position.Y - projectile.velocity.Y), projectile.width, projectile.height, 168, 0f, 0f, 100, default(Color), 2f);
				Main.dust[num622].noGravity = true;
				Main.dust[num622].scale = 1.5f;

			}
			if(projectile.ai[0] <= 0)
			{
				Vector2 move = Vector2.Zero;
				float distance = 400f;
				bool target = false;
				for (int k = 0; k < 200; k++)
				{
					if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5)
					{
						Vector2 newMove = Main.npc[k].Center - projectile.Center;
						float distanceTo = (float)Math.Sqrt(newMove.X * newMove.X + newMove.Y * newMove.Y); //There's a method for this, but I'm lazy and just imported from ExampleMod.
						if (distanceTo < distance)
						{
							move = newMove;
							distance = distanceTo;
							target = true;
						}
					}
				}
				if (target)
				{
					AdjustMagnitude(ref move);
					projectile.velocity = (20 * projectile.velocity + move) / 11f;				AdjustMagnitude(ref projectile.velocity);
				}
			}
			else
			{
				projectile.ai[0]--; //Decrease the timer set from spawn. Can be set to 0 manually to home instantly instead.
			}
			
		}

		void AdjustMagnitude(ref Vector2 vector)
		{
			float magnitude = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
			if (magnitude > 6f)
			{
				vector *= 6f / magnitude;	
			}
		}
	}
}
