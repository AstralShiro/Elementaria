using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class CriticalRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Critical Rune");
            Tooltip.SetDefault("Increase +5% Critical Chance.");
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
            player.meleeCrit += 5;
            player.magicCrit += 5;
            player.rangedCrit += 5;
            player.thrownCrit += 5;
        }
    }
}