using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Debil.Vision.Hack;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Debil.Vision
{
	// Token: 0x0200000D RID: 13
	public partial class Login : Form
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00006A9A File Offset: 0x00004C9A
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006AA8 File Offset: 0x00004CA8
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			base.Hide();
			new Register().Show();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006ABA File Offset: 0x00004CBA
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00006AC4 File Offset: 0x00004CC4
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			if (API.Login(this.username.Text, this.password.Text))
			{
				MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				new Debil.Vision.Hack.Menu().Show();
				base.Hide();
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00006B11 File Offset: 0x00004D11
		private void Login_Load(object sender, EventArgs e)
		{
		}
	}
}
