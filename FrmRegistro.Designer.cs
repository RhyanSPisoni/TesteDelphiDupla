namespace AppLojaJogos
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.txtRSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pbIco = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbIco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRSenha
            // 
            this.txtRSenha.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.txtRSenha.Location = new System.Drawing.Point(80, 218);
            this.txtRSenha.Name = "txtRSenha";
            this.txtRSenha.Size = new System.Drawing.Size(158, 24);
            this.txtRSenha.TabIndex = 18;
            this.txtRSenha.Text = "Repetir Senha";
            this.txtRSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtRSenha, "Repetir Senha");
            this.txtRSenha.Enter += new System.EventHandler(this.txtRSenha_Enter);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(80, 188);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(158, 24);
            this.txtSenha.TabIndex = 14;
            this.txtSenha.Text = "Senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtSenha, "Senha");
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(80, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 24);
            this.txtNome.TabIndex = 12;
            this.txtNome.Text = "Nick";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNome, "Nick");
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(80, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 24);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEmail, "E-mail");
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.7F, System.Drawing.FontStyle.Bold);
            this.btnLogar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnLogar.Location = new System.Drawing.Point(163, 249);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 16;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.7F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRegistrar.Location = new System.Drawing.Point(80, 249);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pbIco
            // 
            this.pbIco.Image = global::AppLojaJogos.Properties.Resources.iconfinder_user_male2_172626;
            this.pbIco.Location = new System.Drawing.Point(109, 22);
            this.pbIco.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbIco.Name = "pbIco";
            this.pbIco.Size = new System.Drawing.Size(100, 100);
            this.pbIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIco.TabIndex = 17;
            this.pbIco.TabStop = false;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.txtRSenha);
            this.Controls.Add(this.pbIco);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(334, 334);
            this.MaximumSize = new System.Drawing.Size(334, 334);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videogedoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistro_FormClosed);
            this.Click += new System.EventHandler(this.FrmRegistro_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRSenha;
        private System.Windows.Forms.PictureBox pbIco;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}