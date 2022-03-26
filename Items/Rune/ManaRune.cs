using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class ManaRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mana Rune");
            Tooltip.SetDefault("Increase +50 Mana");
        }

        public override void SetDefaults()
        {
            item.accessory = true;

            item.width = 18;
            item.height = 32;
            item.value = Item.buyPrice(silver:20);

            item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 50;
        }
    }
}