using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Dusts;

namespace Elementaria.Projectiles.Weapons.Swords.IceBlade
{
    public class AirBladeProj : ModProjectile //You will need to add sprites for them
    {
		public override void SetDefaults() 
        {
            projectile.ignoreWater = false;
            projectile.width = 2;
            projectile.penetrate = 1;
            projectile.height = 24;
            projectile.friendly = true;
            projectile.light = 1f;
            projectile.tileCollide = true;
            projectile.aiStyle = 28;
		}

        public override void AI()
        {
            if (Main.rand.NextBool(6))
            {
                Dust.NewDust(projectile.Center, projectile.width, projectile.height, DustID.Snow); //Add any dust here
            }
        }
    }
}