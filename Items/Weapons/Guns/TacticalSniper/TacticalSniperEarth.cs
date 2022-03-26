using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Items.Materials.ElementalCores.T1;
using Elementaria.Tiles.CraftingStation;
using Elementaria.Projectiles.Weapons.Guns.TacticalSniper;

namespace Elementaria.Items.Weapons.Guns.TacticalSniper
{
	public class TacticalSniperEarth : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tactical Sniper Rifle (Earth)");
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 36;
			item.useAnimation = 50;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item33;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<TacticalSniperDarkProj>();
			item.shootSpeed = 16f;
			//item.useAmmo = AmmoID.Bullet;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<EarthCore>(), 10);
			recipe.AddTile(ModContent.TileType<ArcaneAnvilT2Tile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
