using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Elementaria.Items.Placeable.Decoration;

namespace Elementaria.Tiles.AncestralBiome.BlocksTile.AncestralTree
{
	public class AncestralTreeTile : ModTree
	{
		private Mod mod => ModLoader.GetMod("Elementaria");

		public override int CreateDust()
		{
			return 1;
		}

		public override int GrowthFXGore() {
			return mod.GetGoreSlot("Gores/AncestralTreeFX");
		}

		public override int DropWood() {
			return ModContent.ItemType<AncestralWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/AncestralBiome/BlocksTile/AncestralTree/AncestralTreeTile");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) 
		{
			frameWidth = 106;
			frameHeight = 96;
			xOffsetLeft = 54;
			return mod.GetTexture("Tiles/AncestralBiome/BlocksTile/AncestralTree/AncestralTreeTile_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/AncestralBiome/BlocksTile/AncestralTree/AncestralTreeTile_Branches");
		}
	}
} 