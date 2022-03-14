using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;
using System;

namespace Elementaria.Items.Weapons.Sword.IceBlade
{
	public class AirBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Air Blade"); 
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.width = 34;
            item.height = 40;
            item.damage = 17;
            item.melee = true;
            item.knockBack = 4;
            item.crit = 6;
            item.useAnimation = item.useTime = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shootSpeed = 2f;
            item.rare = ItemRarityID.White;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AirBladeProj");
        }
    }
}
       