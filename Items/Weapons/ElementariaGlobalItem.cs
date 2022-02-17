using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Projectiles.Melee;

namespace Elementaria
{
    public class ElementariaGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.CopperShortsword) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<SwordProj>();
                item.shootSpeed = 18f;
                item.channel = true;
                item.useTime = 10;
                item.useAnimation = 20;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.noUseGraphic = true;

            }
        }
    }
}