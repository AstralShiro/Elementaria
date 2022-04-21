using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class SupremeVitalRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Supreme Vital Ring");
            Tooltip.SetDefault("x2 Life Regen\n+120 Life.");
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
            player.statLifeMax2 += 120;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GoldRingRuby>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GoldRingRuby>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GoldRingRuby>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GoldRingRuby>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.VitalRing>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}