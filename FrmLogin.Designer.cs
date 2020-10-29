namespace AppLojaJogos
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnReg = new System.Windows.Forms.Button();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pbico2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbico2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.BackColor = System.Drawing.Color.Transparent;
            this.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.7F, System.Drawing.FontStyle.Bold);
            this.btnReg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReg.Location = new System.Drawing.Point(220, 260);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(86, 23);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "Registrar-se";
            this.toolTip1.SetToolTip(this.btnReg, "Registrar-se");
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // BtnLogar
            // 
            this.BtnLogar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogar.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.7F, System.Drawing.FontStyle.Bold);
            this.BtnLogar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnLogar.Location = new System.Drawing.Point(123, 197);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(75, 23);
            this.BtnLogar.TabIndex = 11;
            this.BtnLogar.Text = "Logar";
            this.BtnLogar.UseVisualStyleBackColor = false;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(81, 167);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(158, 24);
            this.txtSenha.TabIndex = 10;
            this.txtSenha.Text = "Senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtSenha, "Senha");
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(81, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 24);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEmail, "E-mail");
            this.txtEmail.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtEmail_DragEnter);
            this.txtEmail.DragLeave += new System.EventHandler(this.txtEmail_DragLeave);
            // 
            // pbico2
            // 
            this.pbico2.Image = global::AppLojaJogos.Properties.Resources.iconfinder_user_male2_172626;
            this.pbico2.Location = new System.Drawing.Point(110, 31);
            this.pbico2.Name = "pbico2";
            this.pbico2.Size = new System.Drawing.Size(100, 100);
            this.pbico2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbico2.TabIndex = 13;
            this.pbico2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.pbico2);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(334, 334);
            this.MinimumSize = new System.Drawing.Size(334, 334);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videogedoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Click += new System.EventHandler(this.FrmLogin_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbico2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbico2;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}