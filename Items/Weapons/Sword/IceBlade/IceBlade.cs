using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;
using System;

using Elementaria.Projectiles.Weapons.Swords.IceBlade;

namespace Elementaria.Items.Weapons.Sword.IceBlade
{
	public class IceBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Water Blade"); 
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults() 
		{
            item.width = 34;
            item.height = 40;
            item.damage = 12;
            item.melee = true;
            item.knockBack = 4;
            item.crit = 6;
            item.useAnimation = 35;
            item.useTime = 35;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shootSpeed = 8f;
            item.rare = ItemRarityID.White;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<IceBladeProj>();
            item.UseSound = SoundID.Item28;
        }
    }
}
       