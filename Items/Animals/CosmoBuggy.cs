using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

using Elementaria.NPCs.VorumBiome.Animals;

namespace Elementaria.Items.Animals
{
    internal class CosmoBuggy : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cosmo Buggy");
		}

            public override void SetDefaults() {
                //item.useStyle = 1;
                //item.autoReuse = true;
                //item.useTurn = true;
                //item.useAnimation = 15;
                //item.useTime = 10;
                //item.maxStack = 999;
                //item.consumable = true;
                item.width = 22;
                item.height = 16;
                //item.makeNPC = 360;
                //item.noUseGraphic = true;
                //item.bait = 15;

                //item.CloneDefaults(ItemID.);
                //item.bait = 17;
                item.makeNPC = (short)ModContent.NPCType<CosmoBuggyNPC>();
            }
        }
    }