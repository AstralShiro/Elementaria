using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class VitalRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vital Ring");
            Tooltip.SetDefault("Increase you life. +50HP");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 10;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 50;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.RareEmptyCore>(), 1);
            recipe.AddIngredient(ItemID.LifeCrystal, 5);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT2Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}