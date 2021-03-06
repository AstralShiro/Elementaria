using Elementaria.Projectiles.Weapons.Swords.IceBlade;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Items.Materials.ElementalCores.T1;
using Elementaria.Tiles.CraftingStation;

namespace Elementaria.Items.Weapons.VanillaWeapons.Swords.IceBlade
{
	public class IceBlade : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Starfury V2");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.Starfury);
			item.shootSpeed *= 0.75f;
			item.damage = (int)(item.damage * 1.5);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			type = ModContent.ProjectileType<IceBladeProj>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
		public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<IceCore>(), 1);
            recipe.AddIngredient(ItemID.IceBlade, 1);
            recipe.AddTile(ModContent.TileType<ArcaneAnvilTile>());
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}