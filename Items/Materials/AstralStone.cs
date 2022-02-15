using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

namespace Elementaria.Items.Materials
{
	public class AstralStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Test"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A strange stone");
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
			recipe.AddIngredient(ModContent.ItemType<FireStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<IceStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<EarthStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<ThunderStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<LightStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<AirStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<DarkStone>(), 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}