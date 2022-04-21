using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Armors.AncestralArmor
{
    [AutoloadEquip(EquipType.Legs)]
    public class AncestralArmorLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancestral Leggings");
            //Tooltip.SetDefault("Immune : Frost Burn\nMove Speed 10%\nTier 1");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Blue;
            item.defense = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.1f;
            player.buffImmune[BuffID.Frostburn] = true;
        }
    }
}