using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class GoldRingAmethyst : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold ring with amethyst");
            Tooltip.SetDefault("Increases minion damage : +20%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = 10;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage += 0.2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.EmptyCore>(), 1);
            recipe.AddIngredient(ItemID.Amethyst, 1);
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyTile>());
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.EmptyCore>(), 1);
            recipe.AddIngredient(ItemID.Amethyst, 1);
            recipe.AddIngredient(ItemID.PlatinumBar, 2);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyTile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}