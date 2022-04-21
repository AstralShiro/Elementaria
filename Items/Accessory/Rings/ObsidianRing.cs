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
            item.width = 25;
            item.height = 20;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lavaImmune = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Powders.ObsidianPowder>(), 1);
            recipe.AddIngredient(ItemID.Obsidian, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}