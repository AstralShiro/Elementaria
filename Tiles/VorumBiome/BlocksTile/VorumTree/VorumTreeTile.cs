using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

using Elementaria.Items.Placeable.Decoration;

namespace Elementaria.Tiles.VorumBiome.BlocksTile.VorumTree
{
	public class VorumTreeTile : ModTree
	{
		private Mod mod {
			get {
				return ModLoader.GetMod("SpiritMod");
			}
		}

		public override int CreateDust()
		{
			return 1;
		}

		//public override int GrowthFXGore()
		//{
		//	return mod.GetGoreSlot("Gores/ExampleTreeFX");
		//}

		public override int DropWood()
		{
			return ModContent.ItemType<VorumWood>();
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/Block/SpiritTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
			frameWidth = 114;
			frameHeight = 96;
			xOffsetLeft = 48;
			return mod.GetTexture("Tiles/Block/SpiritTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
			return mod.GetTexture("Tiles/Block/SpiritTree_Branches");
		}
	}
}