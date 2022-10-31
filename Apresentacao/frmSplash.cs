using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegraNegocioLojaUnipes
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // frmLogin frm = new frmLogin();
          //  progressBar1.Visible = true;

            this.progressBar1.Value = this.progressBar1.Value + 2;
            if (this.progressBar1.Value == 10)
            {
                label3.Text = "Lendo modulos..";
            }
            else if (this.progressBar1.Value == 20)
            {
                label3.Text = "Ativando modulos.";
            }
            else if (this.progressBar1.Value == 40)
            {
                label3.Text = "Iniciando modulos..";
            }
            else if (this.progressBar1.Value == 60)
            {
                label3.Text = "Carregando modulos..";
            }
            else if (this.progressBar1.Value == 80)
            {
                label3.Text = "Preparando modules..";
            }
            else if (this.progressBar1.Value == 100)
            {
                //frm.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            progressBar1.Width = this.Width;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
