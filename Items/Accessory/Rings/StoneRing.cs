using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class StoneRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone ring");
            Tooltip.SetDefault("Increase your defense. +5 Defense");
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
            player.statDefense += 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.RareEmptyCore>(), 1);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT2Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}