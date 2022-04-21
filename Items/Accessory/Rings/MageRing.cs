using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class MageRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mage Ring");
            Tooltip.SetDefault("Mana Regen\nMana Magnet.");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaRegen = 2;
            player.manaMagnet = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GoldRingAmethyst>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.SilverRingAmber>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}