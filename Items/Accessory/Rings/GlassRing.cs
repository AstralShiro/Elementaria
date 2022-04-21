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
            Tooltip.SetDefault("+30 Mana.");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 19;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 30;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Powders.GlassPowder>(), 1);
            recipe.AddIngredient(ItemID.Glass, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}