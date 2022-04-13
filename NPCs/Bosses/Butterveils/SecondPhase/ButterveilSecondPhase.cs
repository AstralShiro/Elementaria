using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.Collections.Specialized;

using Elementaria.Projectiles.Bosses;

namespace Elementaria.NPCs.Bosses.Butterveils.SecondPhase
{
    //[AutoloadBossHead]
    public class ButterveilSecondPhase : ModNPC
    {
        private Player player;
        private float speed;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Butterveil, The ancestral");
			Main.npcFrameCount[npc.type] = 6;

        }

        public override void SetDefaults()
        {
            npc.lifeMax = 30000;
            npc.damage = 50;
            npc.defense = 45;
			
			npc.height = 372;
			npc.width = 490; 

            npc.knockBackResist = 0f;

            npc.value = Item.buyPrice(0, 15, 00, 00);

            npc.npcSlots = 5f;

            npc.boss = true;

            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;

            npc.HitSound = mod.GetLegacySoundSlot(SoundType.NPCHit, "Sounds/NPCHit/ButterveilHit");
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.NPCKilled, "Sounds/NPCDeath/ButterveilSoundDeath");
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/ButterveilSecondPhase");
            //bossBag = mod.ItemType("IceBossBag");

        }

        public override bool PreNPCLoot()
        {
            return true;
        }
                public override void AI()
		{

			Lighting.AddLight(npc.position, .7f, .5f, .9f);

			if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active) {
				npc.TargetClosest();
			}

			bool allDead = false;
			for (int i = 0; i < Main.player.Length; i++)
			{
				if (Main.player[i].dead) allDead = true;
			}

			if (allDead)
			{
				if (npc.velocity.X > 0f)
				{
					npc.velocity.X = npc.velocity.X + 0.75f;
				}
				else
				{
					npc.velocity.X = npc.velocity.X - 0.75f;
				}
				npc.velocity.Y = npc.velocity.Y - 0.1f;
				npc.rotation = npc.velocity.X * 0.05f;
			}
			else if (npc.ai[0] == 0f)
			{
				if (npc.ai[2] == 0f)
				{
					npc.TargetClosest(true);
					if (npc.Center.X < Main.player[npc.target].Center.X)
					{
						npc.ai[2] = 1f;
					}
					else
					{
						npc.ai[2] = -1f;
					}
				}
				npc.TargetClosest(true);
				int num1319 = 800;
				float num1320 = Math.Abs(npc.Center.X - Main.player[npc.target].Center.X);
				if (npc.Center.X < Main.player[npc.target].Center.X && npc.ai[2] < 0f && num1320 > num1319)
				{
					npc.ai[2] = 0f;
				}
				if (npc.Center.X > Main.player[npc.target].Center.X && npc.ai[2] > 0f && num1320 > num1319)
				{
					npc.ai[2] = 0f;
				}
				float num1321 = 0.45f;
				float num1322 = 7f;
				if (npc.life < npc.lifeMax * 0.75)
				{
					num1321 = 0.55f;
					num1322 = 8f;
				}
				if (npc.life < npc.lifeMax * 0.5)
				{
					num1321 = 0.7f;
					num1322 = 10f;
				}
				if (npc.life < npc.lifeMax * 0.25)
				{
					num1321 = 0.8f;
					num1322 = 11f;
				}
				npc.velocity.X = npc.velocity.X + npc.ai[2] * num1321;
				if (npc.velocity.X > num1322)
				{
					npc.velocity.X = num1322;
				}
				if (npc.velocity.X < -num1322)
				{
					npc.velocity.X = -num1322;
				}
				float num1323 = Main.player[npc.target].position.Y - (npc.position.Y + npc.height);
				if (num1323 < 150f)
				{
					npc.velocity.Y = npc.velocity.Y - 0.2f;
				}
				if (num1323 > 200f)
				{
					npc.velocity.Y = npc.velocity.Y + 0.2f;
				}
				if (npc.velocity.Y > 8f)
				{
					npc.velocity.Y = 8f;
				}
				if (npc.velocity.Y < -8f)
				{
					npc.velocity.Y = -8f;
				}
				npc.rotation = npc.velocity.X * 0.05f;
				if ((num1320 < 500f || npc.ai[3] < 0f) && npc.position.Y < Main.player[npc.target].position.Y)
				{
					npc.ai[3] += 1f;
					int num1324 = 13;
					if (npc.life < npc.lifeMax * 0.75)
					{
						num1324 = 12;
					}
					if (npc.life < npc.lifeMax * 0.5)
					{
						num1324 = 11;
					}
					if (npc.life < npc.lifeMax * 0.25)
					{
						num1324 = 10;
					}
					num1324++;
					if (npc.ai[3] > num1324)
					{
						npc.ai[3] = -(float)num1324;
					}
					if (npc.ai[3] == 0f && Main.netMode != 1)
					{
						Vector2 vector159 = new Vector2(npc.Center.X, npc.Center.Y);
						vector159.X += npc.velocity.X * 7f;//7
						float num1325 = Main.player[npc.target].position.X + Main.player[npc.target].width * 0.5f - vector159.X;//0.5
						float num1326 = Main.player[npc.target].Center.Y - vector159.Y;
						float num1327 = (float)Math.Sqrt(num1325 * num1325 + num1326 * num1326);
						float num1328 = 5f;//5
						if (npc.life < npc.lifeMax * 0.75)
						{
							num1328 = 7f;
						}
						if (npc.life < npc.lifeMax * 0.5)
						{
							num1328 = 8f;
						}
						if (npc.life < npc.lifeMax * 0.25)
						{
							num1328 = 9f;
						}
						num1327 = num1328 / num1327;
						num1325 *= num1327;
						num1326 *= num1327;

                        Player target = Main.player[npc.target];
                        Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                        int projectile = Projectile.NewProjectile(npc.Center, direction * 10, ModContent.ProjectileType<TestProj>(), 5,0, Main.myPlayer);
                    }

				}
				else if (npc.ai[3] < 0f)
				{
					npc.ai[3] += 1f;
				}
				if (Main.netMode != 1)
				{
					npc.ai[1] += Main.rand.Next(1, 4);
					if (npc.ai[1] > 800f && num1320 < 600f)
					{
						npc.ai[0] = -1f;
					}
				}
			}
			else if (npc.ai[0] == 1f)
			{
				npc.TargetClosest(true);
				float num1329 = 0.15f;
				float num1330 = 7f;
				if (npc.life < npc.lifeMax * 0.75)
				{
					num1329 = 0.17f;
					num1330 = 8f;
				}
				if (npc.life < npc.lifeMax * 0.5)
				{
					num1329 = 0.2f;
					num1330 = 9f;
				}
				if (npc.life < npc.lifeMax * 0.25)
				{
					num1329 = 0.25f;
					num1330 = 10f;
				}
				num1329 -= 0.05f;
				num1330 -= 1f;
				if (npc.Center.X < Main.player[npc.target].Center.X)
				{
					npc.velocity.X = npc.velocity.X + num1329;
					if (npc.velocity.X < 0f)
					{
						npc.velocity.X = npc.velocity.X * 0.98f;
					}
				}
				if (npc.Center.X > Main.player[npc.target].Center.X)
				{
					npc.velocity.X = npc.velocity.X - num1329;
					if (npc.velocity.X > 0f)
					{
						npc.velocity.X = npc.velocity.X * 0.98f;
					}
				}
				if (npc.velocity.X > num1330 || npc.velocity.X < -num1330)
				{
					npc.velocity.X = npc.velocity.X * 0.95f;
				}
				float num1331 = Main.player[npc.target].position.Y - (npc.position.Y + npc.height);
				if (num1331 < 180f)
				{
					npc.velocity.Y = npc.velocity.Y - 0.1f;
				}
				if (num1331 > 200f)
				{
					npc.velocity.Y = npc.velocity.Y + 0.1f;
				}
				if (npc.velocity.Y > 6f)
				{
					npc.velocity.Y = 6f;
				}
				if (npc.velocity.Y < -6f)
				{
					npc.velocity.Y = -6f;
				}
				npc.rotation = npc.velocity.X * 0.01f;
				if (Main.netMode != 1)
				{
					npc.ai[3] += 1f;
					int num1332 = 15;
					if (npc.life < npc.lifeMax * 0.75)
					{
						num1332 = 14;
					}
					if (npc.life < npc.lifeMax * 0.5)
					{
						num1332 = 12;
					}
					if (npc.life < npc.lifeMax * 0.25)
					{
						num1332 = 10;
					}
					if (npc.life < npc.lifeMax * 0.1)
					{
						num1332 = 8;
					}
					num1332 += 3;
					if (npc.ai[3] >= num1332)
					{
						npc.ai[3] = 0f;
						Vector2 vector160 = new Vector2(npc.Center.X, npc.position.Y + npc.height - 14f);
						int i2 = (int)(vector160.X / 16f);
						int j2 = (int)(vector160.Y / 16f);
						if (!WorldGen.SolidTile(i2, j2))
						{
							float num1333 = npc.velocity.Y;
							if (num1333 < 0f)
							{
								num1333 = 0f;
							}
							num1333 += 3f;
							float speedX2 = npc.velocity.X * 1f;
							
							Player target = Main.player[npc.target];
                        	Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                        	int projectile = Projectile.NewProjectile(npc.Center, direction * 1, ModContent.ProjectileType<TestProj>(), 5,0, Main.myPlayer);
						}
					}
				}
				if (Main.netMode != 1)
				{
					npc.ai[1] += Main.rand.Next(1, 4);
					if (npc.ai[1] > 600f)
					{
						npc.ai[0] = -1f;
					}
				}
			}
			else if (npc.ai[0] == 2f)
			{
				npc.TargetClosest(true);
				Vector2 vector161 = new Vector2(npc.Center.X, npc.Center.Y - 20f);
				float num1334 = Main.rand.Next(-1000, 1001);
				float num1335 = Main.rand.Next(-1000, 1001);
				float num1336 = (float)Math.Sqrt(num1334 * num1334 + num1335 * num1335);
				float num1337 = 15f;
				npc.velocity *= 0.95f;
				num1336 = num1337 / num1336;
				num1334 *= num1336;
				num1335 *= num1336;
				npc.rotation += 0.2f;
				vector161.X += num1334 * 4f;
				vector161.Y += num1335 * 4f;
				npc.ai[3] += 1f;
				int num1338 = 7;
				if (npc.life < npc.lifeMax * 0.75)
				{
					num1338--;
				}
				if (npc.life < npc.lifeMax * 0.5)
				{
					num1338 -= 2;
				}
				if (npc.life < npc.lifeMax * 0.25)
				{
					num1338 -= 3;
				}
				if (npc.life < npc.lifeMax * 0.1)
				{
					num1338 -= 4;
				}
				if (npc.ai[3] > num1338)
				{
					npc.ai[3] = 0f;

						Player target = Main.player[npc.target];
                        Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
                        int projectile = Projectile.NewProjectile(npc.Center, direction * 10, ModContent.ProjectileType<TestProj>(), 5,0, Main.myPlayer);
				}
				if (Main.netMode != 1)
				{
					npc.ai[1] += Main.rand.Next(1, 4);
					if (npc.ai[1] > 500f)
					{
						npc.ai[0] = -1f;
					}
				}
			}
			if (npc.ai[0] == -1f)
			{
				int num1339 = Main.rand.Next(3);
				npc.TargetClosest(true);
				if (Math.Abs(npc.Center.X - Main.player[npc.target].Center.X) > 1000f)
				{
					num1339 = 0;
				}
				npc.ai[0] = num1339;
				npc.ai[1] = 0f;
				npc.ai[2] = 0f;
				npc.ai[3] = 0f;
			}
		}


        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.5f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.5f);
        }

             public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 0.15000000596046448;
            npc.frameCounter %= (double)Main.npcFrameCount[npc.type];
            int num = (int)npc.frameCounter;
            npc.frame.Y = num * frameHeight;

            //harpy rotation
            npc.rotation = npc.velocity.X * 0.05f;
        }
    }
}