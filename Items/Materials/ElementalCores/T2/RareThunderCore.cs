using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

using Elementaria.Tiles.CraftingStation;
using Elementaria.Items.Materials.Globe;

namespace Elementaria.Items.Materials.ElementalCores.T2
{
	public class RareThunderCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Rare Thunder Core");
			Tooltip.SetDefault("A powerful and bright rare elemental core, allows you to create thunder element weapons");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Yellow;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<RareEmptyCore>(), 1);
			recipe.AddIngredient(ModContent.ItemType<ThunderGlobe>(), 1);
			recipe.AddTile(ModContent.TileType<ElementalPedestalTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}