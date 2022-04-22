using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class ObsidianRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Obsidian ring");
            Tooltip.SetDefault("Lava immune");
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
            player.lavaImmune = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.MysticEmptyCore>(), 1);
            recipe.AddIngredient(ItemID.Obsidian, 2);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT3Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}