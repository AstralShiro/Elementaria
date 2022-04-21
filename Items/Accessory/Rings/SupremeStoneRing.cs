using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class SupremeStoneRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Supreme Stone ring");
            Tooltip.SetDefault("+ 20 Defense");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 28;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 20;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.StoneRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.StoneRing>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}