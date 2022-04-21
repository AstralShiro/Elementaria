using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace Elementaria.Projectiles.Bosses.EarthTransf
{
    public class EarthSpikeKillProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Poisoned smoke");
        }

        public override void SetDefaults()
        {
            projectile.damage = 0;
            projectile.width = 33;
            projectile.height = 31;
            projectile.aiStyle = -1;
            projectile.hostile = true;
            projectile.friendly = false;
            projectile.melee = true;
            projectile.penetrate = 3;
            Main.projFrames[projectile.type] = 5;
            
			projectile.timeLeft = 200;
        }

        public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            if (Main.rand.NextBool(3))
            {
                player.AddBuff(BuffID.Poisoned, 2500, true);
            }
        }
    }
}