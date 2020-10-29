namespace AppLojaJogos
{
    partial class FrmLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLayout));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnComprar = new System.Windows.Forms.Button();
            this.cblj = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pbww = new System.Windows.Forms.PictureBox();
            this.pbhh = new System.Windows.Forms.PictureBox();
            this.pbcc = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pbw = new System.Windows.Forms.PictureBox();
            this.pbh = new System.Windows.Forms.PictureBox();
            this.pbc = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbww)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.CustomBackground = true;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 1);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(700, 444);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage1.Controls.Add(this.button1);
            this.metroTabPage1.Controls.Add(this.pbww);
            this.metroTabPage1.Controls.Add(this.pbhh);
            this.metroTabPage1.Controls.Add(this.pbcc);
            this.metroTabPage1.Controls.Add(this.btnComprar);
            this.metroTabPage1.Controls.Add(this.cblj);
            this.metroTabPage1.Controls.Add(this.pictureBox4);
            this.metroTabPage1.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(692, 402);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Loja";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnComprar.Location = new System.Drawing.Point(297, 350);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(111, 37);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.toolTip1.SetToolTip(this.btnComprar, "Comprar");
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // cblj
            // 
            this.cblj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cblj.FormattingEnabled = true;
            this.cblj.Items.AddRange(new object[] {
            "Horizon Zero Dawn",
            "CyberPunk 2077",
            "Watch Dogs Legion"});
            this.cblj.Location = new System.Drawing.Point(258, 323);
            this.cblj.Name = "cblj";
            this.cblj.Size = new System.Drawing.Size(190, 21);
            this.cblj.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cblj, "Escolher Jogos");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(672, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "?";
            this.toolTip1.SetToolTip(this.button1, "Um 10 né? ;-; Delphi só problema a semana toda dava não, fiz no Visual de última " +
        "hora ;-;");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pbww
            // 
            this.pbww.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbww.Image = global::AppLojaJogos.Properties.Resources.wdl3;
            this.pbww.Location = new System.Drawing.Point(34, 21);
            this.pbww.Name = "pbww";
            this.pbww.Size = new System.Drawing.Size(636, 280);
            this.pbww.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbww.TabIndex = 11;
            this.pbww.TabStop = false;
            this.toolTip1.SetToolTip(this.pbww, "Watch Dogs Legion");
            // 
            // pbhh
            // 
            this.pbhh.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbhh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbhh.Image = global::AppLojaJogos.Properties.Resources.hzd;
            this.pbhh.Location = new System.Drawing.Point(34, 21);
            this.pbhh.Name = "pbhh";
            this.pbhh.Size = new System.Drawing.Size(636, 280);
            this.pbhh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbhh.TabIndex = 10;
            this.pbhh.TabStop = false;
            this.toolTip1.SetToolTip(this.pbhh, "Horizon Zero Down");
            // 
            // pbcc
            // 
            this.pbcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbcc.Image = global::AppLojaJogos.Properties.Resources.cp2;
            this.pbcc.Location = new System.Drawing.Point(34, 21);
            this.pbcc.Name = "pbcc";
            this.pbcc.Size = new System.Drawing.Size(636, 280);
            this.pbcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcc.TabIndex = 9;
            this.pbcc.TabStop = false;
            this.toolTip1.SetToolTip(this.pbcc, "CyberPunk 2077");
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::AppLojaJogos.Properties.Resources.wdl;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-74, -27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(850, 466);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackgroundImage = global::AppLojaJogos.Properties.Resources.wdl;
            this.metroTabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroTabPage2.Controls.Add(this.pbw);
            this.metroTabPage2.Controls.Add(this.pbh);
            this.metroTabPage2.Controls.Add(this.pbc);
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(692, 402);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Biblioteca";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // pbw
            // 
            this.pbw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbw.Image = global::AppLojaJogos.Properties.Resources.wdl31;
            this.pbw.Location = new System.Drawing.Point(186, 198);
            this.pbw.Name = "pbw";
            this.pbw.Size = new System.Drawing.Size(302, 150);
            this.pbw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbw.TabIndex = 8;
            this.pbw.TabStop = false;
            this.pbw.Visible = false;
            this.pbw.Click += new System.EventHandler(this.pbw_Click);
            // 
            // pbh
            // 
            this.pbh.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbh.Image = global::AppLojaJogos.Properties.Resources.hzd1;
            this.pbh.Location = new System.Drawing.Point(20, 42);
            this.pbh.Name = "pbh";
            this.pbh.Size = new System.Drawing.Size(302, 150);
            this.pbh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbh.TabIndex = 7;
            this.pbh.TabStop = false;
            this.pbh.Visible = false;
            this.pbh.Click += new System.EventHandler(this.pbh_Click);
            // 
            // pbc
            // 
            this.pbc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbc.Image = global::AppLojaJogos.Properties.Resources.cp21;
            this.pbc.Location = new System.Drawing.Point(368, 42);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(302, 150);
            this.pbc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbc.TabIndex = 6;
            this.pbc.TabStop = false;
            this.pbc.Visible = false;
            this.pbc.Click += new System.EventHandler(this.pbc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppLojaJogos.Properties.Resources.wdl;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-28, -48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 446);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(716, 485);
            this.MinimumSize = new System.Drawing.Size(716, 485);
            this.Name = "FrmLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videogedoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLayout_FormClosed);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbww)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.PictureBox pbww;
        private System.Windows.Forms.PictureBox pbhh;
        private System.Windows.Forms.PictureBox pbcc;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ComboBox cblj;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.PictureBox pbw;
        private System.Windows.Forms.PictureBox pbh;
        private System.Windows.Forms.PictureBox pbc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}