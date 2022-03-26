using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class LifeRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Rune");
            Tooltip.SetDefault("Increase +50 Life");
        }

        public override void SetDefaults()
        {
            item.accessory = true;

            item.width = 18;
            item.height = 32;
            item.value = Item.buyPrice(silver:20);

            item.rare = ItemRarityID.Red;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 50;
        }
    }
}