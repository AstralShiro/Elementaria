using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Projectiles.Weapons.Shortswords;

namespace Elementaria.Items.Weapons
{
    public class ElementariaGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.CopperShortsword) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<CopperShortswordProj>();
                item.shootSpeed = 18f;
                item.channel = true;
                item.useTime = 10;
                item.useAnimation = 20;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.noUseGraphic = true;

            }

            if (item.type == ItemID.GoldShortsword) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<GoldShortswordProj>();
                item.shootSpeed = 18f;
                item.channel = true;
                item.useTime = 10;
                item.useAnimation = 20;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.noUseGraphic = true;

            }

            if (item.type == ItemID.LeadShortsword) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<LeadShortswordProj>();
                item.shootSpeed = 18f;
                item.channel = true;
                item.useTime = 10;
                item.useAnimation = 20;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.noUseGraphic = true;

            }

            if (item.type == ItemID.PlatinumShortsword) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<PlatinumShortswordProj>();
                item.shootSpeed = 18f;
                item.channel = true;
                item.useTime = 10;
                item.useAnimation = 20;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.noUseGraphic = true;

            }
            
            if (item.type == ItemID.SilverShortsword) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<SilverShortswordProj>();
                item.shootSpeed = 18f;
                item.channel = true;
                item.useTime = 10;
                item.useAnimation = 20;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.noUseGraphic = true;

            }

            if (item.type == ItemID.TinShortsword) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<TinShortswordProj>();
                item.shootSpeed = 18f;
                item.channel = true;
                item.useTime = 10;
                item.useAnimation = 20;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.noUseGraphic = true;

            }

            if (item.type == ItemID.TungstenShortsword) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<TungstenShortSwordProj>();
                item.shootSpeed = 18f;
                item.channel = true;
                item.useTime = 10;
                item.useAnimation = 20;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.noUseGraphic = true;

            }

            if (item.type == ItemID.Umbrella) //Just add all the short swords
            {
                item.shoot = ModContent.ProjectileType<UmbrellaProj>();
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