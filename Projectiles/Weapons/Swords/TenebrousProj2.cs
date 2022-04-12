using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Projectiles.Weapons.Swords;

namespace Elementaria.Projectiles.Weapons.Swords
{
	class TenebrousProj2 : ModProjectile
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
			aiType = ProjectileID.Starfury;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.extraUpdates = 100;
			projectile.penetrate = -1;
			projectile.timeLeft = 200;

			projectile.damage = 15;

			
		}
		public override string Texture => "Terraria/Projectile_" + ProjectileID.None;
        public override void Kill(int timeLeft)
        {

        }
	}
}