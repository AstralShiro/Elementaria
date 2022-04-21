using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class ArchmageRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Archmage Ring");
            Tooltip.SetDefault("2x Mana Regen\nMana Magnet\n+50 Mana.");
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 27;
            item.value = 10;
            item.rare = -12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaRegen = 4;
            player.manaMagnet = true;
            player.statManaMax2 += 50;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.MageRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GlassRing>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}