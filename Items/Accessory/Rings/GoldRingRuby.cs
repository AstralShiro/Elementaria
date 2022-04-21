using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class GoldRingRuby : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold ring with ruby");
            Tooltip.SetDefault("+30 Life.");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 37;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 30;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Powders.RubyPowder>(), 1);
            recipe.AddIngredient(ItemID.GoldOre, 5);
            recipe.AddIngredient(ItemID.Ruby, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Powders.RubyPowder>(), 1);
            recipe.AddIngredient(ItemID.PlatinumOre, 5);
            recipe.AddIngredient(ItemID.Ruby, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}