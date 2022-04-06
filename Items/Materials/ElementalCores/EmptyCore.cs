using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials.Minerals;

using Elementaria.Tiles.CraftingStation;

namespace Elementaria.Items.Materials.ElementalCores
{
	public class EmptyCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Empty Core");
			Tooltip.SetDefault("A mystical stone, it can be used to create elemental cores");
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
			recipe.AddIngredient(ModContent.ItemType<StoneFragment>(), 5);
			recipe.AddTile(ModContent.TileType<ElementalPedestalTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}