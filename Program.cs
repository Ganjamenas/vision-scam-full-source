using System;
using System.Threading;
using System.Windows.Forms;
using Debil.Vision.Hack;

namespace Debil.Vision
{
	// Token: 0x0200000E RID: 14
	internal static class Program
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000079F0 File Offset: 0x00005BF0
		[STAThread]
		private static void Main()
		{
			new Thread(new ThreadStart(Program.Recoil)).Start();
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007A44 File Offset: 0x00005C44
		private static void Recoil()
		{
			for (;;)
			{
				try
				{
					if (Debil.Vision.Hack.Menu.activ && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
					{
						for (int i = 0; i < Weapons.Current_weapon().Item1.Length; i++)
						{
							double Recoil_x = (double)(Weapons.Current_weapon().Item1[i, 0] / 2) / Debil.Vision.Hack.Menu.sense * Weapons.Attachment().Item1 * Weapons.Scope();
							double Recoil_y = (double)(Weapons.Current_weapon().Item1[i, 1] / 2) / Debil.Vision.Hack.Menu.sense * Weapons.Attachment().Item1 * Weapons.Scope();
							for (int j = 0; j < Debil.Vision.Hack.Menu.smooth; j++)
							{
								if (Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
								{
									int move_x = Convert.ToInt32(Recoil_x / (double)Debil.Vision.Hack.Menu.smooth);
									int move_y = Convert.ToInt32(Recoil_y / (double)Debil.Vision.Hack.Menu.smooth);
									if (Debil.Vision.Hack.Menu.minmax)
									{
										move_x = Weapons.minmax(move_x, Debil.Vision.Hack.Menu.min, Debil.Vision.Hack.Menu.max);
										move_y = Weapons.minmax(move_y, Debil.Vision.Hack.Menu.min, Debil.Vision.Hack.Menu.max);
									}
									Mouse.RelativeMove(move_x, move_y);
									Thread.Sleep(Convert.ToInt32((double)(Weapons.Current_weapon().Item2 / Debil.Vision.Hack.Menu.smooth) * Weapons.Attachment().Item2));
								}
							}
							if (Debil.Vision.Hack.Menu.test1 && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
							{
								int relx = Convert.ToInt32(Recoil_x % (double)Debil.Vision.Hack.Menu.smooth);
								int lost_y = Convert.ToInt32(Recoil_y % (double)Debil.Vision.Hack.Menu.smooth);
								Mouse.RelativeMove(relx, lost_y);
							}
						}
					}
				}
				catch
				{
				}
			}
		}
	}
}
