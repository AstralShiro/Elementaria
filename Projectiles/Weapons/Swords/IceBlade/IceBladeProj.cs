using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Shaders;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Elementaria.Projectiles.Weapons.Swords.IceBlade
{
    public class IceBladeProj : ModProjectile //You will need to add sprites for them
    {
		public override void SetDefaults() 
        {
            projectile.ignoreWater = false;
            projectile.width = 10;
            projectile.height = 18;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.light = 1f;
            projectile.tileCollide = true;
            projectile.aiStyle = 28;
		}

        public override void AI()
        {
			projectile.rotation = projectile.velocity.ToRotation() + 1.57f;
        }
    }
}