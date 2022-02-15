using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

namespace Elementaria.Items.Materials
{
	public class DarkStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A dark stone");
		}

		public override void SetDefaults() {
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<StoneFragment>(), 10);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<StoneFragment>(), 10);
			recipe.AddIngredient(ItemID.EbonstoneBlock, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}