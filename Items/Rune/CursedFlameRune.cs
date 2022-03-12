using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Elementaria.Items.Rune
{
    public class CursedFlameRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Curse Flamge Rune");
            Tooltip.SetDefault("Apply Cursed Flame in your attacks");
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
            player.AddBuff(BuffID.WeaponImbueCursedFlames, 0, true);
        }
    }
}