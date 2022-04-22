using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class SilverRingAmber : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold ring with amber");
            Tooltip.SetDefault("Increase all damage : +25% Damage");
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
            player.meleeDamage += 0.25f;
            player.rangedDamage += 0.25f;
            player.magicDamage += 0.25f;
            player.thrownDamage += 0.25f;
            player.minionDamage += 0.25f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.RareEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.SilverRingTopaz>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GoldRingAmethyst>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.SilverRingEmerald>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.SilverRingSapphire>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GoldRingRuby>(), 1);
            recipe.AddIngredient(ItemID.Amber, 1);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyT2Tile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}