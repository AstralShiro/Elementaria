using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class SupremeStoneRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Supreme Stone ring");
            Tooltip.SetDefault("Increase your defense. +10 Defense");
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
            player.statDefense += 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.MysticEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.StoneRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.StoneRing>(), 1);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT3Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}