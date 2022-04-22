using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class CrystalRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Ring");
            Tooltip.SetDefault("Made you invincible after hit for 2 seconds and made u immune to the lava.");
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
            player.immuneTime = 2;
            player.lavaImmune = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.DreamEmptyCore>());
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.ObsidianRing>(), 1);
            recipe.AddIngredient(ItemID.CrystalShard, 25);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT4Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}