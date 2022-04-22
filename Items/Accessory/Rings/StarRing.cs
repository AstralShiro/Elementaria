using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class StarRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Ring");
            Tooltip.SetDefault("Increases mana give mana regen and made rain stars fromw sky when u are hitted : +150 Mana, Mana regen (3 mana per second), Star cloak");
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
            player.statManaMax2 += 150;
            player.manaRegen += 3;
            player.starCloak = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.DreamEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.ArchmageRing>(), 1);
            recipe.AddIngredient(ItemID.ManaCrystal, 5);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT4Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}