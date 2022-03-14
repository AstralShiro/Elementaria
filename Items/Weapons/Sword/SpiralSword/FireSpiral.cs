using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace Elementaria.Items.Weapons.Sword.SpiralSword
{
	public class FireSpiral : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Magma Spiral");
			Tooltip.SetDefault("Apply On Fire when you hit the enemies");
		}

		public override void SetDefaults() 
		{
			item.damage = 15;

			item.melee = true;

			item.width = 64;
			item.height = 62;

			item.useTime = 35;
			item.useAnimation = 35;

			item.useStyle = 1;

			item.knockBack = 6;

			item.value = Item.sellPrice(silver: 13);

			item.rare = ItemRarityID.White;

			item.UseSound = SoundID.Item1;

			item.autoReuse = true;
			item.useTurn = true;

			item.buffType = BuffID.OnFire;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.ElementalCores.T1.EarthCore>(), 1);
			recipe.AddIngredient(ItemID.Hellstone, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}