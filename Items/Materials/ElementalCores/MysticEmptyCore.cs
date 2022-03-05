using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials.Minerals;

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
			recipe.AddIngredient(ModContent.ItemType<StoneFragment>(), 1);
			recipe.AddIngredient(ModContent.ItemType<RareEmptyCore>(), 1);
			recipe.AddIngredient(ItemID.GoldOre, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}