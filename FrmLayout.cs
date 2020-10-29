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
    public partial class FrmLayout : Form
    {
        public FrmLayout()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (cblj.Text == "Watch Dogs Legion")
            {
                MessageBox.Show("Obrigado por ter comprado o Watch Dogs Legion |" + DateTime.Now.Hour + "às horas do dia " + DateTime.Now.Day +" do mês " + DateTime.Now.Month + " no ano de " + DateTime.Now.Year +"|");
                pbw.Visible = true;
            }

            if (cblj.Text == "Horizon Zero Dawn")
            {
                MessageBox.Show("Obrigado por ter comprado o Horizon Zero Dawn |" + DateTime.Now.Hour + "às horas do dia " + DateTime.Now.Day + " do mês " + DateTime.Now.Month + " no ano de " + DateTime.Now.Year + "|");
                pbh.Visible = true;
            }

            if (cblj.Text == "CyberPunk 2077")
            {
                MessageBox.Show("Obrigado por ter comprado o CyberPunk 2077 |" + DateTime.Now.Hour + "às horas do dia " + DateTime.Now.Day + " do mês " + DateTime.Now.Month + " no ano de " + DateTime.Now.Year + "|");
                pbc.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cblj.Text == "Watch Dogs Legion")
            {
                pbww.Visible = true;
                pbcc.Visible = false;
                pbhh.Visible = false;
            }

            if (cblj.Text == "CyberPunk 2077")
            {
                pbcc.Visible = true;
                pbww.Visible = false;
                pbhh.Visible = false;
            }

            if (cblj.Text == "Horizon Zero Dawn")
            {
                pbh.Visible = true;
                pbc.Visible = false;
                pbw.Visible = false;
            }
        }

        private void pbh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu foi trolado ao iniciar o Jogo :D Hehe dinheiro mole mole");
        }

        private void pbc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu foi trolado ao iniciar o Jogo :D Hehe dinheiro mole mole");
        }

        private void pbw_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu foi trolado ao iniciar o Jogo :D Hehe dinheiro mole mole");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLayout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
