using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLojaJogos
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(txtNome.Text, txtEmail.Text, txtSenha.Text);
            MessageBox.Show(cad.mensagem);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            FrmLogin reg = new FrmLogin();
            this.Hide();
            reg.ShowDialog();
        }

        private void FrmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nick")
            {
                txtNome.Clear();
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nick")
            {
                txtNome.Clear();
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-mail")
            {
                txtEmail.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-mail";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Clear();
            }
            txtSenha.UseSystemPasswordChar = true;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.UseSystemPasswordChar = false;
            }

            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
            }
        }

        private void FrmRegistro_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
            }

            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-mail";
            }

            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
            }
        }

        private void txtRSenha_Enter(object sender, EventArgs e)
        {
            if (txtRSenha.Text == "Repetir Senha")
            {
                txtRSenha.Clear();
            }
            txtRSenha.UseSystemPasswordChar = true;
        }
    }
}
