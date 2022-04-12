using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

using Elementaria.Buffs.PetBuff;

namespace Elementaria.Projectiles.PetsProj
{
    public class MarshyButterflyProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Marshy Butterfly");
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 20;
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];

            if (!player.dead && player.HasBuff(ModContent.BuffType<MarshyButterflyBuff>()))
            {
                projectile.timeLeft = 2;
            }
        }
    }
}