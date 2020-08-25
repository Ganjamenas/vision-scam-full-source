namespace Debil.Vision
{
	// Token: 0x0200000B RID: 11
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00004451 File Offset: 0x00002651
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004478 File Offset: 0x00002678
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Debil.Vision.Main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.variable = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.userid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.username = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.email = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.hwid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.uservariable = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.userrank = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.ip = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.expiry = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.lastlogin = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.registerdate = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(694, 5);
			this.siticoneControlBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(60, 36);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(633, 5);
			this.siticoneControlBox2.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(60, 36);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)resources.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)resources.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)resources.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)resources.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)resources.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 167);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 23);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(13, 13);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(129, 23);
			this.label2.TabIndex = 27;
			this.label2.Text = "Auth.GG | Main";
			this.siticoneRoundedButton2.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.siticoneRoundedButton2.BorderThickness = 1;
			this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton2.FillColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton2.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(386, 135);
			this.siticoneRoundedButton2.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(340, 33);
			this.siticoneRoundedButton2.TabIndex = 28;
			this.siticoneRoundedButton2.Text = "Grab Server Variable";
			this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
			this.variable.AllowDrop = true;
			this.variable.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.variable.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.variable, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.variable.DefaultText = "Variable Secret";
			this.variable.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.variable.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.variable.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.variable.DisabledState.Parent = this.variable;
			this.variable.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.variable.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.variable.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.variable.FocusedState.Parent = this.variable;
			this.variable.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.variable.HoveredState.Parent = this.variable;
			this.variable.Location = new global::System.Drawing.Point(386, 82);
			this.variable.Margin = new global::System.Windows.Forms.Padding(5);
			this.variable.Name = "variable";
			this.variable.PasswordChar = '\0';
			this.variable.PlaceholderText = "";
			this.variable.SelectedText = "";
			this.variable.ShadowDecoration.Parent = this.variable;
			this.variable.Size = new global::System.Drawing.Size(340, 44);
			this.variable.TabIndex = 36;
			this.variable.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.userid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.userid, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.userid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.userid.Location = new global::System.Drawing.Point(26, 74);
			this.userid.Name = "userid";
			this.userid.Size = new global::System.Drawing.Size(91, 19);
			this.userid.TabIndex = 37;
			this.userid.Text = "siticoneLabel1";
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.username, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.username.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.username.Location = new global::System.Drawing.Point(26, 99);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(91, 19);
			this.username.TabIndex = 38;
			this.username.Text = "siticoneLabel2";
			this.email.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.email, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.email.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.email.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.email.Location = new global::System.Drawing.Point(26, 124);
			this.email.Name = "email";
			this.email.Size = new global::System.Drawing.Size(91, 19);
			this.email.TabIndex = 39;
			this.email.Text = "siticoneLabel3";
			this.hwid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.hwid, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.hwid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hwid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.hwid.Location = new global::System.Drawing.Point(26, 149);
			this.hwid.Name = "hwid";
			this.hwid.Size = new global::System.Drawing.Size(91, 19);
			this.hwid.TabIndex = 40;
			this.hwid.Text = "siticoneLabel4";
			this.uservariable.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.uservariable, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.uservariable.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.uservariable.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.uservariable.Location = new global::System.Drawing.Point(26, 174);
			this.uservariable.Name = "uservariable";
			this.uservariable.Size = new global::System.Drawing.Size(91, 19);
			this.uservariable.TabIndex = 41;
			this.uservariable.Text = "siticoneLabel4";
			this.userrank.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.userrank, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.userrank.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userrank.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.userrank.Location = new global::System.Drawing.Point(26, 199);
			this.userrank.Name = "userrank";
			this.userrank.Size = new global::System.Drawing.Size(91, 19);
			this.userrank.TabIndex = 42;
			this.userrank.Text = "siticoneLabel4";
			this.ip.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.ip, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.ip.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ip.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.ip.Location = new global::System.Drawing.Point(26, 224);
			this.ip.Name = "ip";
			this.ip.Size = new global::System.Drawing.Size(91, 19);
			this.ip.TabIndex = 43;
			this.ip.Text = "siticoneLabel4";
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.expiry, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.expiry.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.expiry.Location = new global::System.Drawing.Point(26, 249);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(91, 19);
			this.expiry.TabIndex = 44;
			this.expiry.Text = "siticoneLabel4";
			this.lastlogin.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.lastlogin, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.lastlogin.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lastlogin.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.lastlogin.Location = new global::System.Drawing.Point(26, 274);
			this.lastlogin.Name = "lastlogin";
			this.lastlogin.Size = new global::System.Drawing.Size(91, 19);
			this.lastlogin.TabIndex = 45;
			this.lastlogin.Text = "siticoneLabel4";
			this.registerdate.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.registerdate, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.registerdate.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.registerdate.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.registerdate.Location = new global::System.Drawing.Point(26, 299);
			this.registerdate.Name = "registerdate";
			this.registerdate.Size = new global::System.Drawing.Size(91, 19);
			this.registerdate.TabIndex = 46;
			this.registerdate.Text = "siticoneLabel4";
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.siticoneTransition1.SetDecoration(this.textBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold);
			this.textBox1.ForeColor = global::System.Drawing.SystemColors.InactiveBorder;
			this.textBox1.Location = new global::System.Drawing.Point(386, 182);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(339, 120);
			this.textBox1.TabIndex = 48;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			base.ClientSize = new global::System.Drawing.Size(759, 342);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.registerdate);
			base.Controls.Add(this.lastlogin);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.ip);
			base.Controls.Add(this.userrank);
			base.Controls.Add(this.uservariable);
			base.Controls.Add(this.hwid);
			base.Controls.Add(this.email);
			base.Controls.Add(this.username);
			base.Controls.Add(this.userid);
			base.Controls.Add(this.variable);
			base.Controls.Add(this.siticoneRoundedButton2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auth.GG WInform";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002A RID: 42
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002B RID: 43
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400002C RID: 44
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400002D RID: 45
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400002E RID: 46
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000031 RID: 49
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000032 RID: 50
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

		// Token: 0x04000033 RID: 51
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox variable;

		// Token: 0x04000034 RID: 52
		private global::Siticone.UI.WinForms.SiticoneLabel hwid;

		// Token: 0x04000035 RID: 53
		private global::Siticone.UI.WinForms.SiticoneLabel email;

		// Token: 0x04000036 RID: 54
		private global::Siticone.UI.WinForms.SiticoneLabel username;

		// Token: 0x04000037 RID: 55
		private global::Siticone.UI.WinForms.SiticoneLabel userid;

		// Token: 0x04000038 RID: 56
		private global::Siticone.UI.WinForms.SiticoneLabel registerdate;

		// Token: 0x04000039 RID: 57
		private global::Siticone.UI.WinForms.SiticoneLabel lastlogin;

		// Token: 0x0400003A RID: 58
		private global::Siticone.UI.WinForms.SiticoneLabel expiry;

		// Token: 0x0400003B RID: 59
		private global::Siticone.UI.WinForms.SiticoneLabel ip;

		// Token: 0x0400003C RID: 60
		private global::Siticone.UI.WinForms.SiticoneLabel userrank;

		// Token: 0x0400003D RID: 61
		private global::Siticone.UI.WinForms.SiticoneLabel uservariable;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TextBox textBox1;
	}
}
