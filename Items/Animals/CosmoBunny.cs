using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

using Elementaria.NPCs.VorumBiome.Animals;

namespace Elementaria.Items.Animals
{
    internal class CosmoBunny : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cosmo Bunny");
		}

            public override void SetDefaults() {
                //item.useStyle = 1;
                //item.autoReuse = true;
                //item.useTurn = true;
                //item.useAnimation = 15;
                //item.useTime = 10;
                //item.maxStack = 999;
                //item.consumable = true;
                item.width = 28;
                item.height = 26;
                //item.makeNPC = 360;
                //item.noUseGraphic = true;
                //item.bait = 15;

                //item.CloneDefaults(ItemID.);
                //item.bait = 17;
                item.makeNPC = (short)ModContent.NPCType<CosmoBunnyNPC>();
            }
        }
    }