using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class GoldRingDiamond: ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold ring with diamond");
            Tooltip.SetDefault("Increase all damage : +30% Damage");
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
            player.meleeDamage += 0.3f;
            player.rangedDamage += 0.3f;
            player.magicDamage += 0.3f;
            player.thrownDamage += 0.3f;
            player.minionDamage += 0.3f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.MysticEmptyCore>(), 1);
            recipe.AddIngredient(ItemID.Diamond, 1);
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT3Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.MysticEmptyCore>(), 1);
            recipe.AddIngredient(ItemID.Diamond, 1);
            recipe.AddIngredient(ItemID.PlatinumBar, 2);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT3Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}