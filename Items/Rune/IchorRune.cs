using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class IchorRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ichor Rune");
            Tooltip.SetDefault("Apply Ichor in your attacks");
        }

        public override void SetDefaults()
        {
            item.accessory = true;

            item.width = 18;
            item.height = 32;
            item.value = Item.buyPrice(silver:20);

            item.rare = ItemRarityID.Yellow;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(BuffID.WeaponImbueIchor, 0, true);
        }
    }
}