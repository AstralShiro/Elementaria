using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class SilverRingEmerald : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver ring with emerald");
            Tooltip.SetDefault("Increases ranged damage : +20%");
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
            player.rangedDamage += 0.2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.EmptyCore>(), 1);
            recipe.AddIngredient(ItemID.Emerald, 1);
            recipe.AddIngredient(ItemID.SilverBar, 2 );
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyTile>());
            recipe.SetResult(this);
            recipe.AddRecipe();

            new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.EmptyCore>(), 1);
            recipe.AddIngredient(ItemID.Emerald, 1);
            recipe.AddIngredient(ItemID.TungstenBar, 2 );
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyTile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}