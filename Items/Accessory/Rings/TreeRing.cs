using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class TreeRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree ring");
            Tooltip.SetDefault("doubled invicibility period after an attack");
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
            player.longInvince = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Powders.WoodPowder>(), 1);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}