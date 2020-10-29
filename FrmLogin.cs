using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppLojaJogos
{
    public partial class FrmLogin : Form
    {

        int i;
        private MySqlConnection mCon;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            mCon = new MySqlConnection("Persist Security Info = False; server=31.220.17.49;database=toppixel_nation1;uid=toppixel;password=nationcraft568301)!;");
            mCon.Open();

            MySqlCommand cmd = mCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From TB_USUARIO where Email='" + txtEmail.Text + "' and Senha='" + txtSenha.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Invalido");
            }
            else
            {
                FrmLayout lay = new FrmLayout();
                this.Hide();
                lay.ShowDialog();
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            FrmRegistro reg = new FrmRegistro();
            this.Hide();
            reg.ShowDialog();
        }

        private void txtEmail_DragEnter(object sender, DragEventArgs e)
        {

            FrmRegistro reg = new FrmRegistro();
            this.Hide();
            reg.ShowDialog();
        }

        private void txtEmail_DragLeave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-mail";
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

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

        private void FrmLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-mail";
            }

            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
            }

        }
    }
}
