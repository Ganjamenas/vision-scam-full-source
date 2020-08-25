using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Debil.Vision
{
	// Token: 0x0200000C RID: 12
	public partial class Register : Form
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000056A7 File Offset: 0x000038A7
		public Register()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000056B5 File Offset: 0x000038B5
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
			new Login().Show();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000056C7 File Offset: 0x000038C7
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000056D0 File Offset: 0x000038D0
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			if (API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text))
			{
				MessageBox.Show("Account has been successfully registered and activated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005723 File Offset: 0x00003923
		private void siticoneImageButton1_Click(object sender, EventArgs e)
		{
		}
	}
}
