using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Projectiles.Sword.Iceblade
{
    public class AirBladeProj : ModProjectile //You will need to add sprites for them
    {
        public override void SetDefaults()
        {
            projectile.ignoreWater = false;
            projectile.width = 24;
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

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(SoundID.Dig, projectile.position);
            return false;
        }
    }
}