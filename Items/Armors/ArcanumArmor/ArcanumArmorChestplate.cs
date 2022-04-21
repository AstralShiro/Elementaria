using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Armors.ArcanumArmor
{
    [AutoloadEquip(EquipType.Body)]
    public class ArcanumArmorChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Arcanum chestplate");
            //Tooltip.SetDefault("Immune : Chilled\nMelee speed 5%\nTier 1");

        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 24;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Blue;
            item.defense = 4; //How much armour it gives you
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Chilled] = true;
            player.meleeSpeed += 0.05f;
        }
    }
}