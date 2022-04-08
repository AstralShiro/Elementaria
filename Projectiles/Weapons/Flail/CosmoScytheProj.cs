using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ModLoader;

namespace Elementaria.Projectiles.Weapons.Flail
{
	public class CosmoScytheProj : ModProjectile
	{
		private const string ChainTexturePath = "Elementaria/Projectiles/Weapons/Flail/CosmoScythe_Chain";

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmo Scythe");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 900;
			projectile.melee = true;
			projectile.ignoreWater = true;
		}
		//  bool comingHome = false;
		public override bool PreAI()
		{
			// projectile.velocity.Y += .0625f;
			if (projectile.Hitbox.Intersects(Main.player[projectile.owner].Hitbox) && projectile.timeLeft < 870) {
				projectile.active = false;
			}
			if (projectile.timeLeft < 869) {
				Vector2 direction9 = Main.player[projectile.owner].Center - projectile.position;
				projectile.velocity = projectile.velocity.RotatedBy(direction9.ToRotation() - projectile.velocity.ToRotation());
				if (projectile.velocity.Length() < 18) {
					projectile.velocity *= 1.075f;
				}
				if (projectile.velocity.Length() < 0.5f) {
					direction9.Normalize();
					projectile.velocity = direction9 * 2;
				}
				projectile.rotation = projectile.velocity.ToRotation() + 1.57f;
				projectile.tileCollide = false;
			}
			else {
				projectile.velocity -= new Vector2(projectile.ai[0], projectile.ai[1]) / 30f;
				projectile.rotation = new Vector2(projectile.ai[0], projectile.ai[1]).ToRotation() - 1.57f;
			}
			return false;
		}
		//projectile.ai[0]: X speed initial
		//projectile.ai[1]: y speed initial
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			for (int i = 0; i < 20; i++) {
				int num = Dust.NewDust(target.position, target.width, target.height, 199, 0f, -2f, 0, default(Color), 2f);
				Main.dust[num].noGravity = true;
				Main.dust[num].position.X += Main.rand.Next(-50, 51) * .05f - 1.5f;
				Main.dust[num].position.Y += Main.rand.Next(-50, 51) * .05f - 1.5f;
				Main.dust[num].scale *= .85f;
				if (Main.dust[num].position != target.Center)
					Main.dust[num].velocity = target.DirectionTo(Main.dust[num].position) * 5f;
			}
		}
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 20; i++) {
				int num = Dust.NewDust(projectile.position, projectile.width, projectile.height, 199, 0f, -2f, 0, default(Color), 2f);
				Main.dust[num].noGravity = true;
				Main.dust[num].position.X += Main.rand.Next(-50, 51) * .05f - 1.5f;
				Main.dust[num].position.Y += Main.rand.Next(-50, 51) * .05f - 1.5f;
				Main.dust[num].scale *= .825f;
				if (Main.dust[num].position != projectile.Center)
					Main.dust[num].velocity = projectile.DirectionTo(Main.dust[num].position) * 5f;
			}
			return true;
		}
		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			var player = Main.player[projectile.owner];

			Vector2 mountedCenter = player.MountedCenter;
			Texture2D chainTexture = ModContent.GetTexture(ChainTexturePath);

			var drawPosition = projectile.Center;
			var remainingVectorToPlayer = mountedCenter - drawPosition;

			float rotation = remainingVectorToPlayer.ToRotation() - MathHelper.PiOver4;

			if (projectile.alpha == 0) {
				int direction = -1;

				if (projectile.Center.X < mountedCenter.X)
					direction = 1;

				player.itemRotation = (float)Math.Atan2(remainingVectorToPlayer.Y * direction, remainingVectorToPlayer.X * direction);
			}

			// This while loop draws the chain texture from the projectile to the player, looping to draw the chain texture along the path
			while (true) {
				float length = remainingVectorToPlayer.Length();

				// Once the remaining length is small enough, we terminate the loop
				if (length < 25f || float.IsNaN(length))
					break;

				// drawPosition is advanced along the vector back to the player by 12 pixels
				// 12 comes from the height of ExampleFlailProjectileChain.png and the spacing that we desired between links
				drawPosition += remainingVectorToPlayer * 12 / length;
				remainingVectorToPlayer = mountedCenter - drawPosition;

				// Finally, we draw the texture at the coordinates using the lighting information of the tile coordinates of the chain section
				Color color = Lighting.GetColor((int)drawPosition.X / 16, (int)(drawPosition.Y / 16f));
				spriteBatch.Draw(chainTexture, drawPosition - Main.screenPosition, null, color, rotation, chainTexture.Size() * 0.5f, 1f, SpriteEffects.None, 1f);
			}
			return true;
		}
	}
}
