using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace Elementaria.Items.Materials.Minerals
{
	public class AstralStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Astral stone");
			Tooltip.SetDefault("A strange stone");
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
			recipe.AddIngredient(ModContent.ItemType<FireStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<IceStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<EarthStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<ThunderStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<HallowStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<AirStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<DarkStone>(), 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}