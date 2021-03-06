using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Elementaria.Buffs.MountBuff;
using Elementaria.Dusts;

namespace Elementaria.Mounts
{
	public class EarthWolf : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = ModContent.DustType<EarthDust>();
			mountData.buff = ModContent.BuffType<EarthWolfBuff>();
			mountData.heightBoost = 20;          //how high is the mount from the ground
			mountData.fallDamage = 0.5f;
			mountData.runSpeed = 10f;
			mountData.dashSpeed = 10f;
			//mountData.flightTimeMax = 300;
			mountData.fatigueMax = 0;
			mountData.jumpHeight = 10;
			mountData.acceleration = 0.19f;
			mountData.jumpSpeed = 10f;
			mountData.blockExtraJumps = false;
			mountData.totalFrames = 16;            //mount frame/animation
			mountData.constantJump = true;
			int[] array = new int[mountData.totalFrames];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 25;
			}

			array[1] += 2;
			array[3] -= 2;

			mountData.playerYOffsets = array;
			mountData.xOffset = 12;
			mountData.yOffset = -1;          //how high is the mount from the player
			mountData.bodyFrame = 0;          //player frame when it's on the mount
			mountData.playerHeadOffset = 25;

			mountData.standingFrameCount = 1;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;

			mountData.runningFrameCount = 6;
			mountData.runningFrameDelay = 12;
			mountData.runningFrameStart = 8;

			mountData.flyingFrameCount = 0;
			mountData.flyingFrameDelay = 0;
			mountData.flyingFrameStart = 0;

			mountData.inAirFrameCount = 1;
			mountData.inAirFrameDelay = 12;
			mountData.inAirFrameStart = 15;

			mountData.idleFrameCount = 0;
			mountData.idleFrameDelay = 12;
			mountData.idleFrameStart = 0;

			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			
			if (!Main.dedServ)
			{
				mountData.textureWidth = mountData.backTexture.Width + 20;
				mountData.textureHeight = mountData.backTexture.Height;
			}
		}

		public override void UpdateEffects(Player player)
		{ 
			if (!(Math.Abs(player.velocity.X) > 4f))
			{
				return;
			}
			Rectangle rect = player.getRect();
			Dust.NewDust(new Vector2(rect.X, rect.Y), rect.Width, rect.Height, DustType<EarthDust>());
		}

		internal class EarthWolfSpecificData
		{
			internal int count;
			internal float[] rotations;
			internal static float[] offsets = new float[] { 0, 14, -14 };
			public EarthWolfSpecificData()
			{
				count = 3;
				rotations = new float[count];
			}
		}
	}
}