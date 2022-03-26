using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class VenomRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Venom Rune");
            Tooltip.SetDefault("Apply Venom in your attacks");
        }

        public override void SetDefaults()
        {
            item.accessory = true;

            item.width = 18;
            item.height = 32;
            item.value = Item.buyPrice(silver:20);

            item.rare = ItemRarityID.Purple;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(BuffID.WeaponImbueVenom, 0, true);
        }
    }
}