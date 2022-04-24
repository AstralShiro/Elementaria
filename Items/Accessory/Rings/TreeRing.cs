using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class TreeRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree ring");
            Tooltip.SetDefault("Increase you life and give life regen. +150HP, Life regen (3HP per second)");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 10;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen = 3;
            player.statLifeMax2 += 150;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.DreamEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.SupremeVitalRing>(), 1);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT4Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}