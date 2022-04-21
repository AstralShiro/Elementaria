using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class GodlyRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GodlyRing");
            Tooltip.SetDefault("x2 Life Regen\n+150 Life\ndoubled invicibility period after an attack\nGives you an ice barrier\n+ 20 Defense.");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 28;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen = 10;
            player.statLifeMax2 += 150;
            player.statDefense += 20;
            player.longInvince = true;
            player.iceBarrier = true;
            player.starCloak = true;      
            player.gravControl = true;      
            player.manaRegen = 4;
            player.lifeMagnet = true;
            player.lavaImmune = true;
            player.manaMagnet = true;
            player.statManaMax2 += 50;
            player.magicDamage += 0.10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.EnduranceRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.SupremeVitalRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.SupremeStoneRing>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}