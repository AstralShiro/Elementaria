using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

using Elementaria.Tiles.CraftingStation;
using Elementaria.Items.Materials.Globe;

namespace Elementaria.Items.Materials.ElementalCores.T4
{
	public class DreamWaterCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dream Water Core");
			Tooltip.SetDefault("A powerful and bright dream elemental core, allows you to create water element weapons");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Green;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DreamEmptyCore>(), 1);
			recipe.AddIngredient(ModContent.ItemType<WaterGlobe>(), 1);
			recipe.AddTile(ModContent.TileType<ElementalPedestalTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}