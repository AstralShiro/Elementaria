using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using System;
using Terraria.ID;

namespace Elementaria.Projectiles
{
	public class Empty : ModProjectile
	{
		public override string Texture => "Terraria/Projectile_" + ProjectileID.None;
		public override void SetDefaults()
		{
			
		}
	}
}