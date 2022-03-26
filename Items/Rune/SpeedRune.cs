using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class SpeedRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Speed Rune");
            Tooltip.SetDefault("Increase your movement speed +20%");
        }

        public override void SetDefaults()
        {
            item.accessory = true;

            item.width = 18;
            item.height = 32;
            item.value = Item.buyPrice(silver:20);

            item.rare = ItemRarityID.Green;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.2f;
        }
    }
}