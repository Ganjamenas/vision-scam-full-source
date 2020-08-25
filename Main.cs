using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Debil.Vision
{
	// Token: 0x0200000B RID: 11
	public partial class Main : Form
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000430F File Offset: 0x0000250F
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000431D File Offset: 0x0000251D
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000431F File Offset: 0x0000251F
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004327 File Offset: 0x00002527
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(App.GrabVariable(this.variable.Text));
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004340 File Offset: 0x00002540
		private void Main_Load(object sender, EventArgs e)
		{
			this.userid.Text = "ID: " + User.ID;
			this.username.Text = "Username: " + User.Username;
			this.email.Text = "Email: " + User.Email;
			this.hwid.Text = "HWID: " + User.HWID;
			this.uservariable.Text = "User Variable: " + User.UserVariable;
			this.userrank.Text = "Rank: " + User.Rank;
			this.ip.Text = "IP: " + User.IP;
			this.expiry.Text = "Expiry: " + User.Expiry;
			this.lastlogin.Text = "Last Login: " + User.LastLogin;
			this.registerdate.Text = "Register Date: " + User.RegisterDate;
		}
	}
}
