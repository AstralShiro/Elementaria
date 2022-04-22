using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class EnduranceRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endurance Ring");
            Tooltip.SetDefault("Increase your defense but decrease your movement speed. +15 denfese, -14 movement speed.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 10;
            item.rare =  4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 15;
            player.moveSpeed -= 0.14f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.DreamEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.SupremeStoneRing>(), 1);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT4Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}