namespace Debil.Vision.Hack
{
	// Token: 0x02000011 RID: 17
	public partial class Menu : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00007D64 File Offset: 0x00005F64
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007D84 File Offset: 0x00005F84
		private void InitializeComponent()
		{
			this.metroTabControl1 = new global::MetroFramework.Controls.MetroTabControl();
			this.metroPanel2 = new global::MetroFramework.Controls.MetroPanel();
			this.metroLabel11 = new global::MetroFramework.Controls.MetroLabel();
			this.metroLabel6 = new global::MetroFramework.Controls.MetroLabel();
			this.metroComboBox3 = new global::MetroFramework.Controls.MetroComboBox();
			this.metroLabel5 = new global::MetroFramework.Controls.MetroLabel();
			this.metroComboBox2 = new global::MetroFramework.Controls.MetroComboBox();
			this.metroLabel4 = new global::MetroFramework.Controls.MetroLabel();
			this.metroTrackBar3 = new global::MetroFramework.Controls.MetroTrackBar();
			this.metroLabel3 = new global::MetroFramework.Controls.MetroLabel();
			this.metroComboBox1 = new global::MetroFramework.Controls.MetroComboBox();
			this.metroLabel2 = new global::MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new global::MetroFramework.Controls.MetroLabel();
			this.metroTrackBar1 = new global::MetroFramework.Controls.MetroTrackBar();
			this.metroTrackBar2 = new global::MetroFramework.Controls.MetroTrackBar();
			this.metroLabel7 = new global::MetroFramework.Controls.MetroLabel();
			this.metroLabel10 = new global::MetroFramework.Controls.MetroLabel();
			this.metroPanel1 = new global::MetroFramework.Controls.MetroPanel();
			this.metroCheckBox5 = new global::MetroFramework.Controls.MetroCheckBox();
			this.metroCheckBox4 = new global::MetroFramework.Controls.MetroCheckBox();
			this.metroLabel9 = new global::MetroFramework.Controls.MetroLabel();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.metroLabel8 = new global::MetroFramework.Controls.MetroLabel();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.metroCheckBox3 = new global::MetroFramework.Controls.MetroCheckBox();
			this.metroCheckBox2 = new global::MetroFramework.Controls.MetroCheckBox();
			this.metroCheckBox1 = new global::MetroFramework.Controls.MetroCheckBox();
			this.metroPanel2.SuspendLayout();
			this.metroPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.metroTabControl1.Location = new global::System.Drawing.Point(242, 294);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.Size = new global::System.Drawing.Size(362, 67);
			this.metroTabControl1.TabIndex = 0;
			this.metroTabControl1.UseSelectable = true;
			this.metroPanel2.BackColor = global::System.Drawing.Color.Black;
			this.metroPanel2.Controls.Add(this.metroLabel11);
			this.metroPanel2.Controls.Add(this.metroLabel6);
			this.metroPanel2.Controls.Add(this.metroComboBox3);
			this.metroPanel2.Controls.Add(this.metroLabel5);
			this.metroPanel2.Controls.Add(this.metroComboBox2);
			this.metroPanel2.Controls.Add(this.metroLabel4);
			this.metroPanel2.Controls.Add(this.metroTrackBar3);
			this.metroPanel2.Controls.Add(this.metroLabel3);
			this.metroPanel2.Controls.Add(this.metroComboBox1);
			this.metroPanel2.Controls.Add(this.metroLabel2);
			this.metroPanel2.Controls.Add(this.metroLabel1);
			this.metroPanel2.Controls.Add(this.metroTrackBar1);
			this.metroPanel2.Controls.Add(this.metroTrackBar2);
			this.metroPanel2.HorizontalScrollbarBarColor = true;
			this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel2.HorizontalScrollbarSize = 10;
			this.metroPanel2.Location = new global::System.Drawing.Point(23, 394);
			this.metroPanel2.Name = "metroPanel2";
			this.metroPanel2.Size = new global::System.Drawing.Size(464, 260);
			this.metroPanel2.TabIndex = 1;
			this.metroPanel2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroPanel2.UseCustomBackColor = true;
			this.metroPanel2.VerticalScrollbarBarColor = true;
			this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel2.VerticalScrollbarSize = 10;
			this.metroLabel11.AutoSize = true;
			this.metroLabel11.Location = new global::System.Drawing.Point(176, 142);
			this.metroLabel11.Name = "metroLabel11";
			this.metroLabel11.Size = new global::System.Drawing.Size(57, 19);
			this.metroLabel11.TabIndex = 15;
			this.metroLabel11.Text = "Settings:";
			this.metroLabel11.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel11.UseCustomBackColor = true;
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new global::System.Drawing.Point(309, 108);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new global::System.Drawing.Size(55, 19);
			this.metroLabel6.TabIndex = 14;
			this.metroLabel6.Text = "- Scope";
			this.metroLabel6.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel6.UseCustomBackColor = true;
			this.metroComboBox3.BackColor = global::System.Drawing.Color.White;
			this.metroComboBox3.ForeColor = global::System.Drawing.SystemColors.WindowFrame;
			this.metroComboBox3.FormattingEnabled = true;
			this.metroComboBox3.ItemHeight = 23;
			this.metroComboBox3.Items.AddRange(new object[]
			{
				"Simple Handmade Sight",
				"Holosight",
				"8x Zoom Scope",
				"16x Zoom Scope",
				"None"
			});
			this.metroComboBox3.Location = new global::System.Drawing.Point(93, 98);
			this.metroComboBox3.Name = "metroComboBox3";
			this.metroComboBox3.Size = new global::System.Drawing.Size(197, 29);
			this.metroComboBox3.TabIndex = 13;
			this.metroComboBox3.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroComboBox3.UseCustomBackColor = true;
			this.metroComboBox3.UseSelectable = true;
			this.metroComboBox3.SelectedIndexChanged += new global::System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new global::System.Drawing.Point(309, 73);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new global::System.Drawing.Size(86, 19);
			this.metroLabel5.TabIndex = 12;
			this.metroLabel5.Text = "- Attachment";
			this.metroLabel5.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel5.UseCustomBackColor = true;
			this.metroComboBox2.BackColor = global::System.Drawing.Color.White;
			this.metroComboBox2.ForeColor = global::System.Drawing.SystemColors.WindowFrame;
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Items.AddRange(new object[]
			{
				"Muzzle Boost",
				"Muzzle Brake",
				"Silencer",
				"None"
			});
			this.metroComboBox2.Location = new global::System.Drawing.Point(93, 63);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.Size = new global::System.Drawing.Size(197, 29);
			this.metroComboBox2.TabIndex = 11;
			this.metroComboBox2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroComboBox2.UseCustomBackColor = true;
			this.metroComboBox2.UseSelectable = true;
			this.metroComboBox2.SelectedIndexChanged += new global::System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new global::System.Drawing.Point(324, 232);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new global::System.Drawing.Size(124, 19);
			this.metroLabel4.TabIndex = 10;
			this.metroLabel4.Text = "Smoothing Amount";
			this.metroLabel4.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel4.UseCustomBackColor = true;
			this.metroTrackBar3.BackColor = global::System.Drawing.Color.Transparent;
			this.metroTrackBar3.LargeChange = 1;
			this.metroTrackBar3.Location = new global::System.Drawing.Point(93, 232);
			this.metroTrackBar3.Maximum = 10;
			this.metroTrackBar3.Minimum = 1;
			this.metroTrackBar3.Name = "metroTrackBar3";
			this.metroTrackBar3.Size = new global::System.Drawing.Size(200, 25);
			this.metroTrackBar3.TabIndex = 9;
			this.metroTrackBar3.Text = "metroTrackBar3";
			this.metroTrackBar3.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroTrackBar3.UseCustomBackColor = true;
			this.metroTrackBar3.Value = 1;
			this.metroTrackBar3.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.metroTrackBar3_Scroll);
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new global::System.Drawing.Point(309, 34);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new global::System.Drawing.Size(68, 19);
			this.metroLabel3.TabIndex = 8;
			this.metroLabel3.Text = "- Weapon";
			this.metroLabel3.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel3.UseCustomBackColor = true;
			this.metroLabel3.Click += new global::System.EventHandler(this.metroLabel3_Click);
			this.metroComboBox1.BackColor = global::System.Drawing.Color.White;
			this.metroComboBox1.ForeColor = global::System.Drawing.SystemColors.WindowFrame;
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Items.AddRange(new object[]
			{
				"Assault Rifle",
				"LR-300 Assault Rifle",
				"M249",
				"Custom SMG",
				"MP5A4",
				"Thompson",
				"None"
			});
			this.metroComboBox1.Location = new global::System.Drawing.Point(93, 24);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new global::System.Drawing.Size(197, 29);
			this.metroComboBox1.TabIndex = 7;
			this.metroComboBox1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroComboBox1.UseCustomBackColor = true;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.SelectedIndexChanged += new global::System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new global::System.Drawing.Point(360, 204);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new global::System.Drawing.Size(65, 19);
			this.metroLabel2.TabIndex = 6;
			this.metroLabel2.Text = "Y Control";
			this.metroLabel2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel2.UseCustomBackColor = true;
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new global::System.Drawing.Point(360, 173);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new global::System.Drawing.Size(69, 19);
			this.metroLabel1.TabIndex = 5;
			this.metroLabel1.Text = "X Control ";
			this.metroLabel1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseCustomBackColor = true;
			this.metroTrackBar1.BackColor = global::System.Drawing.Color.Transparent;
			this.metroTrackBar1.LargeChange = 1;
			this.metroTrackBar1.Location = new global::System.Drawing.Point(93, 173);
			this.metroTrackBar1.Maximum = 99;
			this.metroTrackBar1.Name = "metroTrackBar1";
			this.metroTrackBar1.Size = new global::System.Drawing.Size(200, 25);
			this.metroTrackBar1.TabIndex = 4;
			this.metroTrackBar1.Text = "metroTrackBar1";
			this.metroTrackBar1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroTrackBar1.UseCustomBackColor = true;
			this.metroTrackBar1.Value = 0;
			this.metroTrackBar2.BackColor = global::System.Drawing.Color.Transparent;
			this.metroTrackBar2.LargeChange = 1;
			this.metroTrackBar2.Location = new global::System.Drawing.Point(93, 204);
			this.metroTrackBar2.Minimum = 1;
			this.metroTrackBar2.Name = "metroTrackBar2";
			this.metroTrackBar2.Size = new global::System.Drawing.Size(200, 25);
			this.metroTrackBar2.TabIndex = 3;
			this.metroTrackBar2.Text = "metroTrackBar2";
			this.metroTrackBar2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroTrackBar2.UseCustomBackColor = true;
			this.metroTrackBar2.Value = 1;
			this.metroLabel7.AutoSize = true;
			this.metroLabel7.Location = new global::System.Drawing.Point(187, 70);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new global::System.Drawing.Size(138, 19);
			this.metroLabel7.TabIndex = 2;
			this.metroLabel7.Text = "Coded By evan#3394 ";
			this.metroLabel7.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel7.UseCustomBackColor = true;
			this.metroLabel10.AutoSize = true;
			this.metroLabel10.Location = new global::System.Drawing.Point(175, 51);
			this.metroLabel10.Name = "metroLabel10";
			this.metroLabel10.Size = new global::System.Drawing.Size(162, 19);
			this.metroLabel10.TabIndex = 3;
			this.metroLabel10.Text = "Current Build Version: 1.0.1";
			this.metroLabel10.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel10.UseCustomBackColor = true;
			this.metroLabel10.Click += new global::System.EventHandler(this.metroLabel10_Click);
			this.metroPanel1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.metroPanel1.BackColor = global::System.Drawing.Color.Black;
			this.metroPanel1.BackgroundImage = global::Debil.Vision.Properties.Resources.vision;
			this.metroPanel1.Controls.Add(this.metroCheckBox5);
			this.metroPanel1.Controls.Add(this.metroCheckBox4);
			this.metroPanel1.Controls.Add(this.metroLabel9);
			this.metroPanel1.Controls.Add(this.numericUpDown2);
			this.metroPanel1.Controls.Add(this.metroLabel8);
			this.metroPanel1.Controls.Add(this.numericUpDown1);
			this.metroPanel1.Controls.Add(this.metroCheckBox3);
			this.metroPanel1.Controls.Add(this.metroCheckBox2);
			this.metroPanel1.Controls.Add(this.metroCheckBox1);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new global::System.Drawing.Point(23, 103);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new global::System.Drawing.Size(464, 285);
			this.metroPanel1.Style = global::MetroFramework.MetroColorStyle.Red;
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.metroPanel1.UseCustomBackColor = true;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			this.metroCheckBox5.AutoSize = true;
			this.metroCheckBox5.BackColor = global::System.Drawing.Color.Black;
			this.metroCheckBox5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.metroCheckBox5.Location = new global::System.Drawing.Point(3, 248);
			this.metroCheckBox5.Name = "metroCheckBox5";
			this.metroCheckBox5.Size = new global::System.Drawing.Size(89, 15);
			this.metroCheckBox5.TabIndex = 17;
			this.metroCheckBox5.Text = "Magic Bullet";
			this.metroCheckBox5.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBox5.UseCustomBackColor = true;
			this.metroCheckBox5.UseSelectable = true;
			this.metroCheckBox4.AutoSize = true;
			this.metroCheckBox4.BackColor = global::System.Drawing.Color.Black;
			this.metroCheckBox4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.metroCheckBox4.Location = new global::System.Drawing.Point(3, 269);
			this.metroCheckBox4.Name = "metroCheckBox4";
			this.metroCheckBox4.Size = new global::System.Drawing.Size(230, 15);
			this.metroCheckBox4.TabIndex = 16;
			this.metroCheckBox4.Text = "Auto Weapon Detection (Experimental)";
			this.metroCheckBox4.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBox4.UseCustomBackColor = true;
			this.metroCheckBox4.UseSelectable = true;
			this.metroLabel9.AutoSize = true;
			this.metroLabel9.Location = new global::System.Drawing.Point(152, 176);
			this.metroLabel9.Name = "metroLabel9";
			this.metroLabel9.Size = new global::System.Drawing.Size(138, 19);
			this.metroLabel9.TabIndex = 15;
			this.metroLabel9.Text = "Current Field Of View:";
			this.metroLabel9.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel9.UseCustomBackColor = true;
			this.numericUpDown2.BackColor = global::System.Drawing.SystemColors.InactiveBorder;
			this.numericUpDown2.ForeColor = global::System.Drawing.SystemColors.WindowFrame;
			this.numericUpDown2.Location = new global::System.Drawing.Point(173, 198);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown2;
			int[] array = new int[4];
			array[0] = 90;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown2;
			int[] array2 = new int[4];
			array2[0] = 60;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(88, 20);
			this.numericUpDown2.TabIndex = 14;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown2;
			int[] array3 = new int[4];
			array3[0] = 90;
			numericUpDown3.Value = new decimal(array3);
			this.numericUpDown2.ValueChanged += new global::System.EventHandler(this.numericUpDown2_ValueChanged);
			this.metroLabel8.AutoSize = true;
			this.metroLabel8.Location = new global::System.Drawing.Point(164, 221);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.Size = new global::System.Drawing.Size(115, 19);
			this.metroLabel8.TabIndex = 13;
			this.metroLabel8.Text = "Current Sensitivity:";
			this.metroLabel8.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel8.UseCustomBackColor = true;
			this.numericUpDown1.BackColor = global::System.Drawing.SystemColors.Window;
			this.numericUpDown1.DecimalPlaces = 2;
			this.numericUpDown1.ForeColor = global::System.Drawing.SystemColors.WindowFrame;
			this.numericUpDown1.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				131072
			});
			this.numericUpDown1.Location = new global::System.Drawing.Point(173, 243);
			this.numericUpDown1.Maximum = new decimal(new int[]
			{
				20,
				0,
				0,
				65536
			});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(88, 20);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.Value = new decimal(new int[]
			{
				10,
				0,
				0,
				65536
			});
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.metroCheckBox3.AutoSize = true;
			this.metroCheckBox3.BackColor = global::System.Drawing.Color.Black;
			this.metroCheckBox3.Location = new global::System.Drawing.Point(4, 24);
			this.metroCheckBox3.Name = "metroCheckBox3";
			this.metroCheckBox3.Size = new global::System.Drawing.Size(103, 15);
			this.metroCheckBox3.TabIndex = 6;
			this.metroCheckBox3.Text = "Randomisation";
			this.metroCheckBox3.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBox3.UseCustomBackColor = true;
			this.metroCheckBox3.UseSelectable = true;
			this.metroCheckBox3.CheckedChanged += new global::System.EventHandler(this.metroCheckBox3_CheckedChanged);
			this.metroCheckBox2.AutoSize = true;
			this.metroCheckBox2.BackColor = global::System.Drawing.Color.Black;
			this.metroCheckBox2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.metroCheckBox2.Location = new global::System.Drawing.Point(4, 45);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new global::System.Drawing.Size(153, 15);
			this.metroCheckBox2.TabIndex = 3;
			this.metroCheckBox2.Text = "X and Y Control Amount";
			this.metroCheckBox2.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBox2.UseCustomBackColor = true;
			this.metroCheckBox2.UseSelectable = true;
			this.metroCheckBox2.CheckedChanged += new global::System.EventHandler(this.metroCheckBox2_CheckedChanged);
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.BackColor = global::System.Drawing.Color.Black;
			this.metroCheckBox1.FontWeight = global::MetroFramework.MetroCheckBoxWeight.Bold;
			this.metroCheckBox1.Location = new global::System.Drawing.Point(4, 3);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new global::System.Drawing.Size(63, 15);
			this.metroCheckBox1.TabIndex = 2;
			this.metroCheckBox1.Text = "On/Off";
			this.metroCheckBox1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBox1.UseCustomBackColor = true;
			this.metroCheckBox1.UseSelectable = true;
			this.metroCheckBox1.CheckedChanged += new global::System.EventHandler(this.metroCheckBox1_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.BackImage = global::Debil.Vision.Properties.Resources.vision;
			base.ClientSize = new global::System.Drawing.Size(510, 665);
			base.Controls.Add(this.metroLabel10);
			base.Controls.Add(this.metroLabel7);
			base.Controls.Add(this.metroPanel2);
			base.Controls.Add(this.metroPanel1);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			base.MaximizeBox = false;
			base.Name = "Menu";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
			base.Style = global::MetroFramework.MetroColorStyle.Teal;
			this.Text = "Vision";
			base.TextAlign = global::MetroFramework.Forms.MetroFormTextAlign.Center;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
			base.Load += new global::System.EventHandler(this.Menu_Load);
			this.metroPanel2.ResumeLayout(false);
			this.metroPanel2.PerformLayout();
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000069 RID: 105
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400006A RID: 106
		private global::MetroFramework.Controls.MetroTabControl metroTabControl1;

		// Token: 0x0400006B RID: 107
		private global::MetroFramework.Controls.MetroPanel metroPanel1;

		// Token: 0x0400006C RID: 108
		private global::MetroFramework.Controls.MetroPanel metroPanel2;

		// Token: 0x0400006D RID: 109
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox1;

		// Token: 0x0400006E RID: 110
		private global::MetroFramework.Controls.MetroComboBox metroComboBox1;

		// Token: 0x0400006F RID: 111
		private global::MetroFramework.Controls.MetroLabel metroLabel3;

		// Token: 0x04000070 RID: 112
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox2;

		// Token: 0x04000071 RID: 113
		private global::MetroFramework.Controls.MetroLabel metroLabel4;

		// Token: 0x04000072 RID: 114
		private global::MetroFramework.Controls.MetroTrackBar metroTrackBar3;

		// Token: 0x04000073 RID: 115
		private global::MetroFramework.Controls.MetroLabel metroLabel5;

		// Token: 0x04000074 RID: 116
		private global::MetroFramework.Controls.MetroComboBox metroComboBox2;

		// Token: 0x04000075 RID: 117
		private global::MetroFramework.Controls.MetroLabel metroLabel6;

		// Token: 0x04000076 RID: 118
		private global::MetroFramework.Controls.MetroComboBox metroComboBox3;

		// Token: 0x04000077 RID: 119
		private global::MetroFramework.Controls.MetroLabel metroLabel7;

		// Token: 0x04000078 RID: 120
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox3;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x0400007A RID: 122
		private global::MetroFramework.Controls.MetroLabel metroLabel9;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x0400007C RID: 124
		private global::MetroFramework.Controls.MetroLabel metroLabel8;

		// Token: 0x0400007D RID: 125
		private global::MetroFramework.Controls.MetroLabel metroLabel10;

		// Token: 0x0400007E RID: 126
		private global::MetroFramework.Controls.MetroLabel metroLabel1;

		// Token: 0x0400007F RID: 127
		private global::MetroFramework.Controls.MetroTrackBar metroTrackBar1;

		// Token: 0x04000080 RID: 128
		private global::MetroFramework.Controls.MetroLabel metroLabel2;

		// Token: 0x04000081 RID: 129
		private global::MetroFramework.Controls.MetroTrackBar metroTrackBar2;

		// Token: 0x04000082 RID: 130
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox4;

		// Token: 0x04000083 RID: 131
		private global::MetroFramework.Controls.MetroCheckBox metroCheckBox5;

		// Token: 0x04000084 RID: 132
		private global::MetroFramework.Controls.MetroLabel metroLabel11;
	}
}
