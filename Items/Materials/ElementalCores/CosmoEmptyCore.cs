using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Tiles.CraftingStation;

namespace Elementaria.Items.Materials.ElementalCores
{
	public class CosmoEmptyCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cosmo Empty Core");
			Tooltip.SetDefault("A mystical stone, it can be used to Cosmo elemental cores");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.White;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<CosmoHeart>(), 1);
			recipe.AddIngredient(ModContent.ItemType<EmptyCore>(), 1);
			recipe.AddTile(ModContent.TileType<ElementalPedestalTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}