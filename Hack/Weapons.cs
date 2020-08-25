using System;

namespace Debil.Vision.Hack
{
	// Token: 0x02000013 RID: 19
	public static class Weapons
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00009494 File Offset: 0x00007694
		public static ValueTuple<int[,], int> Current_weapon()
		{
			string weapon = Menu.weapon;
			if (weapon == "Assault Rifle")
			{
				return new ValueTuple<int[,], int>(Weapons.AssaultRifle, Weapons.AssaultRifleTime);
			}
			if (weapon == "LR-300 Assault Rifle")
			{
				return new ValueTuple<int[,], int>(Weapons.LR300AssaultRifle, Weapons.LR300AssaultRifleTime);
			}
			if (weapon == "M249")
			{
				return new ValueTuple<int[,], int>(Weapons.M249, Weapons.M249Time);
			}
			if (weapon == "Thompson")
			{
				return new ValueTuple<int[,], int>(Weapons.Thompson, Weapons.ThompsonTime);
			}
			if (weapon == "MP5A4")
			{
				return new ValueTuple<int[,], int>(Weapons.MP5A4, Weapons.MP5A4Time);
			}
			if (!(weapon == "Custom SMG"))
			{
				return new ValueTuple<int[,], int>(Weapons.defaultnothing, 0);
			}
			return new ValueTuple<int[,], int>(Weapons.CustomSMG, Weapons.CustomSMGTime);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00009564 File Offset: 0x00007764
		public static ValueTuple<double, double> Attachment()
		{
			string attachment = Menu.attachment;
			if (attachment == "Muzzle Boost")
			{
				return new ValueTuple<double, double>(1.0, 0.9);
			}
			if (attachment == "Muzzle Brake")
			{
				return new ValueTuple<double, double>(0.5, 1.0);
			}
			if (!(attachment == "Silencer"))
			{
				return new ValueTuple<double, double>(1.0, 1.0);
			}
			return new ValueTuple<double, double>(0.8, 1.0);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00009600 File Offset: 0x00007800
		public static double Scope()
		{
			string scope = Menu.scope;
			if (scope == "8x Zoom Scope")
			{
				return 3.83721;
			}
			if (scope == "16x Zoom Scope")
			{
				return 7.65116;
			}
			if (scope == "Simple Handmade Sight")
			{
				return 0.8;
			}
			if (!(scope == "Holosight"))
			{
				return 1.0;
			}
			return 1.18605;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000967C File Offset: 0x0000787C
		public static int minmax(int av, int min, int max)
		{
			double percentage = (double)Weapons.r.Next(min, max);
			percentage /= 100.0;
			return Convert.ToInt32((double)av * percentage);
		}

		// Token: 0x04000085 RID: 133
		private static int[,] defaultnothing = new int[1, 2];

		// Token: 0x04000086 RID: 134
		public static int[,] AssaultRifle = new int[,]
		{
			{
				-34,
				50
			},
			{
				5,
				46
			},
			{
				-55,
				41
			},
			{
				-42,
				37
			},
			{
				0,
				33
			},
			{
				16,
				28
			},
			{
				29,
				24
			},
			{
				38,
				19
			},
			{
				42,
				14
			},
			{
				42,
				9
			},
			{
				38,
				10
			},
			{
				30,
				18
			},
			{
				17,
				25
			},
			{
				1,
				29
			},
			{
				-15,
				32
			},
			{
				-27,
				32
			},
			{
				-37,
				32
			},
			{
				-43,
				29
			},
			{
				-46,
				24
			},
			{
				-45,
				17
			},
			{
				-42,
				8
			},
			{
				-35,
				5
			},
			{
				-24,
				14
			},
			{
				-11,
				21
			},
			{
				12,
				25
			},
			{
				36,
				28
			},
			{
				48,
				28
			},
			{
				49,
				25
			},
			{
				38,
				21
			}
		};

		// Token: 0x04000087 RID: 135
		public static int AssaultRifleTime = 133;

		// Token: 0x04000088 RID: 136
		public static int[,] LR300AssaultRifle = new int[,]
		{
			{
				-2,
				25
			},
			{
				-6,
				31
			},
			{
				-10,
				33
			},
			{
				-14,
				31
			},
			{
				-15,
				25
			},
			{
				-14,
				20
			},
			{
				-9,
				17
			},
			{
				-2,
				15
			},
			{
				9,
				12
			},
			{
				17,
				10
			},
			{
				20,
				8
			},
			{
				17,
				7
			},
			{
				10,
				5
			},
			{
				0,
				4
			},
			{
				-5,
				4
			},
			{
				-9,
				4
			},
			{
				-12,
				3
			},
			{
				-14,
				3
			},
			{
				-15,
				3
			},
			{
				-15,
				2
			},
			{
				-14,
				2
			},
			{
				-13,
				2
			},
			{
				-10,
				2
			},
			{
				-7,
				2
			},
			{
				-3,
				2
			},
			{
				13,
				2
			},
			{
				30,
				2
			},
			{
				36,
				3
			},
			{
				30,
				3
			}
		};

		// Token: 0x04000089 RID: 137
		public static int LR300AssaultRifleTime = 118;

		// Token: 0x0400008A RID: 138
		public static int[,] Thompson = new int[,]
		{
			{
				-15,
				33
			},
			{
				-5,
				32
			},
			{
				3,
				31
			},
			{
				11,
				29
			},
			{
				13,
				26
			},
			{
				10,
				22
			},
			{
				2,
				18
			},
			{
				-7,
				16
			},
			{
				-13,
				14
			},
			{
				-13,
				13
			},
			{
				-7,
				11
			},
			{
				2,
				10
			},
			{
				10,
				9
			},
			{
				12,
				8
			},
			{
				11,
				7
			},
			{
				5,
				7
			},
			{
				-2,
				6
			},
			{
				-6,
				6
			},
			{
				-7,
				6
			}
		};

		// Token: 0x0400008B RID: 139
		public static int ThompsonTime = 127;

		// Token: 0x0400008C RID: 140
		public static int[,] MP5A4 = new int[,]
		{
			{
				0,
				21
			},
			{
				0,
				29
			},
			{
				0,
				33
			},
			{
				12,
				33
			},
			{
				29,
				29
			},
			{
				33,
				22
			},
			{
				23,
				13
			},
			{
				0,
				10
			},
			{
				-18,
				9
			},
			{
				-25,
				8
			},
			{
				-19,
				7
			},
			{
				-3,
				6
			},
			{
				7,
				5
			},
			{
				14,
				4
			},
			{
				16,
				4
			},
			{
				16,
				3
			},
			{
				12,
				2
			},
			{
				6,
				2
			},
			{
				-1,
				1
			},
			{
				-5,
				1
			},
			{
				-8,
				0
			},
			{
				-10,
				0
			},
			{
				-12,
				0
			},
			{
				-13,
				0
			},
			{
				-13,
				0
			},
			{
				-12,
				0
			},
			{
				-11,
				0
			},
			{
				-8,
				0
			},
			{
				-5,
				0
			}
		};

		// Token: 0x0400008D RID: 141
		public static int MP5A4Time = 98;

		// Token: 0x0400008E RID: 142
		public static int[,] CustomSMG = new int[,]
		{
			{
				-13,
				27
			},
			{
				-6,
				27
			},
			{
				0,
				26
			},
			{
				6,
				25
			},
			{
				10,
				23
			},
			{
				11,
				21
			},
			{
				9,
				18
			},
			{
				4,
				16
			},
			{
				-3,
				14
			},
			{
				-9,
				13
			},
			{
				-11,
				12
			},
			{
				-10,
				10
			},
			{
				-6,
				9
			},
			{
				0,
				9
			},
			{
				6,
				8
			},
			{
				9,
				7
			},
			{
				10,
				6
			},
			{
				9,
				6
			},
			{
				4,
				5
			},
			{
				0,
				5
			},
			{
				-4,
				5
			},
			{
				-6,
				5
			},
			{
				-5,
				5
			}
		};

		// Token: 0x0400008F RID: 143
		public static int CustomSMGTime = 99;

		// Token: 0x04000090 RID: 144
		public static int[,] M249 = new int[,]
		{
			{
				0,
				60
			},
			{
				0,
				60
			},
			{
				0,
				60
			},
			{
				0,
				60
			},
			{
				0,
				60
			}
		};

		// Token: 0x04000091 RID: 145
		public static int M249Time = 120;

		// Token: 0x04000092 RID: 146
		private static Random r = new Random();
	}
}
