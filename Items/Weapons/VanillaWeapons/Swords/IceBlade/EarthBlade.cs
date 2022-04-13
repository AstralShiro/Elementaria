using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;
using System;

using Elementaria.Items.Materials.ElementalCores.T1;
using Elementaria.Tiles.CraftingStation;

namespace Elementaria.Items.Weapons.VanillaWeapons.Swords.IceBlade
{
	public class EarthBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Earth Blade"); 
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.width = 34;
            item.height = 40;
            item.damage = 12;
            item.melee = true;
            item.knockBack = 4;
            item.crit = 6;
            item.useAnimation = 35;
            item.useTime = 35;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shootSpeed = 8f;
            item.rare = ItemRarityID.White;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("EarthBladeProj");

            item.UseSound = SoundID.Item28;
        }
        public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<EarthCore>(), 1);
            recipe.AddIngredient(ItemID.IceBlade, 1);
            recipe.AddTile(ModContent.TileType<ArcaneAnvilTile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}
       