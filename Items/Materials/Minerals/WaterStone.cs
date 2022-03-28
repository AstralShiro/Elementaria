using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace Elementaria.Items.Materials.Minerals
{
	public class WaterStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Water stone");
			Tooltip.SetDefault("A wet stone");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5,6));
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