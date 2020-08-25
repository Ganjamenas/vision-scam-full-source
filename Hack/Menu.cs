using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Debil.Vision.Properties;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Debil.Vision.Hack
{
	// Token: 0x02000011 RID: 17
	public partial class Menu : MetroForm
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00007C73 File Offset: 0x00005E73
		public Menu()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007C81 File Offset: 0x00005E81
		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox1.Checked)
			{
				Debil.Vision.Hack.Menu.activ = true;
				return;
			}
			Debil.Vision.Hack.Menu.activ = false;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007C9D File Offset: 0x00005E9D
		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox2.Checked)
			{
				Debil.Vision.Hack.Menu.minmax = true;
				return;
			}
			Debil.Vision.Hack.Menu.minmax = false;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007CB9 File Offset: 0x00005EB9
		private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox3.Checked)
			{
				Debil.Vision.Hack.Menu.test1 = true;
				return;
			}
			Debil.Vision.Hack.Menu.test1 = false;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007CD5 File Offset: 0x00005ED5
		private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
		{
			Debil.Vision.Hack.Menu.smooth = this.metroTrackBar3.Value;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007CE7 File Offset: 0x00005EE7
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			Debil.Vision.Hack.Menu.sense = Convert.ToDouble(this.numericUpDown1.Value);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00007CFE File Offset: 0x00005EFE
		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			Debil.Vision.Hack.Menu.fov = Convert.ToInt32(this.numericUpDown2.Value);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00007D15 File Offset: 0x00005F15
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Debil.Vision.Hack.Menu.weapon = (string)this.metroComboBox1.SelectedItem;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007D2C File Offset: 0x00005F2C
		private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			Debil.Vision.Hack.Menu.attachment = (string)this.metroComboBox2.SelectedItem;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007D43 File Offset: 0x00005F43
		private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			Debil.Vision.Hack.Menu.scope = (string)this.metroComboBox3.SelectedItem;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007D5A File Offset: 0x00005F5A
		private void Menu_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(1);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007D62 File Offset: 0x00005F62
		private void Menu_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00009403 File Offset: 0x00007603
		private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000940A File Offset: 0x0000760A
		private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009411 File Offset: 0x00007611
		private void metroLabel3_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00009418 File Offset: 0x00007618
		private void metroLabel10_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400005E RID: 94
		public static bool activ = false;

		// Token: 0x0400005F RID: 95
		public static bool minmax = false;

		// Token: 0x04000060 RID: 96
		public static bool test1 = false;

		// Token: 0x04000061 RID: 97
		public static int min = 0;

		// Token: 0x04000062 RID: 98
		public static int max = 1;

		// Token: 0x04000063 RID: 99
		public static int smooth = 1;

		// Token: 0x04000064 RID: 100
		public static double sense = 1.0;

		// Token: 0x04000065 RID: 101
		public static int fov = 90;

		// Token: 0x04000066 RID: 102
		public static string weapon;

		// Token: 0x04000067 RID: 103
		public static string attachment;

		// Token: 0x04000068 RID: 104
		public static string scope;
	}
}
