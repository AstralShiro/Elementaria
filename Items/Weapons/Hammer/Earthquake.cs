using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;
using System;

namespace Elementaria.Items.Weapons.Hammer
{
	public class Earthquake : ModItem
    {
	    public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heartquacke"); 
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.width = 54;
            item.height = 56;
            item.damage = 60;
            item.melee = true;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useAnimation = item.useTime = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.shootSpeed = 1f;
            item.rare = ItemRarityID.Yellow;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<Projectiles.Weapons.Hammer.EarthquakeProj>();
            item.UseSound = SoundID.Item1;
        }
    }
}
