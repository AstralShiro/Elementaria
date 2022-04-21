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
            Tooltip.SetDefault("Stars fall down upon being damaged");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 18;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.starCloak = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Powders.GlassPowder>(), 1);
            recipe.AddIngredient(ItemID.FallenStar, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}