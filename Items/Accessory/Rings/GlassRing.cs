using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class GlassRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glass Ring");
            Tooltip.SetDefault("Increase all damage : +40% Damage");
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
            player.meleeDamage += 0.4f;
            player.rangedDamage += 0.4f;
            player.magicDamage += 0.4f;
            player.thrownDamage += 0.4f;
            player.minionDamage += 0.4f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.DreamEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<GoldRingDiamond>(), 1);
            recipe.AddIngredient(ItemID.Glass, 25);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT4Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}