using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using System.Reflection.Emit;

namespace Elementaria.Projectiles.Bosses.EarthTransf
{
    public class EarthSpikeProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Earth Spike");
        }

        public override void SetDefaults()
        {
            projectile.damage = 25;
            projectile.width = 14;
            projectile.height = 38;
            projectile.aiStyle = -1;
            projectile.hostile = true;
            projectile.friendly = false;
            projectile.melee = true;
            projectile.penetrate = 3;
        }

        public override void Kill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0f, 0f, mod.ProjectileType("EarthSpikeKillProj"), projectile.damage, projectile.knockBack, projectile.owner, 0f, 0f);
        }
    }
}
