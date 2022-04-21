using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Placeable
{
    public class EmptyWorkTable : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Work table");
            Tooltip.SetDefault("Principal item for craft the crafting stations");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 20;
            item.rare = 1;
            item.value = Item.sellPrice(copper: 50);
            item.maxStack = 99;
        }
		public override void AddRecipes()
		{
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Wood, 10);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
		}
    }
}