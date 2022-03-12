using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Elementaria.Items.Placeable.CraftingStation
{
	public class ArcaneSmithy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcane Smithy");
			Tooltip.SetDefault("Crafting station for craft the Armors");
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
			item.createTile = TileType<Tiles.CraftingStation.ArcaneSmithyTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
;			recipe.AddRecipe();
		}
	}
}