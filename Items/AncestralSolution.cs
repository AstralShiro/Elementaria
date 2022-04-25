using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Items.Powders;

namespace Elementaria.Items
{
	public class AncestralSolution : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ancestral Soluton");
			Tooltip.SetDefault("Used by the Clentaminator"
				+ "\nSpreads the Ancestral");
		}

		public override void SetDefaults() {
			item.shoot = ModContent.ProjectileType<Projectiles.AncestralSolutionProj>() - ProjectileID.PureSpray;
			item.ammo = AmmoID.Solution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = ItemRarityID.Orange;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<AncestralPowder>(), 5);
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}
