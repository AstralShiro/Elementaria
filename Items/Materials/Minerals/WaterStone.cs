using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

namespace Elementaria.Items.Materials.Minerals
{
	public class WaterStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Water stone");
			Tooltip.SetDefault("A wet stone");
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
			recipe.AddIngredient(ItemID.SandBlock, 10);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}