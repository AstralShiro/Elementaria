using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Projectiles.Weapons.Guns.TacticalSniper
{
    public class TacticalSniperHallowProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tactical Sniper Hallow Laser");
        }

        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 5;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.light = 0.5f;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
            projectile.scale = 1.75f;
            aiType = ProjectileID.GreenLaser;
        }
		public override Color? GetAlpha(Color lightColor) => new Color(230, 70, 175, 0);
        public override void Kill(int timeLeft) 
        {
            Main.PlaySound(SoundID.Item20, projectile.position);
        }
    }
}