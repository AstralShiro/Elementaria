using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

using Elementaria.Projectiles.Weapons.Shortswords;

namespace Elementaria.Items.Weapons.Staff
{
	class MagiaPitareen : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 56;
            item.height = 58;
            item.damage = 115;
            item.melee = true;
            item.knockBack = 4;
            item.crit = 10;
            item.useAnimation = 25;
            item.useTime = 25;
            item.useStyle = ItemUseStyleID.HoldingUp;

            item.rare = ItemRarityID.Purple;
            item.autoReuse = true;
			item.useTurn = false;
            item.UseSound = SoundID.Item1;

            //item.shoot =
            //item.shootSpeed =
		}
    }
}