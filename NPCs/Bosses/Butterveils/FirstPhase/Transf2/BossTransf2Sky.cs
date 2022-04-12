using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.ModLoader;

namespace Elementaria.NPCs.Bosses.Butterveils.FirstPhase.Transf2
{
	public class BossTransf2Sky : CustomSky
	{
		private bool isActive;

        private float intensity;

		private int BossTransf2Index;

		public override void Update(GameTime gameTime)
        {
            if (isActive && intensity < 1f)
            {
                intensity += 0.01f;
            }
            else if (!isActive && intensity > 0f)
            {
                intensity -= 0.01f;
            }
        }

		private bool UpdateBossTransf2Index()
		{
			int BossTransf2Type = ModLoader.GetMod("Elementaria").NPCType("BossTransf2");
			if (BossTransf2Index >= 0 && Main.npc[BossTransf2Index].active && Main.npc[BossTransf2Index].type == BossTransf2Type)
			{
				return true;
			}
			BossTransf2Index = -1;
			for (int i = 0; i < Main.npc.Length; i++)
			{
				if (Main.npc[i].active && Main.npc[i].type == BossTransf2Type)
				{
					BossTransf2Index = i;
					break;
				}
			}
			return BossTransf2Index >= 0;
		}

		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			if (maxDepth >= float.MaxValue && minDepth < float.MaxValue)
			{
				spriteBatch.Draw(ModContent.GetTexture("Elementaria/Textures/ButterveilBackground"), new Rectangle(0, Math.Max(0, (int)((Main.worldSurface * 16.0 - (double)Main.screenPosition.Y - 2400.0) * 0.10000000149011612)), Main.screenWidth, Main.screenHeight), Color.White * Math.Min(1f, (Main.screenPosition.Y - 800f) / 1000f) * intensity);
			}
		}

		public override float GetCloudAlpha()
		{
			return 0f;
		}

		public override void Activate(Vector2 position, params object[] args)
		{
			isActive = true;
		}

		public override void Deactivate(params object[] args)
		{
			isActive = false;
		}

		public override void Reset()
		{
			isActive = false;
		}

		public override bool IsActive()
		{
			if (!isActive)
			{
				return intensity > 0f;
			}
			return true;
		}
	}
}