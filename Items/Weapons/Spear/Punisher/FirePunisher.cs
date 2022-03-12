using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Weapons.Spear.Punisher
{
    public class FirePunisher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Punisher");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.useTime = 32;
            item.useAnimation = 40;
            item.knockBack = 4f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = false;
            item.useStyle = 5;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.LightRed;
            item.shoot = mod.ProjectileType("FirePunisherProj");
            item.shootSpeed = 5f;
            item.crit = 10;
        }
    }
}