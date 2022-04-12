using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

using Elementaria.Projectiles.Weapons.Swords;

namespace Elementaria.Items.Weapons.Sword
{
	class Tenebrous : ModItem
	{
		public override void SetDefaults()
		{
			item.width = item.height = 54;
            item.damage = 15;
            item.melee = true;
            item.knockBack = 4;
            item.crit = 10;
            item.useAnimation = 25;
            item.useTime = 25;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shootSpeed = 8f;
            item.rare = ItemRarityID.Purple;
            item.autoReuse = true;
			item.useTurn = false;

			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/DarkMagicSound");
			
            item.shoot = ModContent.ProjectileType<TenebrousProj>();
		}
    }
}