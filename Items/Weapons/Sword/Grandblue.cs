using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria.Localization;
using System.Linq;
using Terraria.Utilities;

namespace Elementaria.Items.Weapons.Sword
{
	public class Grandblue : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Grandblue");
			Tooltip.SetDefault("The swords power grows as you progress\n Ends once you reach Hardmode.");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override bool CanUseItem(Player player)
		{
			if (NPC.downedSlimeKing)
				item.damage = 18;

			if (NPC.downedBoss1)
				item.damage = 23;

			if (NPC.downedBoss2)
				item.damage = 27;

			if (NPC.downedQueenBee)
				item.damage = 35;

			if (NPC.downedBoss3)
				item.damage = 41;
			
			if (Main.hardMode)
			{
				item.damage = 55;
				item.useTime = 10;
				item.useAnimation = 30;
				
			}
			return true;
		}

	       public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
               {
             	   target.AddBuff(BuffID.Chilled, 320);
               }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.Minerals.IceStone>(), 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
