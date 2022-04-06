using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Tiles.CraftingStation;

namespace Elementaria.Items.Materials.ElementalCores
{
	public class MysticEmptyCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mystic Empty Core");
			Tooltip.SetDefault("A rare mystical stone, it can be used to create Supreme elemental cores");
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
			recipe.AddIngredient(ModContent.ItemType<PlanteraHeart>(), 1);
			recipe.AddIngredient(ModContent.ItemType<EmptyCore>(), 1);
			recipe.AddTile(ModContent.TileType<ElementalPedestalTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}