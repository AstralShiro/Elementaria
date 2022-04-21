using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Powders
{

    public class GlassPowder : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glass powder");
            Tooltip.SetDefault("use for various crafts");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 14;
            item.rare = 1;
            item.value = Item.sellPrice(copper: 50);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glass, 5);
            recipe.AddTile(ModContent.TileType<Tiles.CraftingStation.Mortar>());
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}