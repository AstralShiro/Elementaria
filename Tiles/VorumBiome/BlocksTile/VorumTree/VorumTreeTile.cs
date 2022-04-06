using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

using Elementaria.Tiles.VorumBiome;
using Elementaria.Items.Placeable.Decoration;

namespace Elementaria.Tiles.VorumBiome.BlocksTile.VorumTree
{
	public class VorumTreeTile : ModTree
	{
		private Mod mod {
			get {
				return ModLoader.GetMod("Elementaria");
			}
		}

		public override int CreateDust()
		{
			return 1;
		}
		public override int DropWood()
		{
			return ModContent.ItemType<VorumWood>();
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/VorumBiome/BlocksTile/VorumTree/VorumTreeTile");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
			return mod.GetTexture("Tiles/VorumBiome/BlocksTile/VorumTree/VorumTreeTile_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
			return mod.GetTexture("Tiles/VorumBiome/BlocksTile/VorumTree/VorumTreeTile_Branches");
		}
	}
}