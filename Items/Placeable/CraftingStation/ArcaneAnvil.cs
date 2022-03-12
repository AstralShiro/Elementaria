using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Elementaria.Items.Placeable.CraftingStation
{
	public class ArcaneAnvil : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcane Anvil");
			Tooltip.SetDefault("Crafting station for craft the Weapons");
		}

		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.CraftingStation.ArcaneAnvilTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench, 1);
			recipe.AddIngredient(ItemID.IronAnvil, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			///
			new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench, 1);
			recipe.AddIngredient(ItemID.LeadAnvil, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
;			recipe.AddRecipe();
		}
	}
}