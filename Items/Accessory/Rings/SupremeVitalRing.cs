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
            Tooltip.SetDefault("Increase you life and give life regen. +100HP, Life regen (2HP per second)");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 10;
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen = 2;
            player.statLifeMax2 += 100;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.MysticEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.VitalRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.VitalRing>(), 1);
            recipe.AddIngredient(ItemID.LifeCrystal, 5);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT3Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}