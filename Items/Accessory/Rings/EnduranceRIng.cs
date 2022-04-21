using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class EnduranceRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endurance Ring");
            Tooltip.SetDefault("x2 Life Regen\n+75 Life\ndoubled invicibility period after an attack\nGives you an ice barrier.");
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
            player.lifeRegen = 10;
            player.statLifeMax2 += 75;
            player.longInvince = true;
            player.iceBarrier = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.VitalRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.TreeRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.CrystalRing>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}