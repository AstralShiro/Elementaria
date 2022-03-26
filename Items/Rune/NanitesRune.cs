using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class NanitesRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nanites Rune");
            Tooltip.SetDefault("Apply Confusion in your attacks");
        }

        public override void SetDefaults()
        {
            item.accessory = true;

            item.width = 18;
            item.height = 32;
            item.value = Item.buyPrice(silver:20);

            item.rare = ItemRarityID.LightPurple;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(BuffID.WeaponImbueNanites, 0, true);
        }
    }
}