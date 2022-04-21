using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class GoldRingAmethyst : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold ring with amethyst");
            Tooltip.SetDefault("Increases pick-up range for mana stars.");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 33;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaMagnet = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Powders.AmethystPowder>(), 1);
            recipe.AddIngredient(ItemID.Amethyst, 5);
            recipe.AddIngredient(ItemID.GoldOre, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Powders.AmethystPowder>(), 1);
            recipe.AddIngredient(ItemID.Amethyst, 5);
            recipe.AddIngredient(ItemID.PlatinumOre, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}