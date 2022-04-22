using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Tiles.CraftingStation;

namespace Elementaria.Items.Accessory.Rings
{
    public class ArchmageRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Archmage Ring");
            Tooltip.SetDefault("Increases mana : +100 Mana, Mana regen (2 mana per second)");
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
            player.statManaMax2 += 100;
            player.manaRegen += 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.MysticEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.MageRing>(), 1);
            recipe.AddIngredient(ItemID.ManaCrystal, 5);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT3Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}