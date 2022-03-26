using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class FireRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Rune");
            Tooltip.SetDefault("Apply On Fire in your attacks");
        }

        public override void SetDefaults()
        {
            item.accessory = true;

            item.width = 18;
            item.height = 32;
            item.value = Item.buyPrice(silver:20);

            item.rare = ItemRarityID.LightRed;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(BuffID.WeaponImbueFire, 0, true);
        }
    }
}