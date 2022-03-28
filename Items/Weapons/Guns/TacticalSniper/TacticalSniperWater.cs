using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Items.Materials.ElementalCores.T1;
using Elementaria.Tiles.CraftingStation;
using Elementaria.Projectiles.Weapons.Guns.TacticalSniper;


namespace Elementaria.Items.Weapons.Guns.TacticalSniper
{
	public class TacticalSniperWater : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tactical Sniper Rifle (Water)");
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = item.useAnimation = 36;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/LaserShoot");
			item.autoReuse = false;
			item.shoot = ModContent.ProjectileType<TacticalSniperWaterProj>();
			item.shootSpeed = 16f;
			//item.useAmmo = AmmoID.Bullet;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<WaterCore>(), 10);
			recipe.AddTile(ModContent.TileType<ArcaneAnvilT2Tile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
