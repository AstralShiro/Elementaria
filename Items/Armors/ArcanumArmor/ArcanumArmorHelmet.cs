using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Armors.ArcanumArmor
{
    [AutoloadEquip(EquipType.Head)]
    public class ArcanumArmorHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcanum helmet");
            //Tooltip.SetDefault("Immune : Frozen\nMelee Damage 5%\nTier 1");

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
            player.buffImmune[BuffID.Frozen] = true;
            player.meleeDamage += 0.05f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ArcanumArmorChestplate") && legs.type == mod.ItemType("ArcanumArmorLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Ice resistance";
            player.AddBuff(BuffID.Warmth, 1);
        }
    }
}