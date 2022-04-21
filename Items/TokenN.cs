using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items
{

    public class TokenN : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Token N");
            Tooltip.SetDefault("Use it for craft cosmetics. -Dev stuff-");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.rare = 12;
            item.value = Item.sellPrice(copper: 50);
            item.maxStack = 29;
        }
    }
}