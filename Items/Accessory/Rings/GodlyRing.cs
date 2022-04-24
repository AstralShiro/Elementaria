using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Accessory.Rings
{
    public class GodlyRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GodlyRing");
            Tooltip.SetDefault("Give all the effects of the rings\n+50 damage\nLife regen (4 HP per second)\nMana regen (4 Mana per second)\nStar cloak\n+20 defense\n+20 movement speed\n+200 HP\n+200 Mana\nStar Cloak\nLava immune\nInvincibilty when you are hitted for a little time");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.value = 10;
            item.rare = 5;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 0.5f;
            player.rangedDamage += 0.5f;
            player.magicDamage += 0.5f;
            player.thrownDamage += 0.5f;
            player.minionDamage += 0.5f;
            player.lifeRegen = 4;
            player.statLifeMax2 += 200;
            player.statManaMax2 += 200;
            player.manaRegen += 4;
            player.starCloak = true;
            player.statDefense += 20;
            player.moveSpeed -= 0.15f;
            player.immune =true;
            player.lavaImmune = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.CosmoEmptyCore>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.GlassRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.TreeRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.StarRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.EnduranceRing>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Accessory.Rings.CrystalRing>(), 1);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.ArcaneSmithyTSTile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}